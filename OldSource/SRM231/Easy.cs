using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stitch
{
    public string[] stitch(string[] A, string[] B, int overlap)
    {
        int i, j;
        int len = A.Length;
        string[] res = new string[len];
        for (i = 0; i < len; i++)
        {
            string a = A[i] + B[i].Substring(overlap, B[i].Length - overlap);
            string b = A[i].Substring(0, A[i].Length - overlap) + B[i];
            string c = "";
            int s = A[i].Length - overlap;
            int l = a.Length;
            for (j = 0; j < l; j++)
            {
                //((overlap+1-i)*a+(i*b))/(overlap+1)
                c = c + (char)(((((int)a[j] * (overlap + s - j)) + (int)b[j] * (-s + j + 1)) * 2 / (overlap + 1) + 1) / 2);
            }
            res[i] = c;
        }
        return res;
    }
}
