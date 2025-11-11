using NAudio.Wave;   
using System;
namespace GlobalVars
{
    public class ConvertToWav
    {
        public static void ConvertMp3ToWav(string _inPath_, string _outPath_)
        {
            using (Mp3FileReader mp3 = new Mp3FileReader(_inPath_))
            {
                using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    try
                    {
                        WaveFileWriter.CreateWaveFile(_outPath_, pcm);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Failed to create wave file");
                        Console.ReadLine();

                    }
                    finally
                    {
                        pcm.Dispose();
                        mp3.Dispose();
                    }
                }
            }
        }
    }
}