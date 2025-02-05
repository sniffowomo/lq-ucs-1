// Using alchemy to read the tx

import { Alchemy, Network, Wallet, Utils } from 'alchemy-sdk'
import dotenv from 'dotenv'
import chalk from 'chalk'

export async function getTxRcpt() {
  const settings = {
    apiKey: '<-- ALCHEMY API KEY -->', // Replace with your Alchemy API Key.
    network: Network.ETH_MAINNET, // Replace with your network.
  }
  const alchemy = new Alchemy(settings)

  alchemy.core
    .getTransactionReceipt(
      '0x68ea69fd8b5dfa589a7a983c324ab153a33356320207885a9bba84425598dcaa' // Transaction hash of the transaction for which you want to get information.
    )
    .then(console.log)
}
