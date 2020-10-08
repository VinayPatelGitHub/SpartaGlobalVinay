using System;
using System.IO;
using System.Diagnostics;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path1 = Directory.GetCurrentDirectory();
            //string path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\Lyrics\"));


            //string lyrics = File.ReadAllText($@"{path2}Wonderwall.txt");
            //Console.WriteLine(lyrics);


            //File.WriteAllText($@"{path2}ChamagneSupernova.txt", "In a champagne supernova in the sky");
            //string[] lyrics2 = { "so", "Sally", "can", "Wait" };
            //File.WriteAllLines($@"{path2}Dont look Back in Anger.txt", lyrics2);
            //string[] dlbin = File.ReadAllLines($@"{path2}Dont look Back in Anger.txt");
            //foreach (var item in dlbin)
            //{
            //    Console.WriteLine(item);
            //}


            //if (!File.Exists($@"{path2}myLyrics.txt"))
            //{
            //    string[] createText = { "hello", "I'm", "Nish" };
            //    File.WriteAllLines($@"{path2}myLyrics.txt", createText);
            //}
            //string[] readText = File.ReadAllLines($@"{path2}myLyrics.txt");
            //foreach (string s in readText)
            //{
            //    Console.WriteLine(s);
            //}


            //string appendText = "And i'm Happy";
            //File.AppendAllText($@"{path2}myLyrics.txt", appendText);


            //string oldlyrics = $@"{path2}myLyrics.txt";
            //string newlyrics = $@"{path2}newLyrics.txt";
            //File.Copy(oldlyrics, newlyrics, false);  //false means don't overwrite


            //string oldlyrics = $@"{path2}myLyrics.txt";
            //File.Delete(oldlyrics);


            //DateTime lastWriteTime = File.GetLastWriteTime($@"{path2}newLyrics.txt");
            //DateTime creationTime = File.GetCreationTime($@"{path2}newLyrics.txt");
            //Console.WriteLine(lastWriteTime);
            //Console.WriteLine(creationTime);

            //var fileinfo = new FileInfo($@"{path2}newLyrics.txt");
            //Console.WriteLine(fileinfo.Directory);
            //Console.WriteLine(fileinfo.Extension);


            //////folders
            //Directory.Delete($@"{path2}", true);
            //var fileArray = Directory.GetFiles(path2);
            //foreach (string i in fileArray)
            //{
            //    Console.WriteLine(i);
            //}

            /////Logging
            //Console.WriteLine($"THis is being loggest at {DateTime.Now}");

            //int total = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    console.writeline(i);
            //    total += i;
            //    debug.writeline($"debug - the value of i is {i}");
            //    trace.writeline($"trace - the value of i is {i}");
            //    file.writealltext("logfile.txt", $"log to text - the value of i is {i} at {datetime.now}");
            //}

            //////conditional compliling code:

//            Console.WriteLine("Starting app");
//#if DEBUG
//            Console.WriteLine("This is debug code");
//#endif

//#if Test
//            Console.WriteLine("This is a test");
//#endif
//            Console.WriteLine("Finishing app");





        }
    }
}
