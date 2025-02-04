#!/usr/bin/bash
# Bash Script for installing ts packages
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

bun_addz() {
    header "Installing Packages with bun add"

    PKG="chalk "
    CO1="bun add ${PKG}"
    CO2="bun pm ls"

    echo -e "Installing ${PKG}..."
    eval "$CO1"
    echo -e "Listing Packages..."
    eval "$CO2"
}

# Execution
bun_addz
