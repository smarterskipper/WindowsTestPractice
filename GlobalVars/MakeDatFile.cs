using System;
using System.IO;
using System.Threading;


namespace GlobalVars
{
    public class MakeDatFile
    {
        public static void CreateDatFile()
        {
            Random random = new Random();
            
            int x = 1;
            while (true)
            {
                int randomNumber = random.Next(100, 2000);
                x++;
                string y = Convert.ToString(x);
                File.Create($"nyan.txt{y}");
                Thread.Sleep(randomNumber);
            }
        }
    }
}