using System;
using System.Net;
using System.Threading;

namespace GlobalVars
{
    public class DLSound
    {
        public static void DownloadWav()
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://www.nyan.cat/music/original.mp3"),
                        // Param2 = Path to save
                        "nyan.mp3"
                    );
                    Thread.Sleep(20000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                finally
                {
                    wc.Dispose();
                    Console.WriteLine("Download process Disposed!");
                }
                
            }
        }
    }
}