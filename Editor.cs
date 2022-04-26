using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            //so sai do while com escape na linha vazia!!!!!
            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo?");

            //licao de casa, armazenar s ou n

            Viewer.Show(file.ToString());
        }
    }

}
