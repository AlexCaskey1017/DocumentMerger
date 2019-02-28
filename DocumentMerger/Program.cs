using System;
using System.IO;
using System.Text;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document Merger");
            String fileName1 = "";
            String fileName2 = "";

            bool file1Validation = false;
            while (file1Validation == false)
            {
                Console.Write("What is the name of your first text file? ");
                fileName1 = Console.ReadLine();

                if (File.Exists(fileName1))
                {
                    Console.WriteLine("File Exists");
                    file1Validation = true;
                }
                else
                {
                    Console.WriteLine("Sorry that file doesnt exist, Please try again.");
                    file1Validation = false;
                }

            }

            bool file2Validation = false;
            while (file2Validation == false)
            {
                Console.WriteLine("What is the name of your second text file? ");
                fileName2 = Console.ReadLine();

                if (File.Exists(fileName2))
                {
                    Console.WriteLine("File Exists");
                    file2Validation = true;
                }
                else
                {
                    Console.WriteLine("Sorry that file doesnt exist, Please try again.");
                    file2Validation = false;
                }
            }

            bool file3Validation = false;
            while (file3Validation == false)
            { 
                FileStream file1 = File.OpenRead(fileName1);
                FileStream file2 = File.OpenRead(fileName2);


                string text1;
                //var fileReader1 = new FileStream("alex1.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader1 = new StreamReader(file1, Encoding.UTF8))
                {
                    text1 = streamReader1.ReadToEnd();
                }

                string text2;
                //var fileReader2 = new FileStream("alex2.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader2 = new StreamReader(file2, Encoding.UTF8))
                {
                    text2 = streamReader2.ReadToEnd();
                }

                Console.Write(text1 + text2);

                string alex1 = "My name is Alex";
                string alex2 = "and I am a student at the\nUniversity of Missouri Columbia ";
                string alex3 = alex1 + alex2;

                var myFile = File.Create(alex3);

                string[] fileName3 = { alex3 };
                File.WriteAllLines(@"Documents:\C# Projects\DocumentMergerSolution\DocumentMerger\Alex1Alex2", fileName3);

                if (File.Exists(alex3))
                {
                    Console.WriteLine("\nNew file created");
                        file3Validation = true;
                }
                else
                {
                    Console.WriteLine("The merge was not successful");
                    file3Validation = false;
                }
            }
        }
    }
}
