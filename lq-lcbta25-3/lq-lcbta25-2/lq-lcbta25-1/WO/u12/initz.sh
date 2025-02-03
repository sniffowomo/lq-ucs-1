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
    echo -e "Setting up a new dotnet project with .net 8.0"
    echo -e "===============${NC}"
}

c1() {
    # Starting a new project
    echo -e "${GREEN}[-] Enter name of project ${NC}"
    echo -e "${GREEN}[-] Command Execute - dot new console -n <NewName> ${NC}"
    echo -e "${PURPLE}[*] Enter name of project: ${NC}"
    read -r projekt

    CO1="dotnet new console -n $projekt"
    CO2="eza -T $projekt"

    echo -e "${GREEN}[+] $projekt Created - DrinkHerPiss${NC}"

    # Execute the first command and capture the output and exit status
    output1=$($CO1 2>&1)
    exit_status1=$?

    if [ $exit_status1 -eq 0 ]; then
        echo -e "${GREEN}[+] Project $projekt created successfully ${NC}"
        echo -e "${GREEN}$output1${NC}"
    else
        echo -e "${RED}[!] Failed to create project $projekt ${NC}"
        echo -e "${RED}$output1${NC}"
        return 1
    fi

    # Execute the second command and capture the output and exit status
    output2=$($CO2 2>&1)
    exit_status2=$?

    if [ $exit_status2 -eq 0 ]; then
        echo -e "${GREEN}[+] eza command executed successfully ${NC}"
        echo -e "${GREEN}$output2${NC}"
    else
        echo -e "${RED}[!] Failed to execute eza command ${NC}"
        echo -e "${RED}$output2${NC}"
        return 1
    fi
}

c2() {
    # Addding a new project to an existing solution
    echo -e "${GREEN}[-] Enter name of project to add to exisitng soliution${NC}"
    echo -e "${GREEN}[-] Command Execute - dotnet new classlib -n <project_name> ${NC}"
    echo -e "${PURPLE}[*] Enter name of project: ${NC}"
    read -r project_name

    CO1="dotnet new classlib -n $project_name"
    CO2="eza -T $project_name"

    echo -e "${GREEN}[+] $projekt Created - DrinkHerPiss${NC}"

    # Execute the first command and capture the output and exit status
    output1=$($CO1 2>&1)
    exit_status1=$?

    if [ $exit_status1 -eq 0 ]; then
        echo -e "${GREEN}[+] Project $project_name created successfully ${NC}"
        echo -e "${GREEN}$output1${NC}"
    else
        echo -e "${RED}[!] Failed to create project $project_name ${NC}"
        echo -e "${RED}$output1${NC}"
        return 1
    fi

    # Execute the second command and capture the output and exit status
    output2=$($CO2 2>&1)
    exit_status2=$?

    if [ $exit_status2 -eq 0 ]; then
        echo -e "${GREEN}[+] eza command executed successfully ${NC}"
        echo -e "${GREEN}$output2${NC}"
    else
        echo -e "${RED}[!] Failed to execute eza command ${NC}"
        echo -e "${RED}$output2${NC}"
        return 1
    fi
}

# Execution
b1
c2
