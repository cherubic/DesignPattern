using System;
namespace DesignPattern.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Play vlc file name: " + fileName);
        }
    }
}
