using System.Media;
namespace GlobalVars
{
    public class SoundTime
    {
        static SoundPlayer player = new SoundPlayer(@"nyan.wav");

        public static void PlayGoof()
        {
            player.PlayLooping();
        }
    }
}