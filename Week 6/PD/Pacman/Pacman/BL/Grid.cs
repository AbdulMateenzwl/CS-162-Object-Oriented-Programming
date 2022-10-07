using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    class Grid
    {
        private Cell[,] maze= new Cell[24,71];
        private int rowSize;
        private int colSize;
        public Grid(int rowSize, int colSize, string path)
        {
            this.rowSize = rowSize;
            this.colSize = colSize;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                int j = 0;
                while ((record = f.ReadLine()) != null)
                {
                    for (int i = 0; i < record.Length; i++)
                    {
                        char value = record[i];
                        Cell c = new Cell(value, j, i);
                        //maze[j, i].SetValue(value);
                        //maze[j, i].SetXY(j, i);
                        maze[j, i] = c;
                    }
                    j++;
                }
                f.Close();
            }
        }
        public Cell getCell(int x,int y)
        {
            return maze[x, y];
        }
        public Cell getLeftCell(Cell cell)
        {
            Cell c = new Cell(cell.Value,cell.X,cell.Y-1);
            return c;
        }


        public Cell findPacman()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int m = 0; m < colSize; m++)
                {
                    if(maze[i,m].Value == 'P')
                    {
                        return maze[i, m];
                    }
                }
            }
            return null;
        }
        public Cell findGhost(char ghost)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int m = 0; m < colSize; m++)
                {
                    if (maze[i, m].Value == ghost)
                    {
                        return maze[i, m];
                    }
                }
            }
            return null;
        }
        public void draw()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int m = 0; m < colSize; m++)
                {
                    Console.SetCursorPosition(maze[i, m].Y, maze[i, m].X);
                    Console.Write(maze[i, m].Value);
                }
            }
        }
    }
}
