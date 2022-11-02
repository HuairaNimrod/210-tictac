using System;
using System.Collections.Generic;
namespace cse210_tictac
{
    class Program{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        
        DisplayBoard(board);


        
    }
    static List<string> GetNewBoard()
    {

            List<string> board = new List<string>();

                for(int i=1; i<=9; i++)
                {
                    board.Add(i.ToString());
                }

        return board;
    }

    static void DisplayBoard(List<string> board)
    {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

    }

    }    
    
}

// class Car 
// {
//   string color = "red";

//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     Console.WriteLine(myObj.color);
//   }
// }