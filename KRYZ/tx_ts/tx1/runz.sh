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
    header "Executing Command with Stripped Colors"
    CO="bun run index.ts"
    echo -e "${GREEN}Running Command: ${CO} ${NC}"

# Execution
run_comm
