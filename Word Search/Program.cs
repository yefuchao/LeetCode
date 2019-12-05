using System;

namespace Word_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //char[][] board = new char[3][];


            //board[0] = new char[] { 'A', 'B', 'C', 'E' };
            //board[1] = new char[] { 'S', 'F', 'C', 'S' };
            //board[2] = new char[] { 'A', 'D', 'E', 'E' };

            Char[][] b = new char[1][];
            b[0] = new char[] { 'a' };

            Console.WriteLine(Exist(b, "a"));

            Console.ReadKey();
        }

        static int g_x;
        static int g_y;
        static char[] findword;

        public static bool Exist(char[][] board, string word)
        {
            g_y = board.Length;
            g_x = g_y > 0 ? board[0].Length : 0;
            findword = word.ToCharArray();


            for (int i = 0; i < g_y; i++)
            {

                for (int j = 0; j < g_x; j++)
                {
                    if (Find(board, word, j, i, 0))
                    {
                        return true;
                    }
                }

                if (g_x == 0)
                {
                    if (Find(board, word, g_x, i, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public static bool Find(char[][] board, string word, int x, int y, int findIndex)
        {
            //将判断统一放到开始
            //TODO 优化 时间效率


            char tar = findword[findIndex];

            if (board[y][x] == tar)
            {
                findIndex++;
                if (findIndex == findword.Length)
                {
                    return true;
                }

                board[y][x] = '0';

                //向上找
                if (y > 0 && board[y - 1][x] != '0')
                {
                    if (Find(board, word, x, y - 1, findIndex))
                    {
                        return true;
                    }
                }

                //左
                if (x > 0 && board[y][x - 1] != '0')
                {
                    if (Find(board, word, x - 1, y, findIndex))
                    {
                        return true;
                    }
                }

                //右
                if (x + 1 < g_x && board[y][x + 1] != '0')
                {
                    if (Find(board, word, x + 1, y, findIndex))
                    {
                        return true;
                    }
                }

                //下
                if (y + 1 < g_y && board[y + 1][x] != '0')
                {
                    if (Find(board, word, x, y + 1, findIndex))
                    {
                        return true;
                    }
                }

                //退回
                board[y][x] = tar;
                findIndex--;
            }

            return false;
        }


    }
}
