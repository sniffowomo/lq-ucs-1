#!/usr/bin/bash
# Bash Script for running the actual commands
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

header() {
    echo -e "${CYAN}~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~${NC}"
    echo -e "${PURPLE}$1${NC}"
    echo -e "${CYAN}~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~${NC}"
}

run_comm() {
    header "Executing Command Normally"
    CO="bun run index.ts"
    echo -e "${GREEN}Running Command: ${CO} ${NC}"
    eval "$CO"
}

run_comm_strip_colors() {
    header "Executing Command with Stripped Colors appending to file txs/runcommand.txt"
    CO1="bun run index.ts"
    CO2="awk '{ gsub(/\x1b\[[0-9;]*[a-zA-Z]/, \"\"); print }'"
    CO3="tee -a txs/runcommand.txt"
    echo -e "${GREEN}Running Command: $CO1 | $CO2 | $CO3${NC}"

    # Execute the command and capture the output
    eval "$CO1" | eval "$CO2" | eval "$CO3"
}

# Execution
run_comm_strip_colors
