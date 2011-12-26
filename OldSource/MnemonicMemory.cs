using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MnemonicMemory {
    public string getPhrase(string number, string[] dictionary)
    {
        Array.Sort(dictionary, String.CompareOrdinal);
        int i, j;
        bool[] flag = new bool[dictionary.Length];
        string res = "";
        for (i = 0; i < number.Length; i++)
        {
            int num = number[i] - '0';
            for (j = 0; j < dictionary.Length; j++)
            {
                if (!flag[j] && dictionary[j].Length == num)
                {
                    res += dictionary[j];
                    flag[j] = true;
                    if (i != number.Length - 1) res += " ";
                    break;
                }
            }
        }
        return res;
    }

}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
