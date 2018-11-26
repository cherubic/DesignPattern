using System;
namespace DesignPattern.AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public Mp4Player()
        {
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Mp4 play file: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
