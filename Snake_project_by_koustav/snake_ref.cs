//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace snake_game_BY_Kauatav
//{
//    internal class snake_ref
//    {
//        public int height { get; set; }
//        public int width { get; set; }

//        public snake_ref()
//        {
//            height = 20;
//            width = 60;
//        }
//        //snake board design
//        public void snakeboard()
//        {
//            Console.Clear();
//            for(int i = 0; i < width; i++)
//            {
//                Console.SetCursorPosition(i, 0);
//                Console.Write('^');
//            }
//            for (int i = 0; i < width; i++)
//            {
//                Console.SetCursorPosition(i, height);
//                Console.Write('^');
//            }
//            for (int i = 0; i < height; i++)
//            {
//                Console.SetCursorPosition(0,i);
//                Console.Write('^');
//            }
//            for (int i = 0; i < height; i++)
//            {
//                Console.SetCursorPosition(width, i);
//                Console.Write('^');
//            }


//        }

//    }

//    class GAME
//    {
//        static void Main()
//        {

//            snake_ref game = new snake_ref();
//            snake game2 = new snake();
           
//            while(true)
//            {
//                game.snakeboard();
//                game2.keyinput();
//                game2.snakedesign();
//                game2.snakemovement();
//                Console.ReadKey();
//            }
//        }

//    }
//}
