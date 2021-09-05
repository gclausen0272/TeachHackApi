import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

# url = "https://localhost:5001/api/qrattend/PostTeacher?middleName=j&firstName=jen&lastname=jones&userName=jjones&password=password"
url = "https://localhost:5001/api/qrattend/PostAttendance?studentId=3&classId=1&date=today"
payload={}
headers = {}
response = requests.request("POST", url,verify = False, data=payload)
print(response.text)

import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

url = "https://qr-attend.herokuapp.com/api/qrattend/GetAttendanceByClassAndDate?classId=1&date=today"
payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)

import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

# url = "https://localhost:5001/api/qrattend/GetByUserNameAndPassword?userName=jjones&password=password"
url = "https://localhost:5001/api/qrattend/GetAllStudent"

payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)

# PostStudent middleName firstName lastName 

import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

url = "https://localhost:5001/api/qrattend/PostTeacher?middleName=K&firstName=Steph&lastname=Val&userName=Svalentinos&password=pizza"
# url = "https://localhost:5001/api/qrattend/PostStudent?middleName=Walice&firstName=Julia&lastName=Winter"
payload={}
headers = {}
response = requests.request("POST", url,verify = False, data=payload)
print(response.text)

url = "https://localhost:5001/api/qrattend/GetAllStudent"

payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)


import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

# url = "https://localhost:5001/api/qrattend/PostTeacher?middleName=j&firstName=jen&lastname=jones&userName=jjones&password=password"
url = "https://localhost:5001/api/qrattend/PostStudent?middleName=Walice&firstName=Julia&lastName=Winter"
payload={}
headers = {}
response = requests.request("POST", url,verify = False, data=payload)
print(response.text)

import requests 
        # public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  

# url = "https://localhost:5001/api/qrattend/PostTeacher?middleName=j&firstName=jen&lastname=jones&userName=jjones&password=password"
url = "https://localhost:5001/api/qrattend/PostTeacher?middleName=J&firstName=Sally&lastName=Smith&userName=SSmith&password=passwordtime"
payload={}
headers = {}
response = requests.request("POST", url,verify = False, data=payload)
print(response.text)

import requests 

url = "https://localhost:5001/api/qrattend/GetAllStudent"

payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)


import requests 
import names 
for i in range(10):
   fn = names.get_first_name()
   ln = names.get_last_name()
   mn = names.get_first_name()
   url = "https://localhost:5001/api/qrattend/PostStudent?middleName="+mn+"&firstName="+fn+"&lastName="+ln
   print(url)
   payload={}
   headers = {}
   response = requests.request("POST", url,verify = False, data=payload)
   print(response.text)
import requests 

for i in range(5):
        for j in range(20):
                classId = str(i+1)
                studentId = str(j+1)
                url = "https://localhost:5001/api/qrattend/AddStudentToRoster?classId="+classId+"&studentId="+studentId
                payload={}
                headers = {}
                response = requests.request("POST", url,verify = False, data=payload)
import requests 

url = "https://localhost:5001/api/qrattend/GetAllRoster"

payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)

import pyqrcode
import png
from pyqrcode import QRCode
  
  
# String which represents the QR code
for i in range(20):
        s = str(i+1)
        
        # Generate QR code
        url = pyqrcode.create(s)
        
        # # Create and save the svg file naming "myqr.svg"
        # url.svg("myqr.svg", scale = 8)
        
        # Create and save the png file naming "myqr.png"
        url.png('myqr'+ s+'.png', scale = 6)