// File is for writing functiont that make colorful headers

import chalkAnimation from 'chalk-animation'
import chalk from 'chalk'

export function header(text: string): void {
  const border = '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  const styledBorder = chalk.bold.greenBright(border)
  const styledText = chalk.bold.greenBright(text)

  console.log(
    `
${styledBorder}
${styledText}
${styledBorder}
`.trim()
  )
}

export function clearScreen(): void {
  // Clear the screen with an animation
  const animation = chalkAnimation.karaoke('Clearing screen...')

  // Start the animation
  animation.start()

  // Wait for the animation to run for a bit before clearing the screen
  setTimeout(() => {
    // Stop the animation
    animation.stop()

    // Clear the screen
    process.stdout.write('\x1bc')
  }, 3000) // Increase the timeout to 3 seconds to see the animation better
}
