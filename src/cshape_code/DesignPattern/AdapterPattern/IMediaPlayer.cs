using System;
namespace DesignPattern.AdapterPattern
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
