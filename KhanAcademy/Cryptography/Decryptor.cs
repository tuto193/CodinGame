using System;

namespace Decryptor {
    class Program {
        static string SimpleDecrypt( string cypher, string smessage ) {
            string message = "";
            for( int i = 0; i < smessage.Length; i++ ) {
                int j = i % cypher.Length;
                int move = cypher[j];
                int pad = 'z';
                int letter = (smessage[i] + move) % pad;
                if( letter < 'a' ) {
                    letter += 'a';
                }
                char nLetter = letter;
                message += mLetter;
            }
            return message;
        }
        static void Main( string[] args ) {
            string cypher = Console.ReadLine();

        }
    }
}