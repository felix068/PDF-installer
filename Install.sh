#!/bin/bash

if which wget >/dev/null 2>&1; then
    sudo wget -P "/usr/bin/" "https://raw.githubusercontent.com/felix068/PDF-installer/main/bin/Release/net7.0/linux-x64/publish/pdf"
    sudo chmod +x "/usr/bin/pdf"
elif which curl >/dev/null 2>&1; then
    sudo curl -o "/usr/bin/pdf" "https://raw.githubusercontent.com/felix068/PDF-installer/main/bin/Release/net7.0/linux-x64/publish/pdf"
    sudo chmod +x "/usr/bin/pdf"
else
    echo "Error: Neither wget nor curl is installed on this system."
    exit 1
fi
