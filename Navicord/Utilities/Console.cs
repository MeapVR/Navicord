using System;

namespace Navicord
{
    internal class ConsoleUtils
    {
        internal protected static void Log(object toprint, ConsoleColor color = ConsoleColor.White)
        {
            if (Shared.StartHidden)
                return;

            Console.ForegroundColor = color;
            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + toprint);
        }
    }
}
