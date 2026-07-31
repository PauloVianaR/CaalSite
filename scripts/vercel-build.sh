#!/usr/bin/env bash
set -euo pipefail

readonly DOTNET_DIR="${PWD}/.dotnet"

export DOTNET_ROOT="${DOTNET_DIR}"
export PATH="${DOTNET_DIR}:${PATH}"
export DOTNET_CLI_TELEMETRY_OPTOUT=1
export DOTNET_NOLOGO=1

dotnet publish CaalSite.csproj \
    --configuration Release \
    --output dist \
    --no-restore
