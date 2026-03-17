set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://developers.forem.com/redocusaurus/plugin-redoc-1.yaml
autosdk generate openapi.yaml \
  --namespace Forem \
  --clientClassName ForemClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
