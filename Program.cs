using System;
using static System.Console;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("x");
            PlayField playField = new PlayField();
            
            int round = 0;
           int playmode;
            //Let the player choose the playmode
            do{
                WriteLine("Press: \"1\" for Singleplayer. Press \"2\" for Multiplayer");
            }while(!int.TryParse(ReadLine(), out playmode) && (playmode != 1 || playmode !=2));
            //Code for Singe Player Mode
            if(playmode == 1){
                ComputerPlayer computerPlayer = new ComputerPlayer("o");
                //Output Playing Field for the first Time
                WriteLine("===========");
                playField.DrawTable();
                while(round < 9)
                    {
                        
                        //Try to get player ones input till he enters a valid integer in the range form 1 to 9;
                        do
                        {
                            Write("Please enter a number from \"1\" to \"9\": ");
                        }while(!int.TryParse(ReadLine(), out int  playerOneInput) || !playerOne.PlayerInput(playField, playerOneInput));
                        round++;
                        playField.DrawTable();

                        // Check if Player Ones Input matches one of the Winconditions
                        if (playerOne.WinCheck())
                        {
                            WriteLine("Player One WON!");
                            break;
                        } else if (round == 9)
                        {
                            WriteLine("It's a DRAW!");
                            break;
                        }
                        // get the Computers Input
                        computerPlayer.PlayerInput(playField);
                        round++;
                        playField.DrawTable();
                        // check if the Computer matches the Wincondition
                        if (computerPlayer.WinCheck())
                        {
                            WriteLine("The computer WON!");
                            break;
                        }
                    }
                ReadLine();
            }
            else if (playmode == 2)
            {
                Player playerTwo = new Player("o");
                //Output Playing Field for the first Time
                WriteLine("===========");
                playField.DrawTable();
                while(round < 9)
                    {
                        //Try to get player ones input till he enters a valid integer in the range form 0 to 8;
                        do
                        {
                            Write("Please enter a number from \"1\" to \"9\": ");
                        }while(!int.TryParse(ReadLine(), out int  playerOneInput) || !playerOne.PlayerInput(playField, playerOneInput));
                        round++;
                        playField.DrawTable();

                        // Check if Player Ones Input matches one of the Winconditions
                        if (playerOne.WinCheck())
                        {
                            WriteLine("=== Player One WON! ===");
                            break;
                        } else if (round == 9)
                        {
                            WriteLine("=== It's a DRAW! ===");
                            break;
                        }
                        //Try to get Player Two's Input, and check if it is a valid integer in the range from 1 to 9.
                        do
                        {
                            Write("Please enter a number from \"1\" to \"9\": ");
                        }while(!int.TryParse(ReadLine(), out int  playerTwoInput) || !playerTwo.PlayerInput(playField, playerTwoInput));
                        round++;
                        playField.DrawTable();
                        // check if PlayerTwo matches the Wincondition
                        if (playerTwo.WinCheck())
                        {
                            WriteLine("=== Player Two WON! ===");
                            break;
                        }
                    }
                ReadLine();
            }
            
            

        }
    }


}
