# PDF-installer

![image](https://media.discordapp.net/attachments/984138155491995650/1108485357076500650/image.png)

## Description
PDF-installer is a command-line program written in C# that allows you to install and uninstall PDF files for later use. It provides a simple way to manage and launch installed PDF files.

## Features
- Install a specified PDF file
- Uninstall a previously installed PDF file
- Launch installed PDF files using the provided command

## Usage

Install a specified PDF file.
```pdf install <file_path>```

Uninstall a previously installed PDF file.
```pdf uninstall <filename>```

Display help for the command.
```pdf --help```

## Note

To launch an installed PDF file, use the "pdf" prefix followed by the file name. For example, if you have installed a PDF file named "my_file.pdf", you can launch it using the command "pdf_my_file".

## Requirements

- .NET Framework

## License
This project is licensed under the [MIT License](LICENSE).

Feel free to contribute and suggest improvements!
