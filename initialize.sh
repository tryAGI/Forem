dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Forem \
  ForemClient \
  https://developers.forem.com/redocusaurus/plugin-redoc-1.yaml \
  tryAGI \
  --output .
