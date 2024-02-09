using System.Text;

namespace HTMLEditor {
    public static class Editor {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("EDITOR MODE (ESC TO EXIT)");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start(){
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Viewer.Show(file.ToString());
        }
    }
}