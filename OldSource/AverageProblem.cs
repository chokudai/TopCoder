using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AverageProblem {
    public int numberOfParticipants(string[] m)
    {
        int i, j;
        string[] marks;
        List<string> li = new List<string>();
        for (i = 0; i < m.Length; i++)
        {
            string[] st = m[i].Split(' ');
            foreach (string sss in st) li.Add(sss);
        }
        marks = li.ToArray();
        int len = marks.Length;
        long[] num = new long[marks.Length];
        for (i = 0; i < len; i++) num[i] = (int)(Double.Parse(marks[i]) * 1000 + 1e-9);
        for (i = 1; i < 10000; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (num[j] * i % 1000 == 0) continue;
                if (((num[j] * i / 1000) + 1) * 1000 / i != num[j]) break;
            }
            if (j == len) return i;
        }
        return -1;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
