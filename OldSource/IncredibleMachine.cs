using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IncredibleMachine {
    public double gravitationalAcceleration(int[] x, int[] y, int T)
    {
        int loop, i, j;
        int len = x.Length - 1;
        double ming = 0;
        double maxg = 1000000000;
        for (loop = 0; loop < 2000; loop++)
        {
            double time = 0;
            double v0 = 0;
            double nowg = (ming + maxg) / 2;
            for (i = 0; i < len; i++)
            {
                int X = x[i + 1] - x[i];
                int Y = y[i] - y[i+1];
                double d = Math.Sqrt(X * X + Y * Y);
                double nextg = nowg * Y / d;
                double nexttime = (-v0 + Math.Sqrt(v0 * v0 + 2 * nextg * d)) / nextg;
                //Console.WriteLine("nexttime: " + Math.Sqrt(v0 * v0));
                time += nexttime;
                v0 += nexttime * nextg;
            }
            //Console.WriteLine("g: " + nowg + " time: " + time);
            if (time > T) ming = nowg;
            else maxg = nowg;
        }
        return ming;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
