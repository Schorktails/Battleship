using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        public static void Main()
        {
            Board board = new Board(10, 10);

            try
            {
                Target path = new Target(
                    new[] {
                        new BoardLocation(0, 2, board),
                        new BoardLocation(1, 2, board),
                        new BoardLocation(2, 2, board),
                        new BoardLocation(3, 2, board),
                        new BoardLocation(4, 2, board),
                        new BoardLocation(5, 2, board),
                        new BoardLocation(6, 2, board),
                        new BoardLocation(7, 2, board),
                        new BoardLocation(8, 2, board),
                        new BoardLocation(9, 2, board),
                    }
                );
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BattleshipException)
            {
                Console.WriteLine("Unhandled BattleshipException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception: ");
            }
        }
    }
}
}
