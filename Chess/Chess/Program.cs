using System;
using System.Data;
using System.Threading;
namespace Arrays 
{ 
    public class Program 
    { 
        static void Main(string[] args) 
        { 
            const int row = 8, col = 8; 
            char[,] board = new char[row, col]; 
            while (true) 
            { 
                createChess(board, row, col); 
                printChess(board, row, col); 
                Console.WriteLine("Enter shape [P,T,H,O,Q,K]"); 
                char shape = char.Parse(Console.ReadLine()); 
                Console.WriteLine("Enter cordX:"); 
                int cordX = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Enter cordY:"); 
                int cordY = int.Parse(Console.ReadLine()); 
                switch (shape) 
                { 
                    case 'P': Pawn(board, row, col, cordX, cordY); break; 
                    case 'T': Tura(board, row, col, cordX, cordY); break;
                    case 'H': Horse(board, row, col, cordX, cordY); break;
                    case 'O': Officer(board, row, col, cordX, cordY); break;
                    case 'Q': Queen(board, row, col, cordX, cordY); break;
                    case 'K': King(board, row, col, cordX, cordY); break;
                    default: Console.WriteLine("Error shape!"); break; 
                } 
                printChess(board, row, col); 
                Console.ReadLine(); 
                Console.Clear(); 
            } 
        } 
        static void createChess(char[,] board, int row, int col) 
        { 
            for (int i = 0; i < row; i++) 
            { 
                for (int j = 0; j < col; j++) 
                {
                    if ((i + j) % 2 == 0) 
                    { 
                        board[i, j] = ' '; // white
                    }                    
                    else 
                    {                        
                        board[i, j] = '#'; // black
                    }                
                }            
            }        
        }        
        static void printChess(char[,] board, int row, int col)        
        {            
            for (int i = 0; i < row; i++)            
            {                
                for (int j = 0; j < col; j++)                
                {                    
                    Console.Write(board[i, j]);                
                }                
                Console.WriteLine();            
            }        
        }        
        static void Pawn(char[,] board, int row, int col, int cordX, int cordY)        
        {            
            board[cordX, cordY] = 'P';            
            if (cordX == col - 1)            
            {                
                board[cordX - 1, cordY] = 'X';            
            }            
            else if (cordY == 0)            
            {                
                board[cordX + 1, cordY] = 'X';            
            }            
            else 
            {                
                board[cordX - 1, cordY] = 'X';                
                board[cordX + 1, cordY] = 'X';            
            }        
        }        
        static void Tura(char[,] board, int row, int col, int cordX, int cordY)        
        {            
            for (int i = 0; i < row; i++)            
            {                
                for (int j = 0; j < col; j++)                
                {                    
                    if (i == cordX || j == cordY)                        
                        board[i, j] = 'X';                
                }            
            }            
            board[cordX, cordY] = 'T';        
        }
        static void Horse(char[,] board, int row, int col, int cordX, int cordY)
        {
            board[cordX, cordY] = 'H';

            int[] offsetX = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] offsetY = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for (int i = 0; i < 8; i++)
            {
                int newRow = cordX + offsetX[i];
                int newCol = cordY + offsetY[i];

                if (newRow >= 0 && newRow < row && newCol >= 0 && newCol < col && board[newRow, newCol] != 'X')
                {
                    board[newRow, newCol] = 'X';
                }
            }
        }
        static void Officer(char[,] board, int row, int col, int cordX, int cordY)
        {
            board[cordX, cordY] = 'O';
            for (int i = 1; cordX + i < row && cordY + i < col; i++)
            {
                board[cordX + i, cordY + i] = 'X';
            }
            for (int i = 1; cordX - i >= 0 && cordY + i < col; i++)
            {
                board[cordX - i, cordY + i] = 'X';
            }
            for (int i = 1; cordX + i < row && cordY - i >= 0; i++)
            {
                board[cordX + i, cordY - i] = 'X';
            }
            for (int i = 1; cordX - i >= 0 && cordY - i >= 0; i++)
            {
                board[cordX - i, cordY - i] = 'X';
            }
        }
        static void Queen(char[,] board, int row, int col, int cordX, int cordY)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == cordX || j == cordY || Math.Abs(i - cordX) == Math.Abs(j - cordY))
                    {
                        if (i == cordX && j == cordY)
                            continue;

                        board[i, j] = 'X';
                    }
                }
            }
            board[cordX, cordY] = 'Q';
        }
        static void King(char[,] board, int row, int col, int cordX, int cordY)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = cordX + i;
                    int newCol = cordY + j;

                    if (newRow >= 0 && newRow < row && newCol >= 0 && newCol < col && board[newRow, newCol] != 'X')
                    {
                        board[newRow, newCol] = 'X';
                    }
                }
            }
            board[cordX, cordY] = 'K';
        }
    }
}