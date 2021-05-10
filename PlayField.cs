using System;
using System.Collections.Generic;
using static System.Console;

namespace TicTacToe
{
    class PlayField 
    {
        //Canvas List
        List<string> n = new List<string>();
        public List<string> Canvas {get{return n;}set{n = value;}}
        public List<int> occupied = new List<int>();


        //Constructor which populates the Canvas with " " (empty spaces)
        public PlayField() 
        {
            for(int i = 0; i <= 8; i++)
            {
                n.Add(" ");
            }
        }
        //Method to draw the PlayingField
        public void DrawTable()
        {
            WriteLine($" {n[0]} | {n[1]} | {n[2]} ");
            WriteLine("-----------");
            WriteLine($" {n[3]} | {n[4]} | {n[5]} ");
            WriteLine("-----------");
            WriteLine($" {n[6]} | {n[7]} | {n[8]} ");
        }
    }
}