using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ErdosNumber {
    public string[] calculateNumbers(string[] publications)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string[] st = new string[104];
        dic["ERDOS"] = 0;
        st[0] = "ERDOS";
        int count = 1;
        int i, j,k;
        int[,] len = new int[104, 104];
        for (i = 0; i < 103; i++)
        {
            for (j = 0; j < 103; j++)
            {
                len[i, j] = 1000000;
            }
            len[i, i] = 0;
        }


        for (i = 0; i < publications.Length; i++)
        {
            string[] slib = publications[i].Split(' ');
            for (j = 0; j < slib.Length; j++)
            {
                if (!dic.ContainsKey(slib[j])) { st[count] = slib[j]; dic[slib[j]] = count++; }
                for (k = 0; k < slib.Length; k++)
                {
                    if (slib[j] == slib[k]) continue;
                    if (!dic.ContainsKey(slib[k])) { st[count] = slib[k]; dic[slib[k]] = count++; }
                    len[dic[slib[j]], dic[slib[k]]] = 1;
                    len[dic[slib[k]], dic[slib[j]]] = 1;
                }
            }
        }
        for (i = 0; i < count; i++) for (j = 0; j < count; j++) for (k = 0; k < count; k++)
                {
                    len[i, j] = Math.Min(len[i, j], len[i, k] + len[k, j]);
                }
        string[] result = new string[count];
        for (i = 0; i < count; i++)
        {
            if (len[i, 0] < 100000) result[i] = st[i] + " " + len[i, 0];
            else result[i] = st[i];
        }
        Array.Sort(result);
        return result;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
