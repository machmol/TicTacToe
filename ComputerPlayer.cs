using System;
using System.Collections.Generic;
namespace TicTacToe
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(string symbol) : base(symbol)
        {
        }
        //Generates Random Number and draws it on the Canvas.
        public  void PlayerInput(PlayField playField){
            Random rand = new Random();
            int index;
            do{
                index = rand.Next(1,9);
            //Updates the canvas and adds the move to the occupied LIst. Also adds the index to the Computers Movelist to track its Wincondition.
            }while(playField.occupied.Contains(index));
                playField.Canvas[index -1] = Symbol;
                playField.occupied.Add(index);
                this.moveList.Add(index);
                Console.WriteLine("The computer chose: {0}", index);
        }
    }

}