// Main entry point

import { header } from './src/uti'
import { send_sepolia, send_holeksy } from './src/alc'

async function main() {
  header('Send Sepolia')
  await send_sepolia()

  header('Send Holeksy')
  await send_holeksy()
}

// Calling the function
main()
