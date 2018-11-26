using System;
namespace DesignPattern.AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }
}
