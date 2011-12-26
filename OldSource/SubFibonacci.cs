using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SubFibonacci {

    int[] memoa;
    int[] memob;

    public int maxElements(int[] S)
    {
        memoa = new int[50];
        memob = new int[50];
        int i, j, k, l;
        memoa[0] = 1;
        memoa[1] = 0;
        memob[0] = 0;
        memob[1] = 1;
        for (i = 2; i < 50; i++)
        {
            memoa[i] = memoa[i - 2] + memoa[i - 1];
            memob[i] = memob[i - 2] + memob[i - 1];
            //Console.WriteLine(memoa[i] + " " + memob[i]);
        }
        Array.Sort(S);
        int len = S.Length;
        int res = Math.Min(4, S.Length);

        Dictionary<int, bool> dic;

        for (i = 0; i <= len; i++)
        {
            int a = Math.Min(2, i);
            for (j = 0; j < i; j++)
            {
                for (k = j + 1; k < i; k++)
                {
                    for (l = 1; ; l++)
                    {
                        long need = S[k] - memoa[l] * S[j];
                        if (need < 0) break;
                        if (need % memob[l] != 0) continue;
                        dic = makelist(S[j], (int)(need / memob[l]));
                        a = Math.Max(a, getnum(0, i, dic, S));
                    }
                    dic = makelist(S[k], S[j]);
                    a = Math.Max(a, getnum(0, i, dic, S));
                }
            }

            int b = Math.Min(2, len - i);
            for (j = i; j < len; j++)
            {
                for (k = j + 1; k < len; k++)
                {
                    for (l = 1; ; l++)
                    {
                        long need = S[k] - memoa[l] * S[j];
                        if (need < 0) break;
                        if (need % memob[l] != 0) continue;
                        dic = makelist(S[j], (int)(need / memob[l]));
                        b = Math.Max(b, getnum(i, len, dic, S));
                    }
                    dic = makelist(S[k], S[j]);
                    b = Math.Max(b, getnum(i, len, dic, S));
                }
            }
            //Console.WriteLine(i + " " + a + " " + b);
            res = Math.Max(res, a + b);
        }
        return res;
    }

    int getnum(int a, int b, Dictionary<int, bool> dic, int[] ar)
    {
        int i;
        int count = 0;
        for (i = a; i < b; i++) if (dic.ContainsKey(ar[i])) count++;
        return count;
    }

    Dictionary<int, bool> makelist(int a, int b)
    {
        //if (a == 1 && b == 2) Console.WriteLine("ok");
        Dictionary<int, bool> dic = new Dictionary<int, bool>();
        int MAX = 100000000;
        dic[a] = true;
        dic[b] = true;
        while (b < MAX)
        {
            int c = a + b;
            dic[c] = true;
            a = b;
            b = c;
            //Console.Write(c + " ");
        }
        //Console.WriteLine();
        return dic;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
