import ora from 'ora'
import { header } from './src/uti'
import {
  send_sepolia,
  send_holeksy,
  sendSepoliaPrivate,
  sendHoleksyPrivate,
} from './src/alcsnd'
import { getTxRcpt, getTxHistory } from './src/alrd'

async function sendingtx() {
  // Spinner for sending to Sepolia
  const sepoliaSpinner = ora('Sending to Sepolia').start()
  try {
    header('Send Sepolia')
    await send_sepolia()
    sepoliaSpinner.succeed('Successfully sent to Sepolia')
  } catch (error) {
    sepoliaSpinner.fail('Failed to send to Sepolia')
    console.error('Error sending to Sepolia:', error)
  }

  // Spinner for sending to Holeksy
  const holeksySpinner = ora('Sending to Holeksy').start()
  try {
    header('Send Holeksy')
    await send_holeksy()
    holeksySpinner.succeed('Successfully sent to Holeksy')
  } catch (error) {
    holeksySpinner.fail('Failed to send to Holeksy')
    console.error('Error sending to Holeksy:', error)
  }
}

async function sendingPrivateTxs() {
  // Spinner for sending to Sepolia
  const sepoliaSpinner = ora('Sending to Sepolia').start()
  try {
    header('Send Sepolia Private')
    await sendSepoliaPrivate()
    sepoliaSpinner.succeed('Successfully sent to Sepolia')
  } catch (error) {
    sepoliaSpinner.fail('Failed to send to Sepolia')
    console.error('Error sending to Sepolia:', error)
  }

  // Spinner for sending to Holeksy
  const holeksySpinner = ora('Sending to Holeksy').start()
  try {
    header('Send Holeksy Private')
    await sendHoleksyPrivate()
    holeksySpinner.succeed('Successfully sent to Holeksy')
  } catch (error) {
    holeksySpinner.fail('Failed to send to Holeksy')
    console.error('Error sending to Holeksy:', error)
  }
}

async function getTxRcptFunc() {
  // Spinner for sending to Sepolia
  const sepoliaSpinner = ora('Getting Sepolia Tx').start()
  try {
    header('Get TX Receipt')
    await getTxRcpt()
    sepoliaSpinner.succeed('Acquired TX Receipt')
  } catch (error) {
    sepoliaSpinner.fail('Failed to get TX Receipt')
    console.error('Error sending to Sepolia:', error)
  }
}

async function getTxRcptHistory() {
  // Spinner for sending to Sepolia
  const sepoliaSpinner = ora('Getting Sepolia Tx').start()
  try {
    header('Get TX Receipt')
    await getTxHistory()
    sepoliaSpinner.succeed('Acquired TX Receipt')
  } catch (error) {
    sepoliaSpinner.fail('Failed to get TX Receipt')
    console.error('Error sending to Sepolia:', error)
  }
}

// Calling the function
getTxRcptHistory()
