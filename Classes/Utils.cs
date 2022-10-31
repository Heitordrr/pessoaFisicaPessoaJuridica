namespace Backend {
    public static class Utils {
        public static void BarraCarregamento(string texto) {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write($"{texto}");
        for (int i = 0; i <= 7; i++)
        {
         Console.Write($" .");
            Thread.Sleep(500);
        }
        Console.ResetColor();
        Console.Clear();
        
        }
    }
}