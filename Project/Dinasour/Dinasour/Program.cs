using System;
using System.IO;
using EZInput;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dinasour
{
    internal class Program
    {
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		static Random rnd = new Random();
		static int X = 12;
		static int Y = 14;
		static bool energizer = false;
		static bool updown = false;
		static int countjump = 0;
		static int countdown = 0;
		static int count_hurdle = 0;
		static int score = 0;
		static bool dist = false;
		static int int_distance;
		static int speed = 40;
		static char[,] maze=new char[20,94];
		static void load_maze()
        {
			string str;
			StreamReader var = new StreamReader("maze.txt");
            for (int i = 0;!var.EndOfStream; i++)
            {
				str=var.ReadLine();
                for (int x = 0; x < str.Length; x++)
                {
					maze[i, x] = str[x];
                }
            }
			var.Close();

        }
		static void display()
		{
			for (int x = 0; x < 20; x++)
			{
				for (int m = 0; m < 94; m++)
				{
					Console.Write(maze[x, m]);
				}
				Console.Write("\n");
			}
		}
		static int hurdles_size()
		{
			int result = 3 + rnd.Next(3);
			return result;
		}
		static void gameover()
		{
			Console.Clear();
			Console.Write("Your score : ");
			Console.Write(score);
			Console.Write("\n");
			clearscreen();
			Environment.Exit(0);
		}
		static void clearscreen()
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
		static void moveup()
		{
			if (maze[X - 1, Y] == '#')
			{
				countjump = 0;
				updown = false;
			}
			if (maze[X - 1, Y] == ' ')
			{
				Console.SetCursorPosition(Y, X - 1);
				Console.Write('P');
				maze[X - 1, Y] = 'P';
				Console.SetCursorPosition(Y, X);
				Console.Write(' ');
				maze[X, Y] = ' ';
				X--;
			}
		}
		static void movedown()
		{
			if (maze[X + 1, Y] == ' ')
			{
				Console.SetCursorPosition(Y, X + 1);
				Console.Write('P');
				maze[X + 1, Y] = 'P';
				Console.SetCursorPosition(Y, X);
				Console.Write(' ');
				maze[X, Y] = ' ';
				X++;
			}
		}
		static void checkGame()
		{
			if (maze[X, Y] == '$')
			{
				gameover();
			}
		}
		static int distance_hurdles()
		{
			int result = 20 + rnd.Next(15);
			return result;
		}
		static void create_hurdles()
		{
			if (!dist)
			{
				int_distance = distance_hurdles();
				dist = true;
			}
			if (dist)
			{
				count_hurdle++;
				if (count_hurdle == int_distance)
				{
					int size = hurdles_size();
					for (int x = 19; x > 19 - size + 1; x--)
					{
						maze[x, 89] = '$';
						Console.SetCursorPosition(89, x);
						Console.Write('$');
					}
					for (int x = 19; x > 19 - size; x--)
					{
						maze[x, 90] = '$';
						Console.SetCursorPosition(90, x);
						Console.Write('$');
					}
					for (int x = 19; x > 19 - size + 1; x--)
					{
						maze[x, 91] = '$';
						Console.SetCursorPosition(91, x);
						Console.Write('$');
					}
					count_hurdle = 0;
					dist = false;
				}
			}
		}
		static void move_hurdles()
		{
			for (int x = 0; x < 19; x++)
			{
				for (int m = 0; m < 93; m++)
				{
					if (maze[x, m] == '$')
					{
						if (maze[x, 12] == '$')
						{
							score++;
						}
						maze[x, m] = ' ';
						Console.SetCursorPosition(m, x);
						Console.Write(' ');
						if (m != 1)
						{
							maze[x, m - 1] = '$';
							Console.SetCursorPosition(m - 1, x);
							Console.Write('$');
						}
					}
				}
			}
		}
		static void score_f()
		{
			Console.SetCursorPosition(79, 3);
			Console.Write("Score : ");
			Console.Write(score);
			score++;
			if (score > 500)
			{
				speed = 30;
			}
			if (score > 1000)
			{
				speed = 20;
			}
			if (score > 1500)
			{
				speed = 10;
			}
			if (score > 2000)
			{
				speed = 5;
			}
			if (score > 2500)
			{
				speed = 3;
			}
		}
		static void Main()
		{
			load_maze();
			display();
			while (true)
			{
				Thread.Sleep(speed);
				create_hurdles();
				move_hurdles();
				score_f();
				if (maze[X + 1, Y] == '#')
				{
					if (Keyboard.IsKeyPressed(Key.Space))
					{
						updown = true;
					}
				}
				if (updown)
				{
					countjump++;
					if (countjump <= 5)
					{
						moveup();
					}
					else if (countjump == 6)
					{
						updown = false;
					}
				}
				if (updown == false)
				{
					if (maze[X + 1, Y] != '#')
					{
                        if (countdown % 2 == 0)
                        {
                            countjump = 0;
                            movedown();
                        }
                        countdown--;
                    }
				}
				checkGame();
				if (Keyboard.IsKeyPressed(Key.Escape))
				{
					break;
				}
			}
		}
	}

};
