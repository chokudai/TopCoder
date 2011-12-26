using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RPG {
    public int[] dieRolls(string[] dice)
    {
        int[] res = new int[3];
        foreach (string s in dice)
        {
            string[] st = s.Split('d');
            int num = int.Parse(st[0]);
            int max = int.Parse(st[1]);
            res[0] += num;
            res[1] += num * max;
            res[2] += (max + 1) * num;
        }
        res[2] /= 2;
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"3d6"}; int[] Arg1 = new int[]{ 3,  18,  10 }; verify_case(0, Arg1, dieRolls(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"3d4","1d6"}; int[] Arg1 = new int[]{ 4,  18,  11 }; verify_case(1, Arg1, dieRolls(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"6d5","10d10","10d20"}; int[] Arg1 = new int[]{ 26,  330,  178 }; verify_case(2, Arg1, dieRolls(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1d2","2d2","4d2","6d2","8d2"}; int[] Arg1 = new int[]{ 21,  42,  31 }; verify_case(3, Arg1, dieRolls(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RPG ___test = new RPG();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
