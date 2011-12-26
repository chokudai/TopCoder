using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorfulRabbits {
    public int getMinimum(int[] replies)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int i;
        for (i = 0; i < replies.Length; i++) dic[replies[i] + 1] = 0;
        for (i = 0; i < replies.Length; i++) dic[replies[i] + 1]++;
        int res = 0;
        foreach(KeyValuePair<int,int> k in dic)
            res += ((k.Key + k.Value - 1) / k.Key) * k.Key;
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{ 1, 1, 2, 2 }
; int Arg1 = 5; verify_case(0, Arg1, getMinimum(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 0 }
; int Arg1 = 1; verify_case(1, Arg1, getMinimum(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 2, 2, 44, 2, 2, 2, 444, 2, 2 }
; int Arg1 = 499; verify_case(2, Arg1, getMinimum(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColorfulRabbits ___test = new ColorfulRabbits();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
