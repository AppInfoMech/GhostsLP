using System;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This is where the game will start to run.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Board board = new Board();
            Renderer renderer = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();
            GameLoop gameLoop = new GameLoop();
            MainMenu mainMenu = new MainMenu();

            //loop to inicialize the ghosts
            gameLoop.GameSetup(board, renderer, player1, player2);
            //gameplay loop
            gameLoop.Gamestart(board, renderer, player1, player2);

            //drawing the board
            renderer.Render(board,gameLoop.Gameloop);

            Console.ReadKey();
        }
    }
}
