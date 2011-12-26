using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BlackWhiteMagic {
    public int count(string creatures)
    {
        int w = 0;
        int len = creatures.Length;
        int i;
        for (i = 0; i < len; i++) if (creatures[i] == 'W') w++;
        int res = 0;
        for (i = 0; i < w; i++) if (creatures[i] != 'W') res++;
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
