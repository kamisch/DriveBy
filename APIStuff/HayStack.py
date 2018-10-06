import requests

r = requests.post(
  "https://api.haystack.ai/api/test1.jpg/analyze?output=json&apikey=3401986c5465b90cfdb5021ff1d0f27e",
  data=open('testImage.jpg', 'rb'))
print(r.text);
