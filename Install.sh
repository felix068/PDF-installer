#!/bin/bash

if command -v wget &> /dev/null; then
    sudo wget -P "/usr/bin/" "https://raw.githubusercontent.com/felix068/PDF-installer/main/bin/Release/net7.0/linux-x64/publish/pdf"
    sudo chmod +x "/usr/bin/pdf"
elif command -v curl &> /dev/null; then
    sudo curl -o "/usr/bin/pdf" "https://raw.githubusercontent.com/felix068/PDF-installer/main/bin/Release/net7.0/linux-x64/publish/pdf"
    sudo chmod +x "/usr/bin/pdf"
else
    echo "Error: Neither wget nor curl is installed on this system."
    exit 1
fi
