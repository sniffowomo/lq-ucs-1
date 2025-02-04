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
