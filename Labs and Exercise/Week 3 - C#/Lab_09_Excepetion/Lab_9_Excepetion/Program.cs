using System;
using System.Data;
using System.IO;

namespace Lab_9_Excepetion
{
    class Program
    {
        private static string[] _theBeatles = new string[] { "john", "pual", "george", "Ringo" };
        static void Main(string[] args)
        {
            AddBeatles(4, "brain");

            try
            {
                File.OpenRead("tryEx.txt");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("couldn't find directory");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("counldn't find file");
            }
            catch (IOException e)
            {
                Console.WriteLine("problem witing to file");
            }
            finally 
            {
                Console.WriteLine("i am here");
            }
        }

        public static void AddBeatles(int pos, string name)
        {
            try
            {
                _theBeatles[pos] = name;
            }
            catch (Exception e)
            {
                Console.WriteLine("asdad");
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("life goes on");
            }
            
        }


        public static void AddBeatles2(int pos, string name)
        {
            if (pos < 0 || pos >= _theBeatles.Length) 
            {
                throw new ArgumentException($"the beas no pos {pos}");
            }
            _theBeatles[pos] = name;

        }
    }
}
