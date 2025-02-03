#!/usr/bin/bash
# This bash srcript is for installing the KL docker image here
clear

# Colors
export RED='\033[0;31m'
export GREEN='\033[0;32m'
export YELLOW='\033[0;33m'
export BLUE='\033[0;34m'
export PURPLE='\033[0;35m'
export CYAN='\033[0;36m'
export WHITE='\033[0;37m'
export NC='\033[0m' # No Color

# Commands
b1() {
    echo -e "${CYAN} =============== "
    echo -e "Building single Exe Fil for windows and linux"
    echo -e "===============${NC}"
}

# Buildin for Windows
c1() {
    CO1="dotnet publish -c Release -r win-x64 --self-contained /p:PublishSingleFile=true /p:PublishTrimmed=true /p:TrimMode=link"
    echo -e ""
    echo -e "${PURPLE}[-] Building for Windows ${NC}"
    $CO1
    echo -e "${GREEN}[+] Windows Build Finished ${NC}"
    echo -e ""
}

# Building for linux
c2() {
    CO2="dotnet publish -c Release -r linux-x64 --self-contained /p:PublishSingleFile=true /p:PublishTrimmed=true /p:TrimMode=link"
    echo -e ""
    echo -e "${PURPLE}[-] Building for LINUX ${NC}"
    $CO2
    echo -e "${GREEN}[+] Linux Build Finished ${NC}"
    echo -e ""
}

# Execution
b1
c2
