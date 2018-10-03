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
            int m = s[i] - '0';
            sum += m;
        }
        sum += n1;
        return sum;
    }
    static void Main(string[] args)
    {
        int r1 = int.Parse(Console.ReadLine());
        int check = r1;
        bool found = false;
            int nCheck = check;
        while( check > 0 && !found ) {
            while( nCheck <= r1 && !found ) {
                nCheck = GetFlow( nCheck );
                if( nCheck == r1 ) {
                    Console.WriteLine("YES");
                    found = true;
                }
            }
            check--;
            if( check == 0 && !found ) {
                Console.WriteLine("NO");
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}