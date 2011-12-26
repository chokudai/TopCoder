using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Zoo {
    public long theCount(int[] answers)
    {
        Array.Sort(answers);
        int i;
        int zero = 0;
        for (i = 0; i < answers.Length; i++) if (answers[i] == 0) zero++;
        if (zero == 0) return 0;
        else if (zero == 1)
        {
            for (i = 0; i < answers.Length; i++) if (i != answers[i]) return 0;
            return 2;
        }
        else if (zero == 2)
        {
            long res = 2;
            int MAX = 50;
            int[] count = new int[MAX];
            for (i = 0; i < answers.Length; i++) count[answers[i]]++;
            for (i = 1; i < MAX; i++)
            {
                if (count[i] > count[i - 1]) return 0;
                if (count[i] == 2 || (count[i] == 1 && count[i - 1] == 2)) res *= 2;
            }
            return res;
        }
        else return 0;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
