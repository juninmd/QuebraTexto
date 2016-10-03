using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuebraTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Local do Arquivo:");
            string baseName = Console.ReadLine();
            if (String.IsNullOrEmpty(baseName))
                return;

            Console.WriteLine("Quebrar a cada X Linhas:");
            var quebrarEmXLinhas = Console.ReadLine();
            if (String.IsNullOrEmpty(quebrarEmXLinhas))
                return;

            StreamWriter writer = null;
            try
            {
                using (StreamReader inputfile = new System.IO.StreamReader(baseName))
                {
                    int count = 0;
                    int countFiles = 0;
                    string line;
                    while ((line = inputfile.ReadLine()) != null)
                    {

                        if (writer == null || count > int.Parse(quebrarEmXLinhas))
                        {
                            ++countFiles;
                            count = 0;
                            if (writer != null)
                            {
                                writer.Close();
                                writer = null;
                            }

                            if (!Directory.Exists(Path.GetDirectoryName(baseName) + "\\out\\"))
                                Directory.CreateDirectory(Path.GetDirectoryName(baseName) + "\\out\\");

                            writer =
                                new System.IO.StreamWriter(Path.GetDirectoryName(baseName) + "\\out\\" +
                                    Path.GetFileNameWithoutExtension(baseName) + countFiles + Path.GetExtension(baseName),
                                    true);
                        }

                        writer.WriteLine(line.ToLower());

                        ++count;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

        }
    }
}
