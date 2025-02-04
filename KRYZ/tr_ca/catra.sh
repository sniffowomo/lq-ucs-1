#!/usr/bin/bash
# This bash srcript is for making cast accounts
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
    echo -e "${CYAN}~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~${NC}"
    echo -e "${PURPLE}$1${NC}"
    echo -e "${CYAN}~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~${NC}"
}

# Balance Checker
ca_wa_ba() {
    hea1 "Balance Checker"

    WA1="0xA158b0C3B87e4bCd4870Dc3c9A8199cfa1E8Fc8f"
    WA2="0x1eFfd0829A1891Fd87056521e12D7A1bA6152D73"
    SEP_RPC="https://rpc.ankr.com/eth_sepolia"
    HOL_RPC="https://rpc.ankr.com/eth_holesky"

    CO1S="cast b -e ${WA1} -r ${SEP_RPC}"
    CO1H="cast b -e ${WA1} -r ${HOL_RPC}"
    CO2S="cast b -e ${WA2} -r ${SEP_RPC}"
    CO2H="cast b -e ${WA2} -r ${HOL_RPC}"

    w1_output_sepolia=$(eval "$CO1S")
    if [ $? -ne 0 ]; then
        echo -e "${RED}${WA1}Sepolia balance check failed${NC}"
        exit 1
    fi

    w1_output_holesky=$(eval "$CO1H")
    if [ $? -ne 0 ]; then
        echo -e "${RED}${WA1} - olesky balance check failed${NC}"
        exit 1
    fi

    w2_output_sepolia=$(eval "$CO2S")
    if [ $? -ne 0 ]; then
        echo -e "${RED}${WA2}Sepolia balance check failed${NC}"
        exit 1
    fi

    w2_output_holesky=$(eval "$CO2H")
    if [ $? -ne 0 ]; then
        echo -e "${RED}${WA2}Holesky balance check failed${NC}"
        exit 1
    fi

    echo -e "${GREEN}${WA1}-Sepolia Balance: $w1_output_sepolia${NC}"
    echo -e "${GREEN}${WA1}-Holesky Balance: $w1_output_holesky${NC}"
    echo -e "-------------------------------------------------------"
    echo -e "${GREEN}${WA2}-Sepolia Balance: $w2_output_sepolia${NC}"
    echo -e "${GREEN}${WA2}-Holesky Balance: $w2_output_holesky${NC}"

    echo -e "${GREEN}Balance Check Completed${NC}"
}

# CaTrans
ca_trx() {
    hea1 "Transaction with cast/"

    #ALCRPC
    ALCRPCSEP="https://eth-sepolia.g.alchemy.com/v2/YfG5-esHajH3FpsLvC4eMFMEFYl9Lqcg"
    ALCRPCHOL="https://eth-holesky.g.alchemy.com/v2/YfG5-esHajH3FpsLvC4eMFMEFYl9Lqcg"

    # Walletz
    VALS="1wei"
    WA1="0xA158b0C3B87e4bCd4870Dc3c9A8199cfa1E8Fc8f"
    WA1K="0x4a0ac9ea62aa19e41bac0cb732380fb82e878cf07b21be1990f9ab46c4ec77ef"
    WA2="0x1eFfd0829A1891Fd87056521e12D7A1bA6152D73"

    # Transactions
    CO1_SEP="cast send ${WA2} --value ${VALS} --rpc-url ${ALCRPCSEP} --private-key ${WA1K}"
    CO1_HOL="cast send ${WA2} --value ${VALS} --rpc-url ${ALCRPCHOL} --private-key ${WA1K}"

    # Sending the transaction

    # Sending the transaction to Sepolia
    echo -e "${YELLOW}Sending Transaction to Sepolia${NC}"
    eval "$CO1_SEP"
    EXIT_CODE=$?
    if [ "$EXIT_CODE" -ne 0 ]; then
        echo -e "${RED}Transaction to Sepolia failed${NC}"
        exit 1
    fi

    # Sending the transaction to Holesky
    echo -e "${YELLOW}Sending Transaction to Holesky${NC}"
    eval "$CO1_HOL"
    EXIT_CODE=$?
    if [ "$EXIT_CODE" -ne 0 ]; then
        echo -e "${RED}Transaction to Holesky failed${NC}"
        exit 1
    fi

}

# Execution
ca_trx
ca_wa_ba
