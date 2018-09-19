using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    // We will check in reverse
    public static int GetFlow( int n1 ) {
        string s = n1.ToString();
        int sum = 0;
        for( int i = 0; i < s.Length; i++ ) {
            sum += s[i];
        }
        sum += n1;
        return sum;
    }
    static void Main(string[] args)
    {
        int r1 = int.Parse(Console.ReadLine());
        int check = r1;
        while( check > 0 ) {
            int nCheck = check;
            while( nCheck <= r1 ) {
                nCheck = GetFlow( nCheck );
                if( nCheck == r1 ) {
                    Console.WriteLine("YES");
                }
            }
            check--;
            if( check == 0 ) {
                Console.WriteLine("NO");
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}