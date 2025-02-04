// File is for writing functiont that make colorful headers

import chalk from 'chalk'
import ora, { Ora } from 'ora'

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

export function showSpinner(text: string): ora.Ora {
  return ora(text).start()
}

export function updateSpinner(spinner: ora.Ora, text: string): void {
  spinner.text = text
}

export function succeedSpinner(spinner: ora.Ora, text: string): void {
  spinner.succeed(text)
}

export function failSpinner(spinner: ora.Ora, text: string): void {
  spinner.fail(text)
}

export function warnSpinner(spinner: ora.Ora, text: string): void {
  spinner.warn(text)
}

export function infoSpinner(spinner: ora.Ora, text: string): void {
  spinner.info(text)
}

export function stopSpinner(spinner: ora.Ora): void {
  spinner.stop()
}
