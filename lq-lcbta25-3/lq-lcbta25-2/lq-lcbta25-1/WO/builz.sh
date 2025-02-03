#!/usr/bin/bash
# This bash script is for installing the KL docker image here
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
    echo -e "Building single Exe File for Windows and Linux"
    echo -e "===============${NC}"
}

# Building for Windows
c1() {
    CO1="dotnet publish -c Release -r win-x64 --self-contained /p:PublishSingleFile=true /p:PublishTrimmed=true /p:TrimMode=link"
    echo -e ""
    echo -e "${PURPLE}[-] Building for Windows ${NC}"

    # Capture the output of the command
    output=$($CO1 2>&1)
    exit_status=$?

    if [ $exit_status -eq 0 ]; then
        echo -e "${GREEN}[+] Windows Build Finished ${NC}"
        echo -e "${GREEN}$output${NC}"
    else
        echo -e "${RED}[!] Windows Build Failed ${NC}"
        echo -e "${RED}$output${NC}"
        # Optionally, you can add more error handling or cleanup code here
    fi

    echo -e ""
}

# Building for Linux
c2() {
    CO1="dotnet publish -c Release -r linux-x64 --self-contained /p:PublishSingleFile=true /p:PublishTrimmed=true /p:TrimMode=link"
    echo -e ""
    echo -e "${PURPLE}[-] Building for linux-x64 ${NC}"

    # Capture the output of the command
    output=$($CO1 2>&1)
    exit_status=$?

    if [ $exit_status -eq 0 ]; then
        echo -e "${GREEN}[+] linux-x64 Build Finished ${NC}"
        echo -e "${GREEN}$output${NC}"
    else
        echo -e "${RED}[!] linux-x64 Build Failed ${NC}"
        echo -e "${RED}$output${NC}"
        # Optionally, you can add more error handling or cleanup code here
    fi

    echo -e ""
}

# Execution
b1
c1
c2
