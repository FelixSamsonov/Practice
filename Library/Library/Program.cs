namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.MainScreen();
            string inputFunc = Console.ReadLine();
            Buttons buttons = new Buttons();
            buttons.ButtonАFunctionality(inputFunc);

        }
    }
}
