using System;
using System.IO;
using System.Diagnostics;

namespace pdf
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool valid = false;
            if (args.Length == 0 || args[0] == "--help")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"This program allows you to install and uninstall PDF files for later use.

Usage:
  pdf install <file_path>     Install a specified PDF file.
  pdf uninstall <filename>   Uninstall a previously installed PDF file.

Options:
  --help                          Display help for this command.

Note:
  To launch an installed PDF file, use the ""pdf"" prefix followed by the file name.
  For example, if you have installed a PDF file named ""my_file.pdf"", you can launch it using the command ""pdf_my_file"". You can also launch the pdf through your application launcher if you select Y when asked to make a shortcut in your application launcher. 

Examples:
  pdf install /path/to/file.pdf    Install the specified PDF file.
  pdf uninstall file              Uninstall the PDF file named ""file"".");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                valid = true;
            }
            if (args.Length != 0 && args[0] == "install")
            {
                string path = args[1];
                string name = Path.GetFileNameWithoutExtension(path);
                if (Path.GetExtension(path) == ".pdf")
                {
                    if (!Directory.Exists("/usr/bin/dir-pdf"))
                    { Directory.CreateDirectory("/usr/bin/dir-pdf/"); }
                    File.Copy(path, @"/usr/bin/dir-pdf/" + "pdf_" + name);
                    using (StreamWriter sw = new StreamWriter("/usr/bin/pdf_" + name))
                    {
                        sw.WriteLine("xdg-open " + "/usr/bin/dir-pdf/pdf_" + name + " &");
                    }
                    Process p = new Process();
                    p.StartInfo.FileName = "chmod";
                    p.StartInfo.Arguments = "+x " + "/usr/bin/pdf_" + name;
                    p.StartInfo.UseShellExecute = false;
                    p.Start();

                    bool shortcut = false;
                    string key;
                    while (!shortcut)
                    {
                        Console.Write("\nDo you want to put the pdf in your start menu? [Y/N] ");
                        key = Console.ReadLine();

                        if (key == "Y")
                        {
                            shortcut = true;
                           using (StreamWriter sw = new StreamWriter("/usr/share/applications/pdf_" + name))
                            {
                                sw.WriteLine(@"[Desktop Entry]

                Type=Application

                Version=1.0

                Name=" + name + @"

                Path=/usr/bin

                Exec=pdf_" + name + @"

                Terminal=false");
                            }
                        }
                        else if (key == "N")
                        {
                            break; // Quit the loop if "N" is entered
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The pdf file has been successfully installed !");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is not a valid pdf file.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                }
                valid = true;
            }
            if (args.Length != 0 && args[0] == "uninstall")
            {
                string name = args[1];
                File.Delete("/usr/bin/pdf_" + name);
                File.Delete("/usr/bin/dir-pdf/pdf_" + name);
                File.Delete("/usr/share/applications/" + name);
                valid = true;
            }
            if (!valid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"The command is not valid.
Run ""pdf --help"" for more information on a command.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
            }

            // Code à exécuter après le choix Y/N
            // ...
        }
    }
}
