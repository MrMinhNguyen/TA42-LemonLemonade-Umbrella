# Import libraries
from flask import Flask
from flask import request
import requests
import json
import mysql.connector
import random


# ------------------------------
# Define the auxiliary functions
# ------------------------------

# STATIC URLs
OPENUV_URL_RECENT = "https://api.openuv.io/api/v1/uv"

# This function reads the text file contains the API keys and randomly return 1 of them
def get_api_key():
    all_keys = []
    f = open('open_uv_api_keys.txt', 'r')
    lines = f.readlines()
    for l in lines:
        all_keys.append(str(l).rstrip())
    return random.choice(all_keys)
        
# This function return a connection to the database
def connect_to_db():
    return mysql.connector.connect(
        host="localhost",
        user="lemon",
        password="FIT5120lemonade",
        database="lemon_lemonade"
    )

# This function find the given suburb info from the database
def find_coordinate(postcode):
    db_connection = connect_to_db()
    db_cursor = db_connection.cursor()
    db_cursor.execute("SELECT * FROM suburbs WHERE postcode="+postcode)
    # If valid post code then return actual result
    try:
        record = db_cursor.fetchall()[0]
        coord = {
            'lat': record[2],
            'lng': record[3]
        }
        suburb_info = {
            'postcode': record[0],
            'name': record[1]
        }
    # If invalid post code then return default result
    except Exception:
        coord = {
            'lat': '0',
            'lng': '0'
        }
        suburb_info = {
            'postcode': '0',
            'name': 'Default data'
        }
    finally:
        return [coord, suburb_info]

# -------------------------
# Create the API aplication
# -------------------------
app = Flask(__name__)


# -----------------
# Generate the APIs
# -----------------

# API to get current UVR for 18 suburbs near the CBD
@app.route('/uvr_inner_suburbs')
def uvr_inner_suburbs():
    # 18 Innter suburbs 10km away from CBD
    INNER_SUBURBS = ['3000', '3003', '3004', '3008', '3010', '3050', 
                    '3051', '3051', '3052', '3052', '3053', '3053', 
                    '3054', '3054', '3065', '3066', '3066', '3067']

    # List of data to return
    result=[]

    # Get data for each postcode
    for postcode in INNER_SUBURBS:
        # Get coordinates from database
        PARAMS = find_coordinate(postcode)[0]
        suburb_info = find_coordinate(postcode)[1]
        
        # Send API request to OpenUV
        req = requests.get(url=OPENUV_URL_RECENT, params=PARAMS, headers={"x-access-token": get_api_key()})
        data = json.loads(req.text)
        
        # Compose result data
        result.append({
            'postcode': postcode,
            'suburb': suburb_info['name'],
            'UVR': data['result']['uv'],
            'max_UVR': data['result']['uv_max']
        })
    return result

# API to get current UVR for a specific location
@app.route('/uvr_location')
def uvr_location():

    postcode = request.args.get('postcode')
    
    # Get coordinates from database
    PARAMS = find_coordinate(postcode)[0]
    suburb_info = find_coordinate(postcode)[1]

    # Send API request to OpenUV
    req = requests.get(url=OPENUV_URL_RECENT, params=PARAMS, headers={"x-access-token": get_api_key()})
    data = json.loads(req.text)
    
    # Compose and return result data
    result = {
        'postcode': postcode,
        'suburb': suburb_info['name'],
        'UVR': data['result']['uv'],
        'max_UVR': data['result']['uv_max']
    }
    return result

# API to get historical UVR group by Months
@app.route('/uv_by_month')
def uv_by_month():
    # Create connection to database
    db_connection = connect_to_db()

    # Create and execute SQL query
    db_cursor = db_connection.cursor()
    db_cursor.execute("SELECT * FROM uvr")
    records = db_cursor.fetchall()

    # List of data to return
    result = []

    # Compose and return result data
    for rec in records:
        result.append({
            'month': rec[1],
            'year': rec[2],
            'avg_UVR': rec[3]
        })
    return result

# API to get historical UVR group by Years
@app.route('/uvr_by_year')
def uvr_by_year():
    # Create connection to database
    db_connection = connect_to_db()

    # Create and execute SQL query
    db_cursor = db_connection.cursor()
    db_cursor.execute("SELECT year, AVG(uv_index) AS avg_uv FROM uvr GROUP BY year")
    records = db_cursor.fetchall()

    # List of data to return
    result = []

    # Compose and return result data
    for rec in records:
        result.append({
            'year': rec[0],
            'avg_UVR': rec[1]
        })
    return result

# @app.route('/uvr_protector')
# def uvr_protector():

#     uvr = request.args.get('uvr')
#     # Query data from DB

#     return 'protector for an UVR' + str(uvr)

# @app.route('/all_protectors')
# def all_protectors():
#     # Query data from DB
#     return 'All protecctors'
    
# The main API application would be run (on localhost) at port 8080
if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080)