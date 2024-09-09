namespace HelloDungeon
{
    internal class Program
    {
        public static bool playerIsDead = false;
        static void Main(string[] args)
        {
            while (Program.playerIsDead == false)
            {
                Game game = new Game();
                game.Run();
            }
            
        }
    }
}
//Maybe use the program end error as something? idk it would be cool
//C:\Users\s248007\Desktop\HelloDungeon\HelloDungeon\bin\Debug\net8.0\HelloDungeon.exe (process 15348) exited with code 0.
//To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
//Press any key to close this window . . .