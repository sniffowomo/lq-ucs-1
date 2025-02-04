#!/usr/bin/bash
# Bash Script for getting chains
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

cast_chainz() {
    # Getting the chain id using the cast command

    header "Getting Chain ID with cast"

    ALC_S="https://eth-sepolia.g.alchemy.com/v2/YfG5-esHajH3FpsLvC4eMFMEFYl9Lqcg"
    ALC_H="https://eth-holesky.g.alchemy.com/v2/YfG5-esHajH3FpsLvC4eMFMEFYl9Lqcg"
    CO1=""

}

bun_addz() {
    header "Installing Packages with bun add"

    PKG="chalk ora alchemy-sdk dotenv"
    CO1="bun add ${PKG}"
    CO2="bun pm ls"

    echo -e ""
    echo -e "${YELLOW}Installing Packages...${NC}"
    echo -e "${YELLOW}chalk         - Color Output in terminal${NC}"
    echo -e "${YELLOW}ora           - Waiting Animation${NC}"
    echo -e "${YELLOW}alchemy-sdk   - Using Alchemy${NC}"
    echo -e "${YELLOW}dotenv        - Read Dot Env Files${NC}"
    echo -e ""

    echo -e "Installing ${PKG}..."
    eval "$CO1"
    echo -e "Listing Packages..."
    eval "$CO2"
}

# Execution
bun_addz
