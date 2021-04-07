using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new Singleton();
        public Guid id = Guid.NewGuid();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return Instance;
        }
    }
}
