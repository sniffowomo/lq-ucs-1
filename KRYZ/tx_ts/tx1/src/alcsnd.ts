// For doing the
// https://docs.alchemy.com/docs/how-to-send-transactions-on-ethereum

import { Alchemy, Network, Wallet, Utils } from 'alchemy-sdk'
import dotenv from 'dotenv'
import chalk from 'chalk'

dotenv.config()
const { ALK, WA1K, WA2 } = process.env

if (!WA1K) {
  throw new Error('WA1K is not defined')
}
let wallet = new Wallet(WA1K)

const sendval = '0.000000000000000069'

export async function send_sepolia() {
  const settings = {
    apiKey: ALK,
    network: Network.ETH_SEPOLIA,
  }
  const alchemy = new Alchemy(settings)

  const nonce = await alchemy.core.getTransactionCount(wallet.address, 'latest')

  let transaction = {
    to: WA2,
    value: Utils.parseUnits(sendval),
    gasLimit: '21000',
    maxPriorityFeePerGas: Utils.parseUnits('5', 'gwei'),
    maxFeePerGas: Utils.parseUnits('20', 'gwei'),
    nonce: nonce,
    type: 2,
    chainId: 11155111,
  }

  let rawTransaction = await wallet.signTransaction(transaction)
  let tx = await alchemy.core.sendTransaction(rawTransaction)
  console.log('Sent transaction', tx)
}

export async function send_holeksy() {
  const settings = {
    apiKey: ALK,
    network: Network.ETH_HOLESKY,
  }
  const alchemy = new Alchemy(settings)

  const nonce = await alchemy.core.getTransactionCount(wallet.address, 'latest')

  let transaction = {
    to: WA2,
    value: Utils.parseUnits(sendval),
    gasLimit: '21000',
    maxPriorityFeePerGas: Utils.parseUnits('5', 'gwei'),
    maxFeePerGas: Utils.parseUnits('20', 'gwei'),
    nonce: nonce,
    type: 2,
    chainId: 17000,
  }

  let rawTransaction = await wallet.signTransaction(transaction)
  let tx = await alchemy.core.sendTransaction(rawTransaction)
  console.log('Sent transaction', tx)
}

// Sending a private transaction
export async function sendSepoliaPrivate() {
  const settings = {
    apiKey: ALK,
    network: Network.ETH_SEPOLIA, // Replace with your network.
  }
  const alchemy = new Alchemy(settings)

  const nonce = await alchemy.core.getTransactionCount(wallet.address, 'latest')

  let exampleTx = {
    to: WA2,
    value: Utils.parseUnits(sendval),
    gasLimit: '21000',
    maxFeePerGas: Utils.parseUnits('20', 'gwei'),
    nonce: nonce,
    type: 2,
    chainId: 11155111,
  }

  let rawTransaction = await wallet.signTransaction(exampleTx)

  const signedTx = await alchemy.transact.sendPrivateTransaction(
    rawTransaction,
    (await alchemy.core.getBlockNumber()) + 1
  )

  console.log(chalk.bold.magenta('Sent private transaction', signedTx))
}

export async function sendHoleksyPrivate() {
  const settings = {
    apiKey: ALK,
    network: Network.ETH_HOLESKY, // Replace with your network.
  }
  const alchemy = new Alchemy(settings)

  const nonce = await alchemy.core.getTransactionCount(wallet.address, 'latest')

  let exampleTx = {
    to: WA2,
    value: Utils.parseUnits(sendval),
    gasLimit: '21000',
    maxFeePerGas: Utils.parseUnits('20', 'gwei'),
    nonce: nonce,
    type: 2,
    chainId: 17000,
  }

  let rawTransaction = await wallet.signTransaction(exampleTx)

  const signedTx = await alchemy.transact.sendPrivateTransaction(
    rawTransaction,
    (await alchemy.core.getBlockNumber()) + 1
  )

  console.log(chalk.bold.magenta('Sent private transaction', signedTx))
}
