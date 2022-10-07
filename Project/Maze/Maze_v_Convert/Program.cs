using System;
using System.IO;
using EZInput;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Maze_v_Convert.BL;

namespace Maze_v_Convert
{
    class Program
    {
		static Player player = new Player();
		static Random rnd = new Random();
		static int score = 0;
		static int stars = 0;
		static bool running = true;
		static int highest_score = 0;
		static char pre = ' ';
		static char pre2 = ' ';
		static char pre3 = ' ';
		static char pre4 = ' ';
		static char pre5 = ' ';
		static bool ft = true;
		static bool st = false;
		static bool energizer = false;
		static int gx1 = 9;
		static int gy1 = 43;
		static int gx2 = 3;
		static int gy2 = 3;
		static int gx3 = 16;
		static int gy3 = 27;
		static int gx4 = 6;
		static int gy4 = 55;
		static int gx5 = 9;
		static int gy5 = 9;
		static int movecount = 0;
		static int movecount2 = 0;
		static int energycount = 0;
		static int lifes = 3;
		static int health = 100;
		static int fireX1 = 9;
		static int fireY1 = 10;
		static int fireX2 = 22;
		static int fireY2 = 22;
		static int fireX3 = 1;
		static int fireY3 = 44;
		static int firecount1 = 1;
		static int firecount2 = 0;
		static int firecount3 = 0;
		static bool restart1 = false;
		static bool restart2 = false;
		static bool restart3 = false;
		static List <int> scores = new List<int> ();
		static char[,] maze = new char[24, 93];
		static char[,] headerA = new char[10,93];
		static void load_maze()
		{
			string path = "game.txt";
			StreamReader var = new StreamReader(path);
            for (int i = 0; i < 24; i++)
            {
				string str=var.ReadLine();
                for (int m = 0; m < 92; m++)
                {
					maze[i, m] = str[m];
                }
            }
			var.Close();
		}
        static void load_header()
        {
            string path = "header.txt";
            StreamReader streamReader = new StreamReader(path);
            for(int x=0; !streamReader.EndOfStream;x++)
            {
                string str = streamReader.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {
					headerA[x,i]=str[i];
                }
            }
			streamReader.Close();
        }
        static void header()
		{
            Console.Clear();
			Console.ForegroundColor= ConsoleColor.Red;
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 93; x++)
                {
                    Console.Write(headerA[i,x]);
                }
                Console.WriteLine("");
            }
		}
		static void find_highest()
		{
			for (int x = 0; x < scores.Count; x++)
			{
				if (scores[x] > highest_score)
				{
					highest_score = scores[x];
				}
			}
		}
		static void main_menu()
		{
			header();
			Console.WriteLine("Welcome to the Game......");
			Console.WriteLine("1) Press 1 to play the game");
			Console.WriteLine("2) Press 2 to View Records ");
			Console.WriteLine("3) Press 3 for instructions");
			Console.WriteLine("4) Press 4 to exit");
		}
		static void instructions()
		{
			header();
			Console.WriteLine("Instructions >");
			Console.Write("\n");
			string path = "instruct.txt";
			StreamReader var = new StreamReader(path);
			while(!var.EndOfStream)
            {
                Console.WriteLine( var.ReadLine());
			}
			var.Close();
            Console.WriteLine("");
			clearScrean();
		}
		static void store_score_array()
		{
			scores.Add(score);
		}
		static void display()
		{
			for (int x = 0; x < 24; x++)
			{
				for (int m = 0; m < 93; m++)
				{
					if(maze[x,m]=='#')
                    {
						Console.ForegroundColor= ConsoleColor.Yellow;
						Console.BackgroundColor = ConsoleColor.Yellow;
					}
					else if (maze[x, m] == '[')
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.BackgroundColor = ConsoleColor.Green;
					}
					else if (maze[x, m] == ']')
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.BackgroundColor = ConsoleColor.DarkGreen;
					}
					else if (maze[x, m] == '@')
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.BackgroundColor = ConsoleColor.White;
					}
					Console.Write(maze[x, m]);
					Console.ResetColor();
				}
				Console.Write("\n");
			}
		}
		static void score1()
		{
			Console.SetCursorPosition(77, 10);
			Console.Write("Score:");
			Console.Write(score);
			Console.Write("  ");
		}
		static void checkpoint()
		{
			stars++;
			if (stars == 2)
			{
				maze[4, 41] = ' ';
				Console.SetCursorPosition(41, 4);
				Console.Write(' ');
				maze[4, 40] = ' ';
				Console.SetCursorPosition(40, 4);
				Console.Write(' ');
			}
			if (stars >= 3)
			{
				maze[0, 2] = ' ';
				maze[0, 3] = ' ';
				maze[0, 4] = ' ';
				Console.SetCursorPosition(2, 0);
				Console.Write(' ');
				Console.SetCursorPosition(3, 0);
				Console.Write(' ');
				Console.SetCursorPosition(4, 0);
				Console.Write(' ');
			}
		}
		static void game_end_score()
		{
			if (score < highest_score)
			{
				Console.Write("Highest Score is ");
				Console.Write(highest_score);
				Console.Write("\n");
				Console.Write("\n");
				Console.Write("Your Score is ");
				Console.Write(score);
				Console.Write("\n");
				Console.Write("Better luck Next time!!!!!!!!");
				Console.Write("\n");
			}
			else
			{
				Console.Write("You have created new High Score!!!!!!!");
				Console.Write("\n");
				Console.Write("\n");
				Console.Write("New High Score is ");
				Console.Write(score);
				Console.Write("\n");
				highest_score = score;
			}
			clearScrean();
		}
		static void game_esc()
		{
			running = false;
		}
		static void gameend()
		{
			maze[player.X, player.Y] = ' ';
			Console.SetCursorPosition(player.Y, player.X);
			Console.Write(' ');
			maze[gx1, gy1] = ' ';
			Console.SetCursorPosition(gy1, gx1);
			Console.Write(' ');
			maze[gx2, gy2] = ' ';
			Console.SetCursorPosition(gy2, gx2);
			Console.Write(' ');
			maze[gx3, gy3] = ' ';
			Console.SetCursorPosition(gy3, gx3);
			Console.Write(' ');
			maze[gx4, gy4] = ' ';
			Console.SetCursorPosition(gy4, gx4);
			Console.Write(' ');
			running = false;
			header();
		}
		static int ghostDirection1()
		{
			int result = 1 + rnd.Next(4);
			return result;
		}
		static int ghostDirection2()
		{
			int result = 1 + rnd.Next(2);
			return result;
		}
		static int ghostDirection3()
		{
			int result = 1 + rnd.Next(2);
			return result;
		}
		static int ghostDirection4()
		{
			if (movecount == 4)
			{
				int result = 1 + rnd.Next(4);
				movecount = 0;
				return result;
			}
			movecount++;
			int xaxis = player.X - gx4;
			int yaxis = player.Y - gy4;
			int absx = Math.Abs(xaxis);
			int absy = Math.Abs(yaxis);
			if (absx > absy)
			{
				if (xaxis < 0)
				{
					return 1;
				}
				else
				{
					return 2;
				}
			}
			else
			{
				if (yaxis < 0)
				{
					return 4;
				}
				else
				{
					return 3;
				}
			}
		}
		static int ghostDirection5()
		{
			if (movecount2 == 3)
			{
				int result = 1 + rnd.Next(4);
				movecount2 = 0;
				return result;
			}
			movecount2++;
			int xaxis = player.X - gx5;
			int yaxis = player.Y - gy5;
			int absx = Math.Abs(xaxis);
			int absy = Math.Abs(yaxis);
			if (absx > absy)
			{
				if (xaxis < 0)
				{
					return 1;
				}
				else
				{
					return 2;
				}
			}
			else
			{
				if (yaxis < 0)
				{
					return 4;
				}
				else
				{
					return 3;
				}
			}
		}
		static void gameover()
		{
			if (lifes == 1)
			{
				gameend();
				game_end_score();
				store_score_array();
			}
			else
			{
				maze[player.X, player.Y] = ' ';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				lifes--;
				player.X = 22;
				player.Y = 68;
				maze[player.X, player.Y] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write('P');
			}
		}
		static void healthover()
		{
			if (health == 25)
			{
				gameover();
			}
			else
			{
				health = health - 25;
			}
		}
		static void moveup()
		{
			if (maze[player.X - 1, player.Y] == '.')
			{
				score++;
			}
			if (maze[player.X - 1, player.Y] == '*')
			{
				score = score + 10;
				checkpoint();
			}
			if (energizer && (maze[player.X - 1, player.Y] == 'G' || maze[player.X - 1, player.Y] == '`'))
			{
				Console.SetCursorPosition(player.Y, player.X - 1);
				Console.Write('P');
				maze[player.X - 1, player.Y] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
			}
			if (!energizer && maze[player.X - 1,player. Y] == 'G')
			{
				gameover();
			}
			if (!energizer && maze[player.X - 1,player. Y] == '`')
			{
				healthover();
			}
			if (maze[player.X - 1,player. Y] == ' ' || maze[player.X - 1, player.Y] == '.' || maze[player.X - 1, player.Y] == 'O' || maze[player.X - 1, player.Y] == 'P' || maze[player.X - 1, player.Y] == '*')
			{
				if (maze[player.X - 1,player. Y] == 'O')
				{
					energizer = true;
					energycount = 0;
				}
				Console.SetCursorPosition(player.Y, player.X - 1);
				Console.Write('P');
				maze[player.X - 1,player. Y] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
				player.X--;
			}
		}
		static void movedown()
		{
			if (maze[player.X + 1,player. Y] == '.')
			{
				score++;
			}
			if (maze[player.X + 1, player.Y] == '*')
			{
				score = score + 10;
				checkpoint();
			}
			if (energizer && (maze[player.X + 1, player.Y] == 'G' || maze[player.X + 1, player.Y] == '`'))
			{
				Console.SetCursorPosition(player.Y, player.X + 1);
				Console.Write('P');
				maze[player.X + 1, player.Y] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
			}
			if (!energizer && maze[player.X + 1, player.Y] == 'G')
			{
				gameover();
			}
			if (!energizer && maze[player.X + 1, player.Y] == '`')
			{
				healthover();
			}
			if (maze[player.X + 1, player.Y] == ' ' || maze[player.X + 1, player.Y] == '.' || maze[player.X + 1, player.Y] == 'O' || maze[player.X + 1, player.Y] == 'P' || maze[player.X + 1, player.Y] == '*')
			{
				if (maze[player.X + 1, player.Y] == 'O')
				{
					energizer = true;
					energycount = 0;
				}
				Console.SetCursorPosition(player.Y, player.X + 1);
				Console.Write('P');
				maze[player.X + 1, player.Y] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X,player. Y] = ' ';
				player.X++;
			}
		}
		static void moveright()
		{
			if (maze[player.X, player.Y + 1] == '.')
			{
				score++;
			}
			if (maze[player.X, player.Y + 1] == '*')
			{
				score = score + 10;
				checkpoint();
			}
			if (energizer && (maze[player.X, player.Y + 1] == 'G' || maze[player.X,player.Y + 1] == '`'))
			{
				Console.SetCursorPosition(player.Y + 1, player.X);
				Console.Write('P');
				maze[player.X, player.Y + 1] = 'P';
				Console.SetCursorPosition(player.Y,player. X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
			}
			if (!energizer && maze[player.X, player.Y + 1] == 'G')
			{
				gameover();
			}
			if (!energizer && maze[player.X, player.Y + 1] == '`')
			{
				healthover();
			}
			if (maze[player.X, player.Y + 1] == ' ' || maze[player.X, player.Y + 1] == '.' || maze[player.X,player. Y + 1] == 'O' || maze[player.X, player.Y + 1] == 'P' || maze[player.X, player.Y + 1] == '*')
			{
				if (maze[player.X, player.Y + 1] == 'O')
				{
					energizer = true;
					energycount = 0;
				}
				Console.SetCursorPosition(player.Y + 1, player.X);
				Console.Write('P');
				maze[player.X,player. Y + 1] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
				player.Y++;
			}
		}
		static void moveleft()
		{
			if (maze[player.X, player.Y - 1] == '.')
			{
				score++;
			}
			if (maze[player.X, player.Y - 1] == '*')
			{
				score = score + 10;
				checkpoint();
			}
			if (energizer && (maze[player.X,player. Y - 1] == 'G' || maze[player.X,player. Y - 1] == '`'))
			{
				Console.SetCursorPosition(player.Y - 1, player.X);
				Console.Write('P');
				maze[player.X,player. Y - 1] = 'P';
				Console.SetCursorPosition(player.Y,player. X);
				Console.Write(' ');
				maze[player.X,player. Y] = ' ';
			}
			if (!energizer && maze[player.X, player.Y - 1] == 'G')
			{
				gameover();
			}
			if (!energizer && maze[player.X, player.Y - 1] == '`')
			{
				healthover();
			}
			if (maze[player.X, player.Y - 1] == ' ' || maze[player.X, player.Y - 1] == '.' || maze[player.X,player. Y - 1] == 'O' || maze[player.X, player.Y - 1] == 'P' || maze[player.X,player. Y - 1] == '*')
			{
				if (maze[player.X,player. Y - 1] == 'O')
				{
					energizer = true;
					energycount = 0;
				}
				Console.SetCursorPosition(player.Y - 1, player.X);
				Console.Write('P');
				maze[player.X, player.Y - 1] = 'P';
				Console.SetCursorPosition(player.Y, player.X);
				Console.Write(' ');
				maze[player.X, player.Y] = ' ';
				player.Y--;
			}
		}
		static void ghost_UP(ref int gx,ref int gy,ref char pre)
        {
			if (maze[gx - 1, gy] == ' ' || maze[gx - 1, gy] == '.' || maze[gx - 1, gy] == 'P' || maze[gx - 1, gy] == '*')
			{
				maze[gx, gy] = pre;
				Console.SetCursorPosition(gy, gx);
				if (maze[gx, gy] == '.')
				{
					Console.Write('.');
				}
				else
				{
					Console.Write(' ');
				}
				gx--;
				if (maze[gx, gy] != 'P')
				{
					pre = maze[gx, gy];
				}
				if (maze[gx, gy] == 'P')
				{
					pre = ' ';
					gameover();
				}
				maze[gx, gy] = 'G';
				Console.SetCursorPosition(gy, gx);
				Console.Write('G');
			}
		}
		static void ghost_DOWN(ref int gx, ref int gy, ref char pre)
        {
			if (maze[gx + 1, gy] == ' ' || maze[gx + 1, gy] == '.' || maze[gx + 1, gy] == 'P' || maze[gx + 1, gy] == '*')
			{
				maze[gx, gy] = pre;
				Console.SetCursorPosition(gy, gx);
				if (maze[gx, gy] == '.')
				{
					Console.Write('.');
				}
				else
				{
					Console.Write(' ');
				}
				gx++;
				if (maze[gx, gy] != 'P')
				{
					pre = maze[gx, gy];
				}
				if (maze[gx, gy] == 'P')
				{
					pre = ' ';
					gameover();
				}
				maze[gx, gy] = 'G';
				Console.SetCursorPosition(gy, gx);
				Console.Write('G');
			}
		}
		static void ghost_RIGHT(ref int gx, ref int gy, ref char pre)
        {
			if (maze[gx, gy + 1] == ' ' || maze[gx, gy + 1] == '.' || maze[gx, gy + 1] == 'P' || maze[gx, gy + 1] == '*')
			{
				maze[gx, gy] = pre;
				Console.SetCursorPosition(gy, gx);
				if (maze[gx, gy] == '.')
				{
					Console.Write('.');
				}
				else
				{
					Console.Write(' ');
				}
				gy++;
				if (maze[gx, gy] != 'P')
				{
					pre = maze[gx, gy];
				}
				if (maze[gx, gy] == 'P')
				{
					pre = ' ';
					gameover();
				}
				maze[gx, gy] = 'G';
				Console.SetCursorPosition(gy, gx);
				Console.Write('G');
			}
		}
		static void ghost_LEFT(ref int gx, ref int gy, ref char pre)
        {
			if (maze[gx, gy - 1] == ' ' || maze[gx, gy - 1] == '.' || maze[gx, gy - 1] == 'P' || maze[gx, gy - 1] == '*')
			{
				maze[gx, gy] = pre;
				Console.SetCursorPosition(gy, gx);
				if (maze[gx, gy] == '.')
				{
					Console.Write('.');
				}
				else
				{
					Console.Write(' ');
				}
				gy--;
				if (maze[gx, gy] != 'P')
				{
					pre = maze[gx, gy];
				}
				if (maze[gx, gy] == 'P')
				{
					pre = ' ';
					gameover();
				}
				maze[gx, gy] = 'G';
				Console.SetCursorPosition(gy, gx);
				Console.Write('G');
			}
		}
		static void enemy1()
		{
			int value = ghostDirection1();
			if (value == 1)
			{
				ghost_UP(ref gx1, ref gy1, ref pre);
			}
			if (value == 2)
			{
				ghost_DOWN(ref gx1, ref gy1, ref pre);

			}
			if (value == 3)
			{
				ghost_RIGHT(ref gx1, ref gy1, ref pre);

			}
			if (value == 4)
			{
				ghost_LEFT(ref gx1, ref gy1, ref pre);

			}

		}
		static void enemy2()
		{
			int value = ghostDirection2();
			if (value == 1)
			{
				ghost_RIGHT(ref gx2, ref gy2, ref pre2);
			}
			if (value == 2)
			{
				ghost_LEFT(ref gx2, ref gy2, ref pre2);
			}

		}
		static void enemy3()
		{
			int value = ghostDirection3();
			if (value == 1)
			{
				ghost_UP(ref gx3, ref gy3, ref pre3);
			}
			if (value == 2)
			{
				ghost_DOWN(ref gx3, ref gy3, ref pre3);
			}
		}
		static void enemy4()
		{
			int value = ghostDirection4();
			if (value == 1)
			{
				ghost_UP(ref gx4, ref gy4, ref pre4);
			}
			if (value == 2)
			{
				ghost_DOWN(ref gx4, ref gy4, ref pre4);
			}
			if (value == 3)
			{
				ghost_RIGHT(ref gx4, ref gy4, ref pre4);
			}
			if (value == 4)
			{
				ghost_LEFT(ref gx4, ref gy4, ref pre4);
			}
		}
		static void enemy5()
		{
			int value = ghostDirection5();
			if (value == 1)
			{
				ghost_UP(ref gx5, ref gy5, ref pre5);
			}
			if (value == 2)
			{
				ghost_DOWN(ref gx5, ref gy5, ref pre5);
			}
			if (value == 3)
			{
				ghost_RIGHT(ref gx5, ref gy5, ref pre5);
			}
			if (value == 4)
			{
				ghost_LEFT(ref gx5, ref gy5, ref pre5);
			}
		}
		static void loadrecords()
		{
			string path = "records.txt";
			StreamReader var = new StreamReader(path);
			while(!var.EndOfStream)
            {
                scores.Add(int.Parse(var.ReadLine()));
            }
			var.Close();
			find_highest();
		}
		static void viewrecords()
		{
			for (int x = 0; x < scores.Count; x++)
			{
				Console.WriteLine(x + 1+ ")  "+ scores[x]);
			}
			Console.Write("\n");
			Console.Write("Highest Score : ");
			Console.Write(highest_score);
			Console.Write("\n");
			clearScrean();
		}
		static void clearScrean()
        {
            Console.WriteLine("Press any key to continue...");
			Console.ReadKey(true);
        }
		static void exitgame()
		{
			header();
			Console.Write("\n");
			Console.WriteLine(".........................................................................................");
			Console.WriteLine("                           Thanks For Playing the Game");
			Console.WriteLine(".........................................................................................");
			Console.ReadKey(true);
		}
		static void store_score_file()
		{
			string path = "records.txt";
			StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < scores.Count; i++)
            {
				file.WriteLine(scores[i]);
            }
			file.Close();
		}
		static void fire1()
		{
			firecount1++;
			if (firecount1 == 3)
			{
				firecount1 = 0;
				if (maze[fireX1, fireY1 + 1] == '#' || maze[fireX1, fireY1 + 1] == 'G')
				{

					maze[fireX1, fireY1] = ' ';
					Console.SetCursorPosition(fireY1, fireX1);
					Console.Write(' ');
					restart1 = true;
				}
				else
				{
					if (maze[fireX1, fireY1 + 1] == 'P')
					{
						healthover();
					}
					maze[fireX1, fireY1] = ' ';
					Console.SetCursorPosition(fireY1, fireX1);
					Console.Write(' ');
					maze[fireX1, fireY1 + 1] = '`';
					Console.SetCursorPosition(fireY1 + 1, fireX1);
					Console.Write('`');
				}
				if (restart1)
				{
					fireX1 = 9;
					fireY1 = 10;
					restart1 = false;
				}
				fireY1++;
			}
		}
		static void fire2()
		{
			firecount2++;
			if (firecount2 == 3)
			{
				firecount2 = 0;
				if (maze[fireX2 - 1, fireY2] == '#' || maze[fireX2 - 1, fireY2] == 'G')
				{

					maze[fireX2, fireY2] = ' ';
					Console.SetCursorPosition(fireY2, fireX2);
					Console.Write(' ');
					restart2 = true;
				}
				else
				{
					if (maze[fireX2 - 1, fireY2] == 'P')
					{
						healthover();
					}
					maze[fireX2, fireY2] = ' ';
					Console.SetCursorPosition(fireY2, fireX2);
					Console.Write(' ');
					maze[fireX2 - 1, fireY2] = '`';
					Console.SetCursorPosition(fireY2, fireX2 - 1);
					Console.Write('`');
				}
				if (restart2)
				{
					fireX2 = 23;
					fireY2 = 22;
					restart2 = false;
				}
				fireX2--;
			}
		}
		static void fire3()
		{
			firecount3++;
			if (firecount3 == 3)
			{
				firecount3 = 0;
				if (maze[fireX3 + 1, fireY3] == '#' || maze[fireX3 + 1, fireY3] == 'G')
				{

					maze[fireX3, fireY3] = ' ';
					Console.SetCursorPosition(fireY3, fireX3);
					Console.Write(' ');
					restart3 = true;
				}
				else
				{
					if (maze[fireX3 + 1, fireY3] == 'P')
					{
						healthover();
					}
					maze[fireX3, fireY3] = ' ';
					Console.SetCursorPosition(fireY3, fireX3);
					Console.Write(' ');
					maze[fireX3 + 1, fireY3] = '`';
					Console.SetCursorPosition(fireY3, fireX3 + 1);
					Console.Write('`');
				}
				if (restart3)
				{
					fireX3 = 1;
					fireY3 = 44;
					restart3 = false;
				}
				fireX3++;
			}
		}

		///////////////////////////////////////////////      MAIN      /////////////////////////////////////////////////
		static void Main()
		{
			load_header();
			loadrecords();
			char option = ' ';
			while (option != '4')
			{
				main_menu();
				option = Console.ReadLine()[0];
				if (option == '1')
				{
					load_maze();
					gx1 = 9; gy1 = 43;
					gx2 = 3; gy2 = 3;
					gx3 = 16; gy3 = 27;
					gx4 = 6; gy4 = 55;
					gx5 = 9; gy5 = 9;
					movecount = 0;movecount2 = 0;
					energycount = 0;
					lifes = 3;
					health = 100;
					player.X = 22; player.Y = 68;
					score = 0;stars = 0;
					running = true;
					pre = ' '; pre2 = ' '; pre3 = ' '; pre4 = ' ';pre5 = ' ';
					ft = true; st = false;
					energizer = false;
					Console.Clear();
					display();
					Console.SetCursorPosition(player.Y, player.X);
					Console.Write('P');
					while (running)
					{
						Thread.Sleep(50);
						if (Keyboard.IsKeyPressed(Key.LeftArrow))
						{
							moveleft();
						}
						if (Keyboard.IsKeyPressed(Key.RightArrow))
						{
							moveright();
						}
						if (Keyboard.IsKeyPressed(Key.UpArrow))
						{
							moveup();
						}
						if (Keyboard.IsKeyPressed(Key.DownArrow))
						{
							movedown();
						}
						if (Keyboard.IsKeyPressed(Key.Escape))
						{
							game_esc();
						}
						if ((player.X == 0 && player.Y == 2) || (player.X == 0 && player.Y == 3) || (player.X == 0 && player.Y == 4))
						{
							gameend();
							game_end_score();
							store_score_array();
						}
						if (energizer)
						{
							energycount++;
							if (energycount > 100)
							{
								energizer = false;
								energycount = 0;
							}
						}
						Console.SetCursorPosition(73, 5);
						Console.Write("Highest Score:");
						Console.Write(highest_score);
						Console.SetCursorPosition(72, 18);
						if (stars <= 3)
						{
							Console.Write("Checkpoint Left:");
							Console.Write(3 - stars);
						}
						else
						{
							Console.Write("Checkpoint Left:0");
						}
						Console.SetCursorPosition(77, 5);
						score1();
						Console.SetCursorPosition(77, 9);
						Console.Write("Lifes:");
						Console.Write(lifes);
						Console.SetCursorPosition(75, 13);
						Console.Write("              ");
						Console.SetCursorPosition(75, 11);
						if (health == 100)
						{
							Console.Write("Health : 100%");
						}
						if (health == 75)
						{
							Console.Write("Health : 75% ");
						}
						if (health == 50)
						{
							Console.Write("Health : 50% ");
						}
						if (health == 25)
						{
							Console.Write("Health : 25% ");
						}
						if (energizer)
						{
							Console.SetCursorPosition(75, 20);
							Console.Write("Time Left:");
                            Console.Write("    ");
							Console.SetCursorPosition(86, 20);
							Console.Write(100 - energycount);
						}
						if (!energizer)
						{
							Console.SetCursorPosition(75, 20);
							Console.Write("            ");
							enemy1();
							enemy2();
							enemy3();
							enemy4();
							enemy5();
							fire1();
							fire2();
							fire3();
						}
					}
				}
				else if (option == '2')
				{
					header();
					Console.Write("View Records>");
					Console.Write("\n");
					Console.Write("\n");
					viewrecords();
				}
				else if (option == '3')
				{
					instructions();
				}
				else if (option == '4')
				{
					exitgame();
					store_score_file();
				}
				else
				{
					Console.Write("You have entered the wrong input");
					Console.Write("\n");
					Console.Write("Press any key to enter again...");
					Console.ReadKey(true);
				}
			}
		}
	}
}
