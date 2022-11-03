using System;
using System.Collections.Generic;
namespace cse210_tictac
{
    class Program{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        
        DisplayBoard(board);
        string currentPlayer = "x";
        int square = -1;


        do{
            Console.Write($" player {currentPlayer} choose a square(1-9): ");
            square = int.Parse(Console.ReadLine());
            if(1<=square && square<=9)
                {
                    PopulateBoard(board, square, currentPlayer);
                    DisplayBoard(board);
                    currentPlayer = GetNextPlayer(currentPlayer);
                }
        }while(!IsGameOver(board));
        
        Console.WriteLine($"Game Over");
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
    {       Console.WriteLine("");
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine("");
    }

    static List<string> PopulateBoard(List<string> board, int position, string player)
    {
            board[position-1] = player;

            return board;
    }

    static string GetNextPlayer(string currentPlayer)
    {
        string nextPlayer = "x";

        if(currentPlayer == "x")
        {
            nextPlayer = "o";
        }

        return nextPlayer;
    }

    static bool IsGameOver(List<string> board)
    {   
        bool gameOver= false;
        if(IsWinner(board, "x")||IsWinner(board,"o")||IsTie(board)){
            gameOver = true;
        }
        return gameOver;
    }

    static bool IsWinner(List<string> board, string player)
    {
        bool isWinner = false;

        if( board[0]==player&&board[1]==player&&board[2]==player||
            board[3]==player&&board[4]==player&&board[5]==player||
            board[6]==player&&board[7]==player&&board[8]==player||
            board[0]==player&&board[3]==player&&board[6]==player||
            board[1]==player&&board[4]==player&&board[7]==player||
            board[2]==player&&board[5]==player&&board[8]==player||
            board[0]==player&&board[4]==player&&board[8]==player||
            board[6]==player&&board[4]==player&&board[2]==player
            )
        {
            isWinner = true;
        }

        return isWinner;
    }

    static bool IsTie(List<string> board)
    {
        bool isTie = false;
        int spaceUsed = 0;
        for(int i=0; i<9; i++ ){
            if(board[i]=="x"||board[i]=="o"){
                spaceUsed = 1 + spaceUsed;
            }
        }
        if(spaceUsed==9){
            isTie =true;
        }
        return isTie;
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