using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IOIString {
    public int countIOIs(string[] mas)
    {
        string mask = "";
        foreach (string s in mas) mask = mask + s;
        long mod = 1000000007;
        int i,j;
        long[] res = new long[4];
        long result = 1;
        List<string> notioi = new List<string>();
        notioi.Add("");
        int count = 0;
        for (i = 0; i < mask.Length; i+=1)
        {
            List<string> next = new List<string>();
            if (mask[i] == '?') count++;
            foreach (string ss in notioi)
            {
                int len = ss.Length;
                if (mask[i] == 'I' || mask[i] == '?')
                {
                    for (j = 1; len - 2 * j >= 0; j++)
                    {
                        if (ss[len - j] == 'O' && ss[len - 2 * j] == 'I') break;
                    }
                    if (len - 2 * j < 0) next.Add(ss + "I");
                }
                if (mask[i] == 'O' || mask[i] == '?')
                {
                    next.Add(ss + "O");
                }
            }
            notioi.Clear();
            foreach (string s in next) notioi.Add(s);
        }
        for (i = 0; i < count; i++)
        {

            result *= 2;
            result %= mod;
        }
        result -= notioi.Count;
        result += mod;
        result %= mod;
        return (int)result;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"IO?"}; int Arg1 = 1; verify_case(0, Arg1, countIOIs(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"????"}; int Arg1 = 4; verify_case(1, Arg1, countIOIs(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"?II"}; int Arg1 = 0; verify_case(2, Arg1, countIOIs(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"I??O??I"}; int Arg1 = 16; verify_case(3, Arg1, countIOIs(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"???I???????O???","???????????O??IO????????I???"}; int Arg1 = 438952513; verify_case(4, Arg1, countIOIs(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
IOIString ___test = new IOIString();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
