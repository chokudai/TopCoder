using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBoringStoreDivOne {

    bool compareString(string a, string b)
    {
        if (a.Length != b.Length) return a.Length > b.Length;
        else return string.CompareOrdinal(a, b) < 0;
    }

    public string find(string J, string B)
    {
        string[] sss = new string[] { "Aa", "bB", "Cc", "dD" };
        Array.Sort(sss);
        for (int ii = 0; ii < sss.Length; ii++)
        {
            for (int jj = 0; jj < sss.Length - 1; jj++)
            {
                if (compareString(sss[jj+1],sss[jj]))//sss[jj].CompareTo(sss[jj + 1]) > 0)
                {
                    string stst = sss[jj];
                    sss[jj] = sss[jj + 1];
                    sss[jj + 1] = stst;
                }
            }
        }
        foreach (string ssss in sss) Console.WriteLine(ssss);
        Dictionary<string, string> dicj = new Dictionary<string, string>();
        Dictionary<string, string> dicb = new Dictionary<string, string>();
        //Dictionary<string, string> dicj2 = new Dictionary<string, string>();
        //Dictionary<string, string> dicb2 = new Dictionary<string, string>();
        int i, j, k, l;
        for (i = 0; i < J.Length; i++)
        {
            for (j = i + 1; j <= J.Length; j++)
            {
                string aa = J.Substring(i, j - i);
                for (k = j; k < J.Length; k++)
                {
                    for (l = k + 1; l <= J.Length; l++)
                    {
                        string bb = J.Substring(k, l - k);
                        string a, b;
                        if (compareString(aa, bb))
                        {
                            a = aa;
                            b = bb;
                        }
                        else
                        {
                            a = bb;
                            b = aa;
                        }

                        if (a.Substring(0, b.Length) == b)
                        {
                            string amari = a.Substring(b.Length, a.Length - b.Length);
                            if (dicj.ContainsKey(amari))
                            {
                                string s = dicj[amari];
                                if (compareString(a, s))
                                {
                                    dicj[amari] = a;
                                }
                                
                            }
                            else dicj[amari] = a;
                        }
                    }
                }
            }
        }

        for (i = 0; i < B.Length; i++)
        {
            for (j = i + 1; j <= B.Length; j++)
            {
                string aa = B.Substring(i, j - i);
                for (k = j; k < B.Length; k++)
                {
                    for (l = k + 1; l <= B.Length; l++)
                    {
                        string bb = B.Substring(k, l - k);
                        string a, b;
                        if (compareString(aa, bb))
                        {
                            a = aa;
                            b = bb;
                        }
                        else
                        {
                            a = bb;
                            b = aa;
                        }
                        if (a.Substring(a.Length-b.Length, b.Length) == b)
                        {
                            string amari = a.Substring(0, a.Length - b.Length);
                            if (dicb.ContainsKey(amari))
                            {
                                string s = dicb[amari];
                                if (compareString(a, s))
                                {
                                    dicb[amari] = a;
                                }

                            }
                            else dicb[amari] = a;
                        }
                    }
                }
            }
        }
        string res = "";
        foreach (KeyValuePair<string, string> a in dicj)
        {
            string key = a.Key;
            string s1 = a.Value;
            //Console.WriteLine(key + " " + s1);
            if (dicb.ContainsKey(key))
            {
                string s2 = dicb[key];
                string ss = s1 + s2.Substring(key.Length);
                if(compareString(ss,res)) res = ss;
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "StoreOfJohn"; string Arg1 = "StoreOfBrus"; string Arg2 = "or"; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "JohnAndJohn"; string Arg1 = "John"; string Arg2 = ""; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "JohnLikesToPlayGames"; string Arg1 = "BrusAlsoLikesToPlayGames"; string Arg2 = "esToPlayGames"; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "abacaba"; string Arg1 = "abacabadabacaba"; string Arg2 = "abaabacaba"; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBoringStoreDivOne ___test = new TheBoringStoreDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
