using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    public class BrainfuckToString
    {
        int pointerCell = 0;
        int pointerString = 0;
        int[] cells;
        string output = "";

        private static bool CheckCode(string code)
        {         
            foreach (char c in code)
            {
                if (c != '+' && c != '-' && c != '>' && c != '<' && c != ',' && c != '.' && c != '[' && c != ']')
                    return false;
            }
            //+check loops
            return true;
        }

        private static int[] InitializeCells(int from, int to, out int startcell)
        {

            int size = Math.Abs(from) + Math.Abs(to) + 1;
            startcell = Math.Abs(from);
            return new int[size];

        }

        public string Compile(string code)
        {
            CheckCode(code); //Repair/message/something
            cells = InitializeCells(code.Count(f => f == '<'), code.Count(f => f == '>'), out pointerCell);

            //MAINLOOP
            while(pointerString < code.Length)
            {
                switch(code[pointerString])
                {
                    case '+':
                        cells[pointerCell]++;
                        break;
                    case '-':
                        cells[pointerCell]--;
                        break;
                    case '<':
                        pointerCell--;
                        break;
                    case '>':
                        pointerCell++;
                        break;
                    case ',':
                        Console.ReadLine();
                        break;
                    case '.':

                        break;
                    case ']':

                        break;
                }
                pointerString++;
            }





            return output;
        }
    }
}
