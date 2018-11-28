using System;
namespace DesignPattern.IteratorPattern
{
    public class NameRepository : Container
    {
        internal string[] Names = { "Robert", "John", "Julie", "Lora" };

        public NameRepository()
        {
        }

        public Iterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : Iterator
        {
            NameRepository nameRepository = new NameRepository();

            int index;

            public bool HasNext()
            {
                if (index < nameRepository.Names.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public object Next()
            {
                if (this.HasNext())
                {
                    return nameRepository.Names[index++];
                }
                return null;
            }
        }
    }
}
