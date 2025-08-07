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
            Console.WriteLine("-------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(file.ToString());
        }

        public static void Salvar(String file)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("aDeseja salvar o arquivo? (s/n)");
            var res = Console.ReadKey(true).Key;

            if (res == ConsoleKey.S)
            {
                Console.WriteLine("Digite o caminho ou o nome do arquivo");
                var path = Console.ReadLine();

                using (var fileStream = new StreamWriter(path))
                {
                    fileStream.Write(file);
                }

                Console.Clear();
                Console.WriteLine($"Arquivo {path} salvo com sucesso!");
                Thread.Sleep(2000);
                Viewer.Show(file.ToString());
            }
            else if (res == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine("Arquivo descartado! Pressione uma tecla para voltar ao menu");
                Console.ReadKey(true);
                Menu.Show();
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                Salvar(file);
            }

        }
    }
}