using System;
namespace DesignPattern.ProxyPattern
{
    public class RealImage : Image
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(string loadFile)
        {
            Console.WriteLine("Loading " + loadFile);
        }
    }
}
