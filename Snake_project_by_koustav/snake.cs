//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace snake_game_BY_Kauatav
//{

//    internal class snake
//    {
//        ConsoleKeyInfo keyInfo=new ConsoleKeyInfo();
//        char key = 'w';
//        char dir = 'u';

//        int snakeX;
//        int snakeY;

//        List<snake_position> snakepos;
//        public snake()//constructor
//        {
//            //snake position inisilizing
//            snakeX = 10;
//            snakeY = 10;
//            snakepos=new List<snake_position>();
//            snakepos.Add(new snake_position(snakeX,snakeY));
//            Console.CursorVisible = false;//hiding the cursor while gameplay.
//        }

//        public void snakedesign()
//        {
//            //Snake body
//            Console.ForegroundColor= ConsoleColor.DarkCyan;
//            foreach (snake_position pos in snakepos)
//            {
//                Console.SetCursorPosition(pos.posX, pos.posY);
//                Console.Write("+");
//            }
            
//        }

//        public void keyinput()
//        {
//            if(Console.KeyAvailable)
//            {
//                keyInfo=Console.ReadKey(true);
//                key = keyInfo.KeyChar;
//            }
//        }

//        //snake moving key and direction
//        public void dirc()
//        {
//            if(key=='w' && dir!='d')
//            {
//                dir = 'u';
//            }
//            else if(key=='s' && dir!='u')
//            {
//                dir = 'd';
//            }
//            else if (key == 'd' && dir != 'l')
//            {
//                dir = 'r';
//            }
//            else if (key == 'a' && dir != 'r')
//            {
//                dir = 'l';
//            }
//        }
    
//        //snake movement based on "dirc class"    
//        public void snakemovement()
//        {
//            if(dir=='u')
//            {
//                snakeX++;
//            }
//            else if(dir=='d')
//            {
//                snakeY++;
//            }
//            else if (dir == 'l')
//            {
//                snakeX--;
//            }
//            else if (dir == 'r')
//            {
//                snakeX++;
//            }
//            snakepos.Add(new snake_position(snakeX, snakeY));
//            snakepos.RemoveAt(0);
//            Thread.Sleep(100);

//        }
    
//    }
//}
