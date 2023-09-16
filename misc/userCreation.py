import requests
import json

# API endpoint for user creation
URL = "http://localhost:5097/api/createusers"

# User data to be sent to the API
user_data = {
    "Name": "IDIDIT",
    "Email": "ididit@mail.com",
    "Password": "12345678"
}

headers = {'Content-type': 'application/json'}

# Sending the post request to the API
# response = requests.post(url=URL, data=user_data)
response = requests.post(url=URL, json=user_data, headers=headers)

# Cheching the response
if response.status_code == 201:
    print("User created successfully")
    print("Server Response: ", json.dumps(response.json(), indent=4))
elif response.status_code == 400:
    print("Bad request")
    print("Server Response: ", json.dumps(response.json(), indent=4))
else:
    print("Something went wrong")
    print("Server Response: ", json.dumps(response.json(), indent=4))
