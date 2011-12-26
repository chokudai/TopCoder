using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SumRectangle {
    public int getCorner(int[] leftColumn, int[] topRow)
    {
        int i, j;
        int[,] res = new int[leftColumn.Length, topRow.Length];
        for (i = 0; i < leftColumn.Length; i++)
        {
            res[i, 0] = leftColumn[i];
        }
        for (i = 0; i < topRow.Length; i++)
        {
            res[0, i] = topRow[i];
        }

        for (i = 1; i < leftColumn.Length; i++)
        {
            for (j = 1; j < topRow.Length; j++)
            {
                res[i, j] = res[i - 1, j - 1] - res[i - 1, j] - res[i, j - 1];
            }
        }
        return res[leftColumn.Length - 1, topRow.Length - 1];
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
