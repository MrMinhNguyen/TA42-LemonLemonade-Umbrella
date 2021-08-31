from sqlalchemy import create_engine
import pandas as pd

# Get azure authentication
all_info = []
f = open('azure_database_authentication.txt', 'r')
lines = f.readlines()
for l in lines:
    all_info.append(str(l).rstrip())
db_info = {
    'server_name': all_info[0],
    'user_name': all_info[1],
    'pwd': all_info[2],
    'db_name': all_info[3] 
}

# Create connection to DB
engine = create_engine(
    "mysql+mysqlconnector://{user_name}:{pwd}@{server_name}/{db_name}".format(
        user_name=db_info['user_name'],
        pwd=db_info['pwd'],
        server_name=db_info['server_name'],
        db_name=db_info['db_name']
    )
)

# read hat, sunglasses, sunscreen, umbrella_n_clothes dataset from local file
hat = pd.read_csv("protectors/hat.csv")
sunglasses = pd.read_csv("protectors/sunglasses.csv")
sunscreen = pd.read_csv("protectors/sunscreen.csv")
umbrella_n_clothes = pd.read_csv("protectors/umbrella_n_clothes.csv")

# Insert whole DataFrame into MySQL
hat.to_sql('hat', con=engine, if_exists='append', chunksize=1000)
sunglasses.to_sql('sunglasses', con=engine, if_exists='append', chunksize=1000)
sunscreen.to_sql('sunscreen', con=engine, if_exists='append', chunksize=1000)
umbrella_n_clothes.to_sql('umbrella_clothes', con=engine, if_exists='append', chunksize=1000)

# Read postcode data
suburbs = pd.read_csv("australian_postcodes.csv")
suburbs = suburbs[['postcode', 'locality', 'long', 'lat', 'state']]
suburbs = suburbs[suburbs.state == 'VIC']
suburbs.to_sql('suburbs', con=engine, if_exists='append', chunksize=1000)