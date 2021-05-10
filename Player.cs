using System;
using System.Collections.Generic;
using static System.Console;

namespace TicTacToe
{
    class Player
    {
  
        //List to track the players Moves
        public List<int> moveList = new List<int>();
        public string Symbol {get; set;}

        public Player(string symbol){
            Symbol = symbol;

        }


        //Method that takes the players input an updates the playfield
        public virtual bool  PlayerInput(PlayField playField, int input)
        {
            //check if input is in the range from 1 to 9
            if(input < 1 || input > 9){
                return false;
            //check if the player inputs an already occupied field
            } else if (playField.occupied.Contains(input)){
                Write($"{input} is allready occupied! ");
                return false;
            //if the Input is valid, update the Canvas and occupied List. Also add the integer to the movelist of the player to track the Wincondition.
            }else
            {
                playField.Canvas[input -1] = Symbol;
                playField.occupied.Add(input);
                this.moveList.Add(input);
                return true;
            }

        }


        public bool WinCheck()
        {
            if(moveList.Count >= 3){
          
                if(moveList.Contains(1) && moveList.Contains(2) && moveList.Contains(3))
                {
                    return true;
                }
                else if (moveList.Contains(1) && moveList.Contains(4) && moveList.Contains(7)){
                    return true;
                }
                else if (moveList.Contains(1) && moveList.Contains(5) && moveList.Contains(9)){
                    return true;
                }
                else if (moveList.Contains(4) && moveList.Contains(5) && moveList.Contains(6)){
                    return true;
                }
                else if (moveList.Contains(7) && moveList.Contains(8) && moveList.Contains(9)){
                    return true;
                }
                else if (moveList.Contains(2) && moveList.Contains(5) && moveList.Contains(8)){
                    return true;
                }
                else if (moveList.Contains(3) && moveList.Contains(6) && moveList.Contains(9)){
                    return true;
                }
                else if (moveList.Contains(7) && moveList.Contains(5) && moveList.Contains(3)){
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else {return false;}
        }   
    }
}