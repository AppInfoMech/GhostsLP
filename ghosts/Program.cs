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
            WinChecker winChecker = new WinChecker();
            Renderer renderer = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();
            GameLoop gameLoop = new GameLoop();

            /*  while (!winChecker.IsDraw(board) && winChecker.Check(board) == State.Undecided)
              {
                  renderer.Render(board);

                  Positions nextMove;
                  if (board.NextTurn == State.X)
                      nextMove = player1.GetPosition(board);
                  else
                      nextMove = player2.GetPosition(board);

                  if (!board.SetState(nextMove, board.NextTurn))
                      Console.WriteLine("That is not a legal move.");
              }*/
            gameLoop.GameSetup(board, renderer, player1, player2);
            gameLoop.Gamestart(board, renderer, player1, player2);


            renderer.Render(board,gameLoop.Gameloop);
            renderer.RenderResults(winChecker.Check(board));

            Console.ReadKey();
        }
    }
}
