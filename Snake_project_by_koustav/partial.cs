using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_project_by_koustav
{
    internal class Program
    {

        int height = 20;
        int width = 60;

        //This is for inputs for our name
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';



        int[] X = new int[1000];
        int[] Y = new int[1000];


        int fruitX;
        int fruitY;

        int parts = 1;
        int level;

        Random random = new Random();

        public Program()
        {
            X[0] = 15;
            Y[0] = 10;
            Console.CursorVisible = false;

            fruitX = random.Next(2, width - 2);
            fruitY = random.Next(2, height - 2);

        }

        //this is for height and width creation for snake board
        public void snakeboard()
        {


            Console.Clear();
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(i, 1);
                Console.Write(">");
            }
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(i, height + 2);
                Console.Write("<");
            }
            for (int i = 1; i <= (height + 1); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(1, i);
                Console.Write("x");
            }
            for (int i = 1; i <= (height + 1); i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(width + 2, i);
                Console.Write("x");
            }
            //Console.SetCursorPosition(3, 3);
            //score();
        }

        public void keypress()
        {
            if (Console.KeyAvailable)//if you press any key
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        //snake foods (@)
        public void fruitz(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(a, b);
            Console.Write("♥");

        }
        public void snakebody(int a, int b)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(a, b);
            Console.Write("☼");

        }



        //Game logic
        public void gamel_ogic()
        {


            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {

                    ++parts;
                    fruitX = random.Next(2, width - 2);
                    fruitY = random.Next(2, height - 2);

                }
            }

            for (int i = parts; i > 1; i--)
            {
                
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];

            }

            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
                case 'd':
                    X[0]++;
                    break;


            }

            for (int i = 0; i <= 10; i++)
            {
                snakebody(X[i], Y[i]);
                fruitz(fruitX, fruitY);

            }

            Thread.Sleep(100);


        }



        //score
        public void score()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SCORE : ");
            Console.WriteLine((parts - 1)*100);
        }

        public void LVL()
        {
            Console.ForegroundColor = ConsoleColor.Red;
           
            if(parts-1>=0 && parts-1<10)
            {
                Console.Write("LEVEL : 1");
            }
            else if (parts - 1 >= 10 && parts - 1 < 20)
            {
                Console.Write("LEVEL : 2");
            }
            else if (parts - 1 >= 20 && parts - 1 < 30)
            {
                Console.Write("LEVEL : 3");
            }
            if (parts - 1 >= 30 && parts - 1 < 40)
            {
                Console.Write("LEVEL : 4");
            }
        }


   
        static void Main(string[] args)
        {
            string txt = "bye bye player...";
            Program obj = new Program();
            lvl:
            obj.snakeboard();
            Console.SetCursorPosition(18, 5);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Welcome To The Snake Gamme");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t\tP : Play");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("\t\tE : Exit");
            ConsoleKeyInfo keyInfo= Console.ReadKey(true);
            Console.Beep();
            char x=keyInfo.KeyChar;
            Console.WriteLine();
            Console.WriteLine(x);
            Console.Clear();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;


            do
            {
                if (x == 'p')
                {
                    obj.snakeboard();
                    Console.SetCursorPosition(3, 3);
                    obj.score();
                    Console.SetCursorPosition(3, 4);
                    obj.LVL();
                    obj.keypress();
                    obj.gamel_ogic();
                }if (x =='e')
                {
                    obj.snakeboard();

                    for (int i = 0; i < txt.Length; i++)
                    {
                        
                        Console.SetCursorPosition(18+i, 5);
                        Console.Write(txt[i]);
                        Thread.Sleep(100);
                       
                    }
                    
                    break;
                }
            }while(true);


            Console.ReadKey();
            
            
        }
    }
}
