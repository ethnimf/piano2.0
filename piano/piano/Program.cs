using System;
using System.Collections.Generic;
using System.Threading;

namespace Piano
{
    class Program
    {
        static int[] currentOctave = new int[] { 261, 293, 329, 349, 392, 440, 493 };


        public static Dictionary<ConsoleKey, int> keyToNote = new Dictionary<ConsoleKey, int>()
            {
                { ConsoleKey.Q, currentOctave[0] },
                { ConsoleKey.W, currentOctave[1] },
                { ConsoleKey.E, currentOctave[2] },
                { ConsoleKey.R, currentOctave[3] },
                { ConsoleKey.T, currentOctave[4] },
                { ConsoleKey.Y, currentOctave[5] },
                { ConsoleKey.U, currentOctave[6] }
            };

        static void Main()
        {
            Console.WriteLine("Добро пожаловать в пианино!");
            Console.WriteLine("Нажмите клавиши на клавиатуре для игры на пианино. Для выхода нажмите Esc.");            

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Escape)
                        break;

                    if(keyInfo.Key == ConsoleKey.F1)
                    {
                        currentOctave = new int[] { 261, 293, 329, 349, 392, 440, 493 };
                        Console.WriteLine("Октава 1");
                    }
                    if(keyInfo.Key == ConsoleKey.F2)
                    {
                        currentOctave = new int[] { 523, 587, 659, 698, 784, 880, 987 };
                        Console.WriteLine("Октава 2");
                    }
                    if(keyInfo.Key == ConsoleKey.F3)
                    {
                        currentOctave = new int[] { 1046, 1174, 1318, 1396, 1568, 1760, 1975 };
                        Console.WriteLine("Октава 3");
                    }
                    if (keyToNote.ContainsKey(keyInfo.Key))
                    {
                        int frequency = keyToNote[keyInfo.Key];
                        Console.Clear();
                        Play(frequency);
                    }
                }
            }
        }

        static void Play(int frequency)
        {
            Console.Beep(frequency, 500);
        }
    }
}


