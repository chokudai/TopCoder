using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubeWalking {
    int[] vx = { 1, 0, -1, 0 };
    int[] vy = { 0, 1, 0, -1 };
    int nowv = 0;
    int x, y;

    public string finalPosition(string movement)
    {
        int i; x = 1; y = 1;
        for (i = 0; i < movement.Length; i++)
        {
            if (movement[i] == 'L')
            {
                nowv = (nowv + 3) % 4;
            }
            else if (movement[i] == 'R')
            {
                nowv = (nowv + 1) % 4;
            }
            else
            {
                x = (x + vx[nowv] + 3) % 3;
                y = (y + vy[nowv] + 3) % 3;
            }
        }
        if (x == 1 && y == 1) return "GREEN";
        else if (x == 1 || y == 1) return "BLUE";
        return "RED";
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
