using System;
using System.Drawing;

namespace Crazy_Treasure_Maze
{
   public class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            

            int userInput = 00;
            int xStudent = 9;
            int yStudent = 0;
            int tempX = 0;
            int tempY = 0;
           
            Point ghostPosition = new Point(random.Next(0, 9), random.Next(0, 9));

            int xGoblin = random.Next(0, 9);
            int yGoblin = random.Next(0, 9);

            int xTreasure = random.Next(0, 9);
            int yTreasure = random.Next(0, 9);

            int lockx = 0;
            int locky = 0;

            string seed = "";
            bool seedIsSet = false;
            
            
            int detectionGoblineXY = 0;
            int detectionTreasureXY = 0;
            int detectionGhostXY = 0;
           
            string incorrectInput = "valid input";
            bool detectionGhost = false; 
            bool detectionTreasure = false;  
            bool detectionGobline = false;  
            string exitCommand = "";
            while (exitCommand != "p")
            {
                // Note UX is no good, to  hard to navigate



                //Testing locaton ----------------------------------------------
                Console.WriteLine("***************** Testing locaton *******************");
                Console.WriteLine("Ghost:" + ghostPosition.X + " " + ghostPosition.Y);
                Console.WriteLine("Goblin:" + xGoblin + " " + yGoblin);
                Console.WriteLine("Treasure:" + xTreasure + " " + yTreasure);
                Console.WriteLine("*****************************************************");
                // -------------------------------------------------------------

                if (seed == "" && seedIsSet == false)
                {
                    Console.WriteLine("Please enter a seed, if no seed is enterd a defalt will be set");
                    seed = Console.ReadLine();
                    random = new Random();
                    seedIsSet = true;
                } else if (seed != "")
                { 
                    int newSeed = Int32.Parse(seed);
                    random = new Random(newSeed);
                    seedIsSet = true; 
                }

                if (seedIsSet == true)
                {
                    Console.WriteLine(Console.WindowWidth);
                    Console.WriteLine(Title());

                    // Detection 
                    detectionGhost = Detection(xStudent, yStudent, ghostPosition.X, ghostPosition.Y);
                    detectionTreasure = Detection(xStudent, yStudent, xTreasure, yTreasure);
                    detectionGobline = Detection(xStudent, yStudent, xGoblin, yGoblin);

                    // end game if conditions are meet
                    if(detectionGhost == true)
                    {
                        Console.WriteLine("GAME OVER!");
                        exitCommand = "p";  
                    }
                    if(detectionTreasure == true && detectionGobline == true)
                    {
                        Console.WriteLine("YOU WON!");
                        exitCommand = "p";
                    }
                    if(detectionTreasure == false && detectionGobline == true)
                    {
                        Console.WriteLine("GAME OVER!");
                        exitCommand = "p";
                    }

                    detectionGhostXY = DetectionXY(xStudent, yStudent, ghostPosition.X, ghostPosition.Y);
                    detectionTreasureXY = DetectionXY(xStudent, yStudent, xTreasure, yTreasure);
                    detectionGoblineXY = DetectionXY(xStudent, yStudent, xGoblin, yGoblin);

                    Console.WriteLine(closeToMessage(xStudent, detectionGhostXY, "I can hear coins falling"));
                    Console.WriteLine(closeToMessage(yStudent, detectionGhostXY, "I can hear coins falling"));
                    
                    Console.WriteLine(closeToMessage(xStudent, detectionGoblineXY, "There is somebody mumbling about a Treasure!"));
                    Console.WriteLine(closeToMessage(yStudent, detectionGoblineXY, "There is somebody mumbling about a Treasure!"));

                    Console.WriteLine(getMessage(detectionGhost, "Ghost Found!"));
                    Console.WriteLine(getMessage(detectionGobline, "Gobline Found!"));
                    Console.WriteLine(getMessage(detectionTreasure, "Treasure Found!"));
                    //---------------------------------------------


                    // trys to build the 2d array and move ghost in a random direction.
                    // catch if ghost trys to move ouyt side arrays and writes messsage to the screen.
                    try
                    {
                        lockx = ghostPosition.X;
                        locky = ghostPosition.Y;
                        Console.WriteLine(MakeArray(xStudent, yStudent, ghostPosition.X, ghostPosition.Y));
                        ghostPosition = MoveGhost(ghostPosition, random);
                        tempX = ghostPosition.X;
                        tempY = ghostPosition.Y;
                    }
                    catch (IndexOutOfRangeException e)
                    {



                        if (ghostPosition.X == -1)
                        {
                            ghostPosition.X = tempX + 1;
                        }
                        else if (ghostPosition.X == 10)
                        {
                            ghostPosition.X = tempX - 1;
                        }
                        else if (ghostPosition.Y == -1)
                        {
                            ghostPosition.Y = tempX + 1;
                        }
                        else if (ghostPosition.Y == 10)
                        {
                            ghostPosition.Y = tempX - 1;
                        }

                        MakeArray(xStudent, yStudent, ghostPosition.X, ghostPosition.Y);
                        Console.WriteLine("I hear The Ghost");

                    }

                    Console.WriteLine("next position" + ghostPosition);
                    if (incorrectInput == "Not a valid input")
                    {
                        ghostPosition.Y = locky;
                        ghostPosition.X = lockx;
                        Console.WriteLine(incorrectInput);
                    }

                    // user inputs
                    userInput = Console.ReadKey().KeyChar;
                    switch (userInput)
                    {
                        case 110:
                        case 78:
                            {
                                if (xStudent > 0)
                                {
                                    xStudent--;
                                    userInput = 00;
                                    incorrectInput = "valid input";


                                }

                                break;

                            }
                        case 115:
                        case 83:
                            {
                                if (xStudent < 9)
                                {
                                    xStudent++;
                                    userInput = 00;
                                    incorrectInput = "valid input";


                                }


                                break;
                            }
                        case 119:
                        case 87:
                            {
                                if (yStudent > 0)
                                {
                                    yStudent--;
                                    userInput = 00;
                                    incorrectInput = "valid input";


                                }


                                break;
                            }
                        case 101:
                        case 96:
                            {
                                if (yStudent < 9)
                                {
                                    yStudent++;
                                    userInput = 00;
                                    incorrectInput = "valid input";


                                }

                                break;
                            }
                        case 112:
                        case 80:
                            {
                                
                                exitCommand = "p";
                                incorrectInput = "valid input";
                                break;
                            }
                        default:
                            {
                                
                                if (userInput == 13 || userInput == 00)
                                {
                                    Console.WriteLine("");
                                    incorrectInput = "Not a valid input";
                                    userInput = 00;
                                }
                                else
                                {
                                   
                                    incorrectInput = "Not a valid input";
                                    userInput = 00;
                                }

                                break;
                            }

                    }

                    // clears the previouse iteration 
                    Console.Clear();

                }
            }
        }

        // Detects the x & y cordonants --------------------------------------
        public static bool Detection(int xStudent, int yStudent, int x, int y)
        {
            
            if (yStudent == y && xStudent == x)
            {
                
                return true;
            }
            return false;
        }
        public static int DetectionXY(int xStudent, int yStudent, int x, int y)
        {
            if (yStudent == y - 1 && xStudent == x)
            {
                return y - 1;
            }
            if (yStudent == y + 1 && xStudent == x)
            {
                return y + 1;
            }
            if (yStudent == y && xStudent == x - 1)
            {
                return x - 1;
            }
            if (yStudent == y && xStudent == x + 1)
            {
                return x + 1;
            }
            return -1;
        }
        public static string closeToMessage(int aStudent, int detection, string message)
        {
            if (aStudent == detection)
            {
                return message;
            }
            return "";
        }
        public static string getMessage(bool detection, string command)
        {
            if (detection == true)
            {
                return command;
            }
            return "";
        }
        //------------------------------------------------------------------------------------


        // returns the title --------
        public static string Title()
        {
            return "----------- Crazy Treasure Maze -----------\n" + "Controls: N = Move Up\n" + "          S = Move Down\n" + "          E = Move Right\n" + "          W = Move Left\n" + "          p = End Application\n" + "-------------------------------------------\n";
        }
        //---------------------------

        //sets up the ghosts random movments 
        public static Point MoveGhost(Point position, Random random)
        {
            int ghostrnd = random.Next(1,5);
            Point ghostMove;

                switch (ghostrnd)
                {
                    case 1:
                            ghostMove = new Point(position.X + 1, position.Y);      
                        break;
                    case 2:
                             ghostMove = new Point(position.X - 1, position.Y);  
                        break;
                case 3:
                            ghostMove = new Point(position.X, position.Y + 1);
                        break;
                    default:
                             ghostMove = new Point(position.X, position.Y - 1);
                        break;
                }
                return ghostMove;  
            //I dont know how to test you
            //Note: unable to test because returning a object not a int. 
        }

        //sets up the 2d array 
        public static string MakeArray(int xStudent, int yStudent, int xGhost, int yGhost)
        {
            string report = "";
            string[,] rooms = new string[10, 10];
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    rooms[row, column] = ".";
                }
            }

            rooms[xStudent, yStudent] = "S";
            rooms[xGhost, yGhost] = "g";

            for (int row = 0; row < rooms.GetLength(0); row++)
            {
                for (int column = 0; column < rooms.GetLength(1); column++)
                {
                    report += rooms[row, column] + " ";
                }
                report += "\n";
            }
            return report;

            // Before update to be able to test
            //for (int row = 0; row < rooms.GetLength(0); row++)
            //{
            //    for (int column = 0; column < rooms.GetLength(1); column++)
            //    {
            //        Console.Write(rooms[row, column] + " ");
            //    }
            //    Console.WriteLine();



            }
    }
}
