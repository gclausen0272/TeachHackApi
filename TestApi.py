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

url = "https://localhost:5001/api/qrattend/GetAttendanceByClassAndDate?classId=1&date=today"
payload={}
headers = {}
response = requests.request("GET", url,verify = False, data=payload)
print(response.text)