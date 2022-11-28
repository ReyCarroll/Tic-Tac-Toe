using System;

namespace TicTacToe
{
    public class game
    {
    bool playing = true; 
    
    
    public game()
    {

      
    
    }
    
    public void main()
    {
        
        var board = new List<string> { "1", "2", "3","4", "5", "6", "7","8", "9"  };
        bool xtrun = true;
         
        while (playing)
        {
            DoOutputs(board);
            GetInputs(board,xtrun);
            DoUpdates(board);
            if (xtrun){
                xtrun = false;
            }
            else{
                xtrun = true;
            }
            
        }
    }
    public void  GetInputs(List<string> board,bool xturn)
    {
        if (xturn)
        {
            Console.Write("x's turn to choose a square (1-9): ");
            string square = Console.ReadLine();
            var i = int.Parse(square);
            board[i-1] = "x";
            
        }
        else
        {
            Console.Write("o's turn to choose a square (1-9): ");
            string square = Console.ReadLine();
            var i = int.Parse(square);
            board[i-1] = "o";
            
        }

    }

     public void   DoUpdates(List<string> board)
    {
        if  (board[0] == "o"  && board[1] == "o" && board[2] == "o" ||
            board[3] == "o"  && board[4] == "o" && board[5] == "o" ||
            board[6] == "o"  && board[7] == "o" && board[8] == "o" ||

            board[0] == "o"  && board[3] == "o" && board[6] == "o" ||
            board[1] == "o"  && board[4] == "o" && board[7] == "o" ||
            board[2] == "o"  && board[5] == "o" && board[8] == "o" ||

            board[0] == "o"  && board[4] == "o" && board[8] == "o" ||
            board[6] == "o"  && board[4] == "o" && board[2] == "o")
        {
            Console.WriteLine("o wins");
            playing = false;
        }
        
        if  (board[0] == "x"  && board[1] == "x" && board[2] == "x" ||
            board[3] == "x"  && board[4] == "x" && board[5] == "x" ||
            board[6] == "x"  && board[7] == "x" && board[8] == "x" ||

            board[0] == "x"  && board[3] == "x" && board[6] == "x" ||
            board[1] == "x"  && board[4] == "x" && board[7] == "x" ||
            board[2] == "x"  && board[5] == "x" && board[8] == "x" ||

            board[0] == "x"  && board[4] == "x" && board[8] == "x" ||
            board[6] == "x"  && board[4] == "x" && board[2] == "x")
        {
            Console.WriteLine("x wins");
            playing = false;
        }
    }

     public void  DoOutputs(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}\n-+-+-\n{board[3]}|{board[4]}|{board[5]}\n-+-+-\n{board[6]}|{board[7]}|{board[8]}");
    }




       
    }
    
}