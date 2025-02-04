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
    CO1S="cast chain-id -r ${ALC_S}"
    CO1H="cast chain-id -r ${ALC_H}"

    echo -e "${GREEN}Getting Chain ID for Sepolia..."
    echo -e "${CO1S}"
    SEP_ID=$($COl1s)

    echo -e "${GREEN}Getting Chain ID for Holeksy..."
    echo -e "${CO1H}"
    HOL_ID=$($COl1H)

    echo -e "${YELLOW}Chain ID for Sepolia: ${SEP_ID}"
    echo -e "${YELLOW}Chain ID for Holeksy: ${HOL_ID}"

}

# Execution
bun_addz
