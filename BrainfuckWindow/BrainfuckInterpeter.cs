using System;
using System.Collections.Generic;
using System.Text;

namespace BrainfuckWindow
{
    public enum EOFRepresentation
    {
        MinusOne,
        Zero,
        Ten,
        Thirteen,
        NoChange
    }
    public class BrainfuckInterpeter
    {
        public static string Execute(string code, string input, EOFRepresentation eof)
        {

            int pointerString = 0;
            StringBuilder output = new StringBuilder();
            short[] cells = new short[16384];
            int pointerCell = cells.Length / 2;

            Stack<int> codeReturn = new Stack<int>();

            //MAINLOOP
            while (pointerString < code.Length)
            {
                switch (code[pointerString])
                {
                    case '+':
                        cells[pointerCell]++;
                        break;
                    case '-':
                        cells[pointerCell]--;
                        break;
                    case '<':
                        pointerCell--;
                        if (pointerCell < 0)
                        {
                            Array.Resize(ref cells, cells.Length + 1);
                            for (int i = cells.Length - 1; i > 0; i--)
                                cells[i] = cells[i - 1];
                            cells[0] = 0;
                            pointerCell = 0;
                        }
                        break;
                    case '>':
                        pointerCell++;
                        if (cells.Length <= pointerCell)
                        {
                            Array.Resize(ref cells, cells.Length + 1);
                        }
                        break;
                    case ',':
                        if (input == "")
                        {
                            if(eof != EOFRepresentation.NoChange)
                            {
                                switch (eof)
                                {
                                    case EOFRepresentation.MinusOne:
                                        cells[pointerCell] = -1;
                                        break;
                                    case EOFRepresentation.Zero:
                                        cells[pointerCell] = 0;
                                        break;
                                    case EOFRepresentation.Ten:
                                        cells[pointerCell] = 10;
                                        break;
                                    case EOFRepresentation.Thirteen:
                                        cells[pointerCell] = 13;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            cells[pointerCell] = Convert.ToByte(input[0]);
                            input = input.Remove(0, 1);
                        }
                        break;
                    case '.':
                        output.Append(Convert.ToChar(cells[pointerCell]));
                        break;
                    case '[':
                        if (cells[pointerCell] == 0)
                        {
                            //jump to the end of the loop
                            int i = 1;//internal loops counter
                            while(i != 0)
                            {
                                pointerString++;
                                if (code[pointerString] == '[') i++;
                                else if (code[pointerString] == ']') i--;
                            }
                        }
                        else
                        {
                            //enter loop
                            codeReturn.Push(pointerString);
                        }
                        break;
                    case ']':
                        if (cells[pointerCell] != 0)
                        {
                            //jump to the start of the loop
                            pointerString = codeReturn.Peek();
                        }
                        else
                        {
                            //exit loop
                            codeReturn.Pop();
                        }
                        break;
                }
                pointerString++;
            }
            return output.ToString();
        }
    }

}
//ROT13
//-,+[-[>>++++[>++++++++<-]<+<-[>+>+>-[>>>]<[[>+<-]>>+>]<<<<<-]]>>>[-]+>--[-[<->+++[-]]]<[++++++++++++<[>-[>+>>]>[+[<+>-]>+>>]<<<<<-]>>[<+>-]>[-[-<<[-]>>]<<[<<->>-]>>]<<[<<+>>-]]<[-]<.[-]<-,+] 