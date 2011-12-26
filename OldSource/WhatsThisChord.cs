using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WhatsThisChord {
    public string classify(int[] chord)
    {
        //C, C#, D, D#, E, F, F#, G, G#, A, A#, B.
        string[] st = new string[12] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        //E, A, D, G, B, E
        int[] start = new int[6] { 4, 9, 2, 7, 11, 4 };
        int i, j;
        bool[] memo = new bool[12];
        int count = 0;
        for (i = 0; i < 6; i++)
        {
            if (chord[i] != -1) if (!memo[(start[i] + chord[i]) % 12])
                {
                    memo[(start[i] + chord[i]) % 12] = true; count++;
                }
        }
        if (count != 3) return "";
        for (i = 0; i < 12; i++)
        {
            if (memo[i] && memo[(i + 3) % 12] && memo[(i + 7) % 12]) return string.Concat(st[i], " Minor");
            //4,3
            if (memo[i] && memo[(i + 4) % 12] && memo[(i + 7) % 12]) return string.Concat(st[i], " Major");
            //3,4
        }
        return "";
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
