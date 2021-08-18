from flask import Flask
from flask import request
import requests
import json
import mysql.connector
import random

OPENUV_URL_RECENT = "https://api.openuv.io/api/v1/uv"

def get_api_key():
    all_keys = []
    f = open('open_uv_api_keys.txt', 'r')
    lines = f.readlines()
    for l in lines:
        all_keys.append(l)
    return random.choice(all_keys)
        

def connect_to_db():
    return mysql.connector.connect(
        host="localhost",
        user="lemon",
        password="FIT5120lemonade",
        database="lemon_lemonade"
    )

def find_coordinate(postcode):
    db_connection = connect_to_db()
    db_cursor = db_connection.cursor()
    db_cursor.execute("SELECT * FROM suburbs WHERE postcode="+postcode)
    record = db_cursor.fetchall()[0]
    result = {
        'lat': record[2],
        'lng': record[3]
        }
    return result


app = Flask(__name__)

@app.route('/uvr_inner_suburbs')
def uvr_inner_suburbs():
    # 17 Innter suburbs 10km away from CBD
    INNER_SUBURBS = [3000, 3003, 3004, 3008, 3010, 3050, 3051, 3051, 3052, 3052, 3053, 3053, 3054, 3054, 3065, 3066, 3066, 3067]

    result=[]

    for postcode in INNER_SUBURBS:
        PARAMS = find_coordinate(postcode)
        req = requests.get(url=OPENUV_URL_RECENT, params=PARAMS, headers={"x-access-token": get_api_key()})
        data = json.loads(req.text)
        result.append({
            'postcode': postcode,
            'UVR': data['result']['uv']
        })

    return result

@app.route('/uvr_location')
def uvr_location():

    postcode = request.args.get('postcode')
    PARAMS = find_coordinate(postcode)
    req = requests.get(url=OPENUV_URL_RECENT, params=PARAMS, headers={"x-access-token": get_api_key()})
    data = json.loads(req.text)
    result = {
        'postcode': postcode,
        'UVR': data['result']['uv']
    }
    return result

# @app.route('/uv_by_month')
# def uv_by_month():
#     # Query data from DB
#     return 'UVR by Month'

# @app.route('/uvr_by_year')
# def uvr_by_year():
#     # Query data from DB
#     return 'UVR by Year'

# @app.route('/uvr_protector')
# def uvr_protector():

#     uvr = request.args.get('uvr')
#     # Query data from DB

#     return 'protector for an UVR' + str(uvr)

# @app.route('/all_protectors')
# def all_protectors():
#     # Query data from DB
#     return 'All protecctors'
    

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080)