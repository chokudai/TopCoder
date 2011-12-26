using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RoughStrings {
    public int minRoughness(string s, int nn)
    {
        int[] num = new int[26];
        foreach (char c in s) num[c - 'a']++;
        int res = 999;
        int[] count2 = new int[200];
        foreach (int a in num) count2[a]++;
        int i,j;
        for (i = 0; i < 100; i++)
        {
            int[] count = (int[])count2.Clone();
            int n = nn;
            int down = i + 1;
            int up = 100;
            for (j = 1; j < down; j++) n -= count[j] * j;

            while (n >= 0)
            {
                if (down == up) break;
                if (count[up] > n) break;
                n -= count[up];
                count[up - 1] += count[up];
                up--;
            }
            if (n >= 0)
            {
                res = Math.Min(up - down, res);
                //Console.WriteLine(down + " " + up);
            }
        }
        return res;


    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "aaaaabbc"; int Arg1 = 1; int Arg2 = 3; verify_case(0, Arg2, minRoughness(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "aaaabbbbc"; int Arg1 = 5; int Arg2 = 0; verify_case(1, Arg2, minRoughness(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "veryeviltestcase"; int Arg1 = 1; int Arg2 = 2; verify_case(2, Arg2, minRoughness(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "gggggggooooooodddddddllllllluuuuuuuccckkk"; int Arg1 = 5; int Arg2 = 3; verify_case(3, Arg2, minRoughness(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz"; int Arg1 = 17; int Arg2 = 0; verify_case(4, Arg2, minRoughness(Arg0, Arg1)); }
	private void test_case_5() { string Arg0 = "bbbccca"; int Arg1 = 2; int Arg2 = 0; verify_case(5, Arg2, minRoughness(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RoughStrings ___test = new RoughStrings();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
