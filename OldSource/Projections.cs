using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Projections {
    public int[] count(string front, string right)
    {
        int i;
        int a = 0, b = 0;
        for (i = 0; i < front.Length; i++) if (front[i] == 'x') a++;
        for (i = 0; i < right.Length; i++) if (right[i] == 'x') b++;
        return new int[] { Math.Max(a,b), a*b };
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
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
	private void test_case_0() { string Arg0 = "x"; string Arg1 = "x"; int[] Arg2 = new int[]{1, 1 }; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "x."; string Arg1 = ".x"; int[] Arg2 = new int[]{1, 1 }; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "xxxx"; string Arg1 = "x..x"; int[] Arg2 = new int[]{4, 8 }; verify_case(2, Arg2, count(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "x.x.x.x"; string Arg1 = "x.x.x.x"; int[] Arg2 = new int[]{4, 16 }; verify_case(3, Arg2, count(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "x...xx..x.xxx..x.xx."; string Arg1 = ".xx..xxx.xx."; int[] Arg2 = new int[]{10, 70 }; verify_case(4, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Projections ___test = new Projections();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
