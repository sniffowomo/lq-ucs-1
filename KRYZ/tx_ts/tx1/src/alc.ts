// For doing the
// https://docs.alchemy.com/docs/how-to-send-transactions-on-ethereum

const { Alchemy, Network, Wallet, Utils } = require('alchemy-sdk')
const dotenv = require('dotenv')

dotenv.config()
const { ALK, WA1K, WA2 } = process.env

const settings = {
  apiKey: ALK,
  network: Network.ETH_SEPOLIA,
}
const alchemy = new Alchemy(settings)
const sendval = '0.000000000000000001'

let wallet = new Wallet(WA1K)

async function send_sepolia() {
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
