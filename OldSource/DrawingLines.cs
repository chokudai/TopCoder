using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DrawingLines {
    public double countLineCrossings(int n, int[] startDot, int[] endDot)
    {
        double res = 0;
        int len = startDot.Length;
        int nokori = n - len;
        int i, j;
        for (i = 1; i < nokori; i++)
        {
            res += nokori - i;
        }
        res /= 2;
        //Console.WriteLine(res);
        for (i = 0; i < len; i++)
        {
            startDot[i]--;
            endDot[i]--;
        }
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                if ((startDot[i] > startDot[j]) && (endDot[i] < endDot[j])) res += 1;
                if ((startDot[i] < startDot[j]) && (endDot[i] > endDot[j])) res += 1;
            }
        }
        //Console.WriteLine(res);
        int[] startAr = (int[])startDot.Clone();
        int[] endAr = (int[])endDot.Clone();
        Array.Sort(startAr);
        Array.Sort(endAr);
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (startDot[j] == startAr[i])
                {
                    startDot[j] -= i + 1;
                    break;
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (endDot[j] == endAr[i])
                {
                    endDot[j] -= i + 1;
                    break;
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            startDot[i]++;
            endDot[i]++;
        }
        for (i = 0; i < len; i++)
        {
            double startleft = startDot[i];
            double startright = nokori - startDot[i];
            double endleft = endDot[i];
            double endright = nokori - endDot[i];
            //Console.WriteLine(startleft + " " + startright + " " + endleft + " " + endright);
            res += startright * endleft / nokori;
            res += startleft * endright / nokori;
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
