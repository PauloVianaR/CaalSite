#!/usr/bin/env bash
set -euo pipefail

readonly DOTNET_VERSION="10.0.302"
readonly DOTNET_DIR="${PWD}/.dotnet"
readonly INSTALL_SCRIPT="/tmp/dotnet-install.sh"

if [[ ! -x "${DOTNET_DIR}/dotnet" ]]; then
    mkdir -p "${DOTNET_DIR}"
    curl --fail --silent --show-error --location \
        https://dot.net/v1/dotnet-install.sh \
        --output "${INSTALL_SCRIPT}"
    bash "${INSTALL_SCRIPT}" \
        --version "${DOTNET_VERSION}" \
        --install-dir "${DOTNET_DIR}" \
        --no-path
fi

export DOTNET_ROOT="${DOTNET_DIR}"
export PATH="${DOTNET_DIR}:${PATH}"
export DOTNET_CLI_TELEMETRY_OPTOUT=1
export DOTNET_NOLOGO=1

dotnet restore CaalSite.csproj
