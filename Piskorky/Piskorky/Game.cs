using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Piskorky
{
    public class Game
    {
        public int Rows { get; set; }
        public int Cols { get; set; }

        [XmlIgnore]
        public char[,] Playground { get; set; }
        public List<char[]> ListToXml { get; set; }
        public int CountOfSymbols { get; set; }

        public int playerIndex = 0;
        private char[] players = new char[] { 'X', 'O' };
        public char Player
        {
            get
            {
                return players[playerIndex];
            }
        }

        [XmlIgnore]
        public Stack<Step> steps;

        public Game() { }

        public Game(int rows, int cols, int countOfSymbols)
        {
            Rows = rows;
            Cols = cols;

            Playground = new char[Rows, Cols];
            CountOfSymbols = countOfSymbols;
            steps = new Stack<Step>();

        }

        public Game(int rows, int cols, int countOfSymbols, char[,] playground, int playerIndex)
        {
            Rows = rows;
            Cols = cols;

            Playground = playground;
            CountOfSymbols = countOfSymbols;

            this.playerIndex = playerIndex;
        }

        public void MarkTheSign(int rowIndex, int colIndex)
        {
            if (playerIndex++ >= players.Length - 1)
            {
                playerIndex = 0;
            }

            Playground[rowIndex, colIndex] = Player;
        }

        public bool EvaluateTheGame()
        {
            bool isWinner = false;
            for (int j = 0; j < Playground.GetLength(0); j++)  // zistovanie vertikalne a horizontalne
            {
                int symbolsCountInRow = 0;
                int symbolsCountInCol = 0;
                for (int i = 0; i < Playground.GetLength(0); i++)
                {
                    if (Playground[i, j] == players[playerIndex])
                        symbolsCountInRow += 1;
                    else
                        symbolsCountInRow = 0;

                    if (symbolsCountInRow == CountOfSymbols)
                    {
                        isWinner = true;
                        break;
                    }

                    if (Playground[j, i] == players[playerIndex])
                        symbolsCountInCol += 1;
                    else
                        symbolsCountInCol = 0;

                    if (symbolsCountInCol == CountOfSymbols)
                    {
                        isWinner = true;
                        break;
                    }
                }
            }
            //if(isWinner == false)
            int d = 0;                              // zistovanie diagonalne
            while (d < Playground.GetLength(0))
            {
                int x = 0;
                int countDiag1 = 0;
                for (int j = d; j >= 0; j--)
                {
                    if (Playground[x, j] == players[playerIndex])
                    {
                        countDiag1 += 1;
                    }
                    else
                    {
                        countDiag1 = 0;
                    }

                    if (countDiag1 == CountOfSymbols)
                    {
                        isWinner = true;
                        break;
                    }
                    x++;
                }

                x = 0;
                int countDiag2 = 0;
                for (int j = d; j < Playground.GetLength(0); j++)
                {
                    if (Playground[x, j] == players[playerIndex])
                    {
                        countDiag2 += 1;
                    }
                    else
                    {
                        countDiag2 = 0;
                    }

                    if (countDiag2 == CountOfSymbols)
                    {
                        isWinner = true;
                        break;
                    }
                    x++;
                }

                x = Playground.GetLength(0) - 1;
                countDiag1 = 0;
                for (int j = d; j < Playground.GetLength(0); j++)
                {
                    if (Playground[x, j] == players[playerIndex])
                    {
                        countDiag1 += 1;
                    }
                    else
                    {
                        countDiag1 = 0;
                    }

                    if (countDiag1 == CountOfSymbols)
                    {
                        isWinner = true;
                    }

                    x--;
                }

                x = Playground.GetLength(0) - 1;
                countDiag2 = 0;
                for (int j = d; j >= 0; j--)
                {
                    if (Playground[x, j] == players[playerIndex])
                    {
                        countDiag2 += 1;
                    }
                    else
                    {
                        countDiag2 = 0;
                    }

                    if (countDiag2 == CountOfSymbols)
                    {
                        isWinner = true;
                    }

                    x--;
                }
                d++;
            }
            return isWinner;
        }

        public void PreparePlaygroundForSaving()
        {
            ListToXml = new List<char[]>();

            for (int i = 0; i < Playground.GetLength(0); i++)
            {
                char[] playgroundRow = new char[Playground.GetLength(0)];
                for (int j = 0; j < Playground.GetLength(1); j++)
                {
                    playgroundRow[j] = Playground[i, j];
                }
               
                ListToXml.Add(playgroundRow);
            }
        }

        public void LoadPlaygroundFromList()
        {
            Playground = new char[Rows, Cols];
            for (int i = 0; i < ListToXml.Count; i++)
            {
                char[] onerow = ListToXml[i];
                for (int j = 0; j < onerow.Length; j++)
                {
                    Playground[i, j] = onerow[j];
                }
            }
        }
        
        public void PutAsideStep(int row, int col, int playerIndex)
        {
            Step step = new Step();
            step.Row = row;
            step.Col = col;

            if (playerIndex == 0)
            {
                step.PlayerIndex = 1;
            }
            else
            {
                step.PlayerIndex = 0;
            }

            steps.Push(step);
        }

        public void TheStepBack()
        {
            if (steps.Count != 0)
            {
                Step stepback = steps.Pop();
                Playground[stepback.Row, stepback.Col] = '\0';
                playerIndex = stepback.PlayerIndex;
            }
        }

        public void SetSteps()
        {
            steps = new Stack<Step>();
        }
    }
}

