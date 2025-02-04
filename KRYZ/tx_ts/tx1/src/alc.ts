// For doing the
// https://docs.alchemy.com/docs/how-to-send-transactions-on-ethereum

const { Alchemy, Network, Wallet, Utils } = require('alchemy-sdk')
const dotenv = require('dotenv')

dotenv.config()
const { ALK, WA1K } = process.env

const settings = {
  apiKey: ALK,
  network: Network.ETH_SEPOLIA,
}
const alchemy = new Alchemy(settings)

let wallet = new Wallet(WA1K)

async function main() {
  const nonce = await alchemy.core.getTransactionCount(wallet.address, 'latest')

  let transaction = {
    to: '0xa238b6008Bc2FBd9E386A5d4784511980cE504Cd',
    value: Utils.parseEther('0.001'),
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

main()
