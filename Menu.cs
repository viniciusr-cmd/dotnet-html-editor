using System;

namespace HTMLEditor {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(){
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|                              |");
            Console.WriteLine("|          HTML Editor         |");
            Console.WriteLine("|                              |");
            Console.WriteLine("+------------------------------+");
        }

        public static void WriteOptions(){
            Console.WriteLine("1 - New File \n");
            Console.WriteLine("2 - Open File \n");
            Console.WriteLine("3 - Exit \n");
            Console.WriteLine("Type the number of the option and press enter \n");
        }

        public static void HandleMenuOption(short option){
            switch(option){
                case 1: Console.WriteLine("New File"); Editor.Show(); break;
                case 2: Console.WriteLine("Open File"); Viewer.Show(""); break;
                case 3: {
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}