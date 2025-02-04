// File is for writing functiont that make colorful headers

import chalk from 'chalk';

export function header(text: string): void {
  console.log(chalk.bold.greenBright(text));
}