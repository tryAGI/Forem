#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://developers.forem.com/redocusaurus/plugin-redoc-1.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://developers.forem.com/redocusaurus/plugin-redoc-1.yaml
autosdk generate openapi.yaml \
  --namespace Forem \
  --clientClassName ForemClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
