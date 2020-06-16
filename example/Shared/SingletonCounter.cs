using System;
namespace example.Shared
{
    public sealed class SingletonCounter
    {
        private static SingletonCounter _singleInstance = new SingletonCounter();

        public static SingletonCounter GetInstance()
        {
            return _singleInstance;
        }

        public int currentCount { get; set; }

        private SingletonCounter()
        {
            //initialization
            currentCount = 0;
        }
    }
}
