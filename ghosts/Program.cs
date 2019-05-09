using System;
using System.Text;

namespace ghosts
{
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

            gameLoop.GameSetup(board, renderer, player1, player2);
            gameLoop.Gamestart(board, renderer, player1, player2);


            renderer.Render(board,gameLoop.Gameloop);

            Console.ReadKey();
        }
    }
}
