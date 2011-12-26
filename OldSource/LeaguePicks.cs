using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LeaguePicks {
    public int[] returnPicks(int position, int friends, int picks)
    {
        List<int> res = new List<int>();
        for (int i = 0; i < picks; i+=friends*2)
        {
            if (i + position <= picks) res.Add(i + position);
            if (i + friends * 2 - position + 1 <= picks) res.Add(i + friends * 2 - position + 1);
        }
        return res.ToArray();
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int[] Expected, int[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(int[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (int o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(int[] a, int[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { int Arg0 = 3; int Arg1 = 6; int Arg2 = 15; int[] Arg3 = new int[]{ 3,  10,  15 }; verify_case(0, Arg3, returnPicks(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 10; int[] Arg3 = new int[]{ 1,  2,  3,  4,  5,  6,  7,  8,  9,  10 }; verify_case(1, Arg3, returnPicks(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 2; int Arg2 = 39; int[] Arg3 = new int[]{ 1,  4,  5,  8,  9,  12,  13,  16,  17,  20,  21,  24,  25,  28,  29,  32,  33,  36,  37 }; verify_case(2, Arg3, returnPicks(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 5; int Arg1 = 11; int Arg2 = 100; int[] Arg3 = new int[]{ 5,  18,  27,  40,  49,  62,  71,  84,  93 }; verify_case(3, Arg3, returnPicks(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LeaguePicks ___test = new LeaguePicks();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
