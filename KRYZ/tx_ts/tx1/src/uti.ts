// File is for writing functiont that make colorful headers

import chalk from 'chalk'
import ora from 'ora'

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

export function showSpinnerWithStates(): void {
  const spinner = ora('Loading...').start()

  setTimeout(() => {
    spinner.text = 'Processing...'
  }, 1000)

  setTimeout(() => {
    spinner.succeed('Operation completed!')
  }, 3000)

  setTimeout(() => {
    spinner.fail('Operation failed!')
  }, 5000)

  setTimeout(() => {
    spinner.warn('Operation warning!')
  }, 7000)

  setTimeout(() => {
    spinner.info('Operation info!')
  }, 9000)

  setTimeout(() => {
    spinner.stop()
  }, 11000)
}
