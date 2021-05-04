using System;

namespace MonoArkanoid
{
#if WINDOWS || LINUX

    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MonoArkanoid())
                game.Run();
        }
    }
#endif
}
