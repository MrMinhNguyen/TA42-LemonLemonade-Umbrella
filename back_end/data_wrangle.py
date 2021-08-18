import mysql.connector

mysql_connection = mysql.connector.connect(
  host="localhost",
  user="lemon",
  password="lemonade"
)

mysql_cursor = mysql_connection.cursor()
mysql_cursor.execute("CREATE DATABASE lemon_lemonade")
print("CREATE DATABASE lemon_lemonade") 

db_connection = mysql.connector.connect(
  host="localhost",
  user="lemon",
  password="lemonade",
  database="lemon_lemonade"
)

db_cursor = db_connection.cursor()
# db_cursor.execute("CREATE TABLE sunglasses (sunglasses_id INT AUTO_INCREMENT PRIMARY KEY, len_type VARCHAR(255), description VARCHAR(255))")



