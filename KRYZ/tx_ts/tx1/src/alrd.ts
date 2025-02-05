// Using alchemy to read the tx

import { Alchemy, Network, Wallet, Utils } from 'alchemy-sdk'
import dotenv from 'dotenv'
import chalk from 'chalk'

dotenv.config()
const { ALK, WA1K, WA2 } = process.env

export async function getTxRcpt() {
  const settings = {
    apiKey: ALK, // Replace with your Alchemy API Key.
    network: Network.ETH_SEPOLIA, // Replace with your network.
  }
  const alchemy = new Alchemy(settings)
  const txHash =
    '0x4cc90797974e32222b5f393028ea6b412e1798336d0e05831c1f03fb18c0f9c4'

  alchemy.core
    .getTransactionReceipt(txHash)
    // Transaction hash of the transaction for which you want to get information.)
    .then(console.log)
}
