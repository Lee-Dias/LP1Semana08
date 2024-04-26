using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Asc { get; } 
        public CompareByName (bool comp) 
        {
            Asc = comp;
        }

        public int Compare (Player player1, Player player2) 
        {
            int c; 
            
            if (Asc)          
            {
                c = player1.Name.CompareTo (player2.Name); 
            }
            else
            {
                c = player2.Name.CompareTo (player1.Name);
            }
            return c;          
        }
    }
}