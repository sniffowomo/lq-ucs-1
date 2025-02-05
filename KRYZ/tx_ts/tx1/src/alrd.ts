// Using alchemy to read the tx

import { Alchemy, Network, Wallet, Utils, fromHex } from 'alchemy-sdk'
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

  try {
    const receipt = await alchemy.core.getTransactionReceipt(txHash)
    console.log(receipt)
  } catch (error) {
    console.error('Error fetching transaction receipt:', error)
  }
}

export async function getTxHistory() {
  // Configure Alchemy SDK with API key and network
  const config = {
    apiKey: ALK,
    network: Network.MANTLE_MAINNET,
  }
  const alchemy = new Alchemy(config)

  // Address to fetch transactions from (replace with your own)
  const fromAddress = WA2

  try {
    // Get all transactions for an address from block 0 and store in txns
    const txns = await alchemy.core.getAssetTransfers({
      fromBlock: '0x0',
      fromAddress: fromAddress,
      category: ['external', 'internal', 'erc20', 'erc721', 'erc1155'],
    })

    console.log(txns)
  } catch (error) {
    console.error('Error fetching transaction history:', error)
  }
}
