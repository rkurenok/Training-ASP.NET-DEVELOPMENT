using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static string directoryPath = @"D:\Универ\6 семестр\Тренинг\HW10\goncharov_ivan-obyknovennaja_istorija.txt";
        static string path = @"D:\Универ\6 семестр\Тренинг\HW10\pack.txt";
        static string path2 = @"D:\Универ\6 семестр\Тренинг\HW10\unpack.txt";

        public static void Main()
        {

            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            Compress(directorySelected);

            FileInfo fileToDecompress = new FileInfo(path2);
            Decompress(fileToDecompress);

            Console.ReadKey();
        }

        public static void Compress(DirectoryInfo directorySelected)
        {
            FileInfo filee = new FileInfo(directoryPath);
            FileInfo file = new FileInfo(path);

            using (FileStream originalFileStream = filee.OpenRead())
            {
                {
                    using (FileStream compressedFileStream = File.Create(file.FullName))
                    {
                        using (DeflateStream compressionStream = new DeflateStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);
                            Console.WriteLine("Compressed: {0}", file.Name);
                        }
                    }
                }
            }
        }

        public static void Decompress(FileInfo fileToDecompress)
        {
            FileInfo file = new FileInfo(path);

            using (FileStream originalFileStream = file.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName + ".txt";
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (DeflateStream decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
        }
    }
}
