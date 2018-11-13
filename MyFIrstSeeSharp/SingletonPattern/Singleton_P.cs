namespace MyFIrstSeeSharp.SingletonPattern
{
    class Singleton_P
    {
        private class UsedInternally
        {
            public UsedInternally()
            {
                System.Console.WriteLine("private class constructor");
            }

            public uint addStuff(uint a, uint b)
            {
                return (a + b);
            }
        }
        private Singleton_P()
        {
            System.Console.WriteLine("private constructor called!!!");
        }

        private uint a = 200, b = 1, c;
        private UsedInternally takeItOut = new UsedInternally();
        private static Singleton_P m_instance;
        public int giveSomeMaths()
        {
            c = takeItOut.addStuff(a, b);
            return (int)c;
        }
        public static Singleton_P GiveInstance()
        {
            if (m_instance == null)
            {
                m_instance = new Singleton_P();
            }
            return m_instance;
        }

    }
}
