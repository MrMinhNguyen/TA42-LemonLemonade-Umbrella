#!/usr/bin/env python
# coding: utf-8

# In[16]:


import pandas as pd

# read hat, sunglasses, sunscreen, umbrella_n_clothes dataset from local file

hat = pd.read_csv("hat.csv")
sunglasses = pd.read_csv("sunglasses.csv")
sunscreen = pd.read_csv("sunscreen.csv")
umbrella_n_clothes = pd.read_csv("umbrella_n_clothes.csv")


# In[17]:


# insert pandas dataframe to sql db using sqlalchemy module and to_sql() function
import pymysql
from sqlalchemy import create_engine

# create sqlalchemy engine
engine = create_engine("mysql+pymysql://{user}:{pw}@localhost/{db}"
                       .format(user="lemon",
                               pw="FIT5120lemonade",
                               db="lemon_lemonade"))

# Insert whole DataFrame into MySQL
hat.to_sql('hat_info', con = engine, if_exists = 'append', chunksize = 1000)
sunglasses.to_sql('sunglasses_info', con = engine, if_exists = 'append', chunksize = 1000)
sunscreen.to_sql('sunscreen_info', con = engine, if_exists = 'append', chunksize = 1000)
umbrella_n_clothes.to_sql('umbrella_clothes_info', con = engine, if_exists = 'append', chunksize = 1000)

