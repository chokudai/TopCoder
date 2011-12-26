using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DoorsGame {
    public int determineOutcome(string doors, int trophy)
    {
        bool[,] need = new bool[16, 2];
        int i;
        for (i = 0; i < doors.Length; i++)
        {
            if (i < trophy) need[(int)(doors[i] - 'A'), 0] = true;
            else need[(int)(doors[i] - 'A'), 1] = true;
        }
        int a = 0;
        int b = 0;
        int c = 0;
        for (i = 0; i < 16; i++)
        {
            if (need[i, 0] && need[i, 1]) c++;
            else if (need[i, 0] && !need[i, 1]) a++;
            else if (!need[i, 0] && need[i, 1]) b++;
        }
        int count = 0;
        while (true)
        {
            if (a == 0 && b == 0 && c == 0) return 0;
            if (a == 0 && c == 0) return count;
            if (b == 0 && c == 0) return -count;
            if (a != 0) a--; else c--; count++;
            if (a == 0 && b == 0 && c == 0) return 0;
            if (a == 0 && c == 0) return count;
            if (b == 0 && c == 0) return -count;
            if (b != 0) b--; else c--; count++;
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
