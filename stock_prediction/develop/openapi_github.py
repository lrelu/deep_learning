import requests
from PIL import Image
from io import BytesIO


uri = 'https://api.github.com/events'

# read json data using requests lib
r = requests.get(uri)


# get, post, put, delete, head, options using requests
# r = requests.post('https://httpbin.org/post', data = {'key':'value'})
# >>> r = requests.put('https://httpbin.org/put', data = {'key':'value'})
# >>> r = requests.delete('https://httpbin.org/delete')
# >>> r = requests.head('https://httpbin.org/get')
# >>> r = requests.options('https://httpbin.org/get')

print(r.url)
print(r.text)
print(r.content)

# i = Image.open(BytesIO(r.content))

print(r.raise_for_status())
print(r.status_code)

if r.status_code == 200:
	print(r.json())

# read as stream
# r = requests.get(uri, stream=True)
print(r.raw)
print(r.raw.read(10))

# read using custom header
url = 'https://api.github.com/some/endpoint'
headers = {'user-agent': 'my-app/0.0.1'}

r = requests.get(url, headers=headers)
print(r.text)


# request as post
payload = {'key1': 'value1', 'key2': 'value2'}

r = requests.post("https://httpbin.org/post", data=payload)
print(r.text)