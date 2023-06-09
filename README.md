# PDF-installer (Just for Fun!)

![image](https://media.discordapp.net/attachments/984138155491995650/1108485357076500650/image.png)

## Description
PDF-installer is a command-line program written in C# that allows you to install and uninstall PDF files for later use.
But here's the catch—it's intentionally written with messy and inefficient code as a joke!

## Features
- Install a specified PDF file
- Uninstall a previously installed PDF file
- Launch installed PDF files using the provided command

## Usage (If You Dare)

Install a specified PDF file.
```pdf install <file_path>```

Uninstall a previously installed PDF file.
```pdf uninstall <filename>```

Display help for the command.
```pdf --help```

## Installation

To install the project using either wget or curl, follow the steps below:

**Copy and paste the following command if you have `curl` installed:**
```shell
sudo bash -c "$(curl -fsSL https://raw.githubusercontent.com/felix068/PDF-installer/main/Install.sh)"
```

**Alternatively, if you have `wget` installed, use the following command:**
```shell
sudo bash -c "bash <(wget -qO- https://raw.githubusercontent.com/felix068/PDF-installer/main/Install.sh)"
```
## Note

To launch an installed PDF file, use the "pdf_" prefix followed by the file name (with no file extention). Or just cross your fingers and hope it works. Good luck!

## Requirements (Your Patience)

- .NET Framework
- A sense of humor

## License (Do Not Sue)
This project is licensed under the [MIT License](LICENSE), but we take no responsibility for any confusion, frustration, or headache it may cause.
#

Feel free to contribute and suggest improvements... 
### Please do not optimize the code !
