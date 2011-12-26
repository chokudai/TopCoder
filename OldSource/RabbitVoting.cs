using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitVoting {
    public string getWinner(string[] names, string[] votes)
    {
        int i, j;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (i = 0; i < names.Length; i++) dic[names[i]] = 0;
        for (i = 0; i < votes.Length; i++) if(names[i]!=votes[i])dic[votes[i]]++;
        int res = -1;
        int max = -1;
        for (i = 0; i < names.Length; i++)
        {
            if (dic[names[i]] > max)
            {
                max = dic[names[i]];
                res = i;
            }
            else if (dic[names[i]] ==max)
            {
                max = dic[names[i]];
                res = -1;
            }
        }
        if (res == -1) return "";
        return names[res];
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
