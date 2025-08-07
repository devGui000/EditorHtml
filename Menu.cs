namespace EditorHtml;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }
    public static void DrawScreen()
    {
        Line(30);
        Column(10, 30);
        Line(30);
    }
    static void Line(int tamanho)
    {
        Console.Write("+");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }
    static void Column(int altura, int espaco)
    {
        for (int i = 0; i < altura; i++)
        {

            Console.Write("|");
            for (int j = 0; j < espaco; j++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }
    }
    public static void WriteOptions()
    {
        Console.SetCursorPosition(10, 1);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(9, 2);
        Console.WriteLine("=============");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(2, 8);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(2, 9);
        Console.Write("Opção: ");
    }
    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Viewer.Abrir(); break;
            case 0:
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar meu Programa!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }

}