// File is for writing functiont that make colorful headers

import chalk from 'chalk'
import ora from 'ora'

export function header(text: string): void {
  const border = '\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  const styledBorder = chalk.bold.greenBright(border)
  const styledText = chalk.bold.greenBright(text)

  console.log(
    `
${styledBorder}
${styledText}
`.trim()
  )
}
