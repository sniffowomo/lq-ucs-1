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
hea1() {
    echo -e "${CYAN}============================="
    echo -e "$1"
    echo -e "$2"
    echo -e "=============================${NC}"
}

b1() {
    hea1 "Nuget Pkg Installers - https://www.nuget.org/PACKAGES" "1. Pastel - https://www.nuget.org/packages/Pastel"
}

c1() {
    CO1="dotnet add package Pastel --version 6.0.1"
    CO2="dotnet list package"
    echo -e "${GREEN}Executing Command: ${NC}${CO1}"
    eval "$CO1"
    eval "$CO2"
}

# Execution
b1
c1
