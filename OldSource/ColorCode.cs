using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorCode {
    public long getOhms(string[] code)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string[] st = new string[10] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        long res;
        int i;
        for (i = 0; i < 10; i++) dic[st[i]] = i;
        res = dic[code[0]] * 10 + dic[code[1]];
        for (i = 0; i < dic[code[2]]; i++) res *= 10;
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{ "yellow", "violet", "red" }; long Arg1 = 4700l; verify_case(0, Arg1, getOhms(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{ "orange", "red", "blue" }; long Arg1 = 32000000l; verify_case(1, Arg1, getOhms(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{ "white", "white", "white" }; long Arg1 = 99000000000l; verify_case(2, Arg1, getOhms(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColorCode ___test = new ColorCode();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
