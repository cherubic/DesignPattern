using System;
namespace DesignPattern.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        public AudioPlayer()
        {
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine("mp3 file:" + fileName);
            }
            else if (audioType.ToLower() == "mp4" || audioType.ToLower() == "vlc")
            {
                MediaAdapter mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("this format not support");
            }
        }
    }
}
