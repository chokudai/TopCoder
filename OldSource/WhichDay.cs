using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WhichDay {
    public string getDay(string[] notOnThisDay)
    {
        string[] st = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        int i;
        Dictionary<string, int> dic = new Dictionary<string,int>();
        for (i = 0; i < 7; i++) dic[st[i]] = i;
        int res = 21;
        foreach (string s in notOnThisDay) res -= dic[s];
        return st[res];
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
