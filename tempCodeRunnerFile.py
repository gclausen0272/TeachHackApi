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