using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColoringRectangle {
    public int chooseDisks(int width, int height, int[] red, int[] blue)
    {
        int i;
        int ma = 9999999;
        int res = ma;
        int count = 0;
        double nokori = width;
        Array.Sort(red);
        Array.Sort(blue);
        Array.Reverse(red);
        Array.Reverse(blue);
        for (i = 0; ; i++)
        {
            if (red.Length <= i) break;
            if (red[i] < height) break;
            count++;
            nokori -= Math.Sqrt(Math.Pow(red[i], 2) - Math.Pow(height, 2) + 1e-9);
            if (nokori < 0) { res = Math.Min(count, res); break; }

            if (blue.Length <= i) break;
            if (blue[i] < height) break;
            count++;
            nokori -= Math.Sqrt(Math.Pow(blue[i], 2) - Math.Pow(height, 2) + 1e-9);
            if (nokori < 0) { res = Math.Min(count, res); break; }
        }
        count = 0;
        nokori = width;
        for (i = 0; ; i++)
        {
            if (blue.Length <= i) break;
            if (blue[i] < height) break;
            count++;
            nokori -= Math.Sqrt(Math.Pow(blue[i], 2) - Math.Pow(height, 2) + 1e-9);
            if (nokori < 0) { res = Math.Min(count, res); break; }

            if (red.Length <= i) break;
            if (red[i] < height) break;
            count++;
            nokori -= Math.Sqrt(Math.Pow(red[i], 2) - Math.Pow(height, 2) + 1e-9);
            if (nokori < 0) { res = Math.Min(count, res); break; }
        }

        if (res == ma) return -1;
        else return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
