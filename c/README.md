# C Coding Kata

## Setup

 * Visual Studio Code
   * Download here: https://code.visualstudio.com/
 * MinGW-w64
   * Download here: https://sourceforge.net/projects/mingw-w64/files/latest/download
   * Select the following options:
    * Architecture: `x86_64`
    * Threads: `posix`
    * Exception: `seh`
   * Add `gcc` path (`C:\Program Files\mingw-w64\x86_64-7.3.0-posix-seh-rt_v5-rev0\mingw64\bin`) to environment variable PATH
 * watchexec
   * Download here: https://github.com/mattgreen/watchexec/releases
   * Create a directory for the coding katas and place watchexec.exe in there.
 * Ruby (should already be installed)
   * Download here: https://rubyinstaller.org/
   * `gem install ceedling`

### Verification of setup
Test the following commands in a cmd or git bash
  * `ceedling` welcomes you
  * `watchexec.exe` shows error message about arguments
  * `gcc.exe` shows error about missing input files

## Create new project
  1. Go to the directory containing `watchexec.exe`
  1. `ceedling new <project-name>`
  1. `cd <project-name>`
  1. `ceedling module:create[<module-name>]`

## Run unit tests
  * Just once: `ceedling`
  * Everytime a file is saved: `../watchexec.exe -w src -w test ceedling`

## Run unit tests with VSCode
  * Copy tasks.json from 'env/' to 'project-folder/.vscode/'
  * In VSCode: Tasks -> Run Task -> Run unit tests