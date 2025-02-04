// File is for writing functiont that make colorful headers

import chalkAnimation from 'chalk-animation'
import chalk-animation from 'chalk-animation'
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

// Clear the screen with an animation
const animation = chalkAnimation.karaoke('Clearing screen...')

setTimeout(() => {
  // Stop the animation
  animation.stop()

  // Clear the screen
  process.stdout.write('\033c')
}, 1000)
