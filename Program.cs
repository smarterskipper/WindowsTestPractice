using System;
using GlobalVars;
namespace WindowsTestPractice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Your Favorite Number...");
            Console.WriteLine($"Your Favorite Number is {UserInput.ReadInputLine()}");
            Console.Clear();
            
            
            // attempt download wav
            try
            {
                DLSound.DownloadWav();
                Console.WriteLine("DownloadWav Passed...");
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Failed at DownloadWav Method");
                Console.WriteLine(e.Message);
            }
            
            // attempt convert mp3 to wav
            try
            {
                ConvertToWav.ConvertMp3ToWav("nyan.mp3","nyan.wav");
                Console.WriteLine("ConvertMp3ToWav Passed...");
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Failed at ConvertToWav Method");
                Console.WriteLine(e.Message);
            }
            
            // attempt to play wav
            try
            {
                SoundTime.PlayGoof();
                Console.WriteLine("PlayGoof Passed...");
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Failed at PlayGoof Method");
                Console.WriteLine(e.Message);
            }
            
            // attempt to start create file loop
            try
            {
                MakeDatFile.CreateDatFile();
                Console.WriteLine("CreateDatFile Passed...");
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Failed at CreateDatFile Method");
                Console.WriteLine(e.Message);
            }
        }
    }
}