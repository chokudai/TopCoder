using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TimeTravellingGardener {
    public int determineUsage(int[] distance, int[] height)
    {
        int i, j, k;
        int res = distance.Length;
        double EPS = 1e-9;
        int[] pos = new int[height.Length];
        for (i = 0; i < distance.Length; i++) pos[i + 1] = pos[i] + distance[i];

        for (i = 0; i < height.Length; i++)
        {
            for (j = i + 1; j < height.Length; j++)
            {
                int count = 0;
                for (k = 0; k < height.Length; k++)
                {
                    double h = height[i] + (height[j] - height[i]) * (double)(pos[i] - pos[k]) / (pos[i] - pos[j]);
                    if (Math.Abs(height[k] - h) > EPS)
                    {
                        if (h > height[k]) break;
                        else if (h < -EPS) break;
                        count++;
                    }
                }
                if (k == height.Length)
                {
                    res = Math.Min(count, res);
                }
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
