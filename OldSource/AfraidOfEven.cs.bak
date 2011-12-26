using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AfraidOfEven {
    int max = (int)1e7;
    public int[] restoreProgression(int[] seq)
    {
        int i;
        int len = seq.Length;
        for (int a = 1; a * seq[0] < max; a *= 2)
        {
            int[] res = new int[len];
            res[0] = a * seq[0];
            for (int b = 1; b * seq[1] < max; b *= 2)
            {
                res[1] = b * seq[1];
                for (i = 2; i < len; i++)
                {
                    res[i] = (int)(res[1] * (long)i - res[0] * (long)(i - 1));
                    if (!make(res[i], seq[i])) break;
                }
                if (i == len) return res;
            }
        }
        return new int[0];
    }

    bool make(int a, int b)
    {
        if (a % b != 0) return false;
        int c = a / b;
        if (c == 0) return false;
        if ((c & (c - 1)) == 0) return true;
        return false;
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
	private void test_case_0() { int[] Arg0 = new int[]{1, 1, 3, 1, 5}; int[] Arg1 = new int[]{1, 2, 3, 4, 5 }; verify_case(0, Arg1, restoreProgression(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{9, 7, 5, 3, 1}; int[] Arg1 = new int[]{9, 7, 5, 3, 1 }; verify_case(1, Arg1, restoreProgression(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{999, 999, 999, 999}; int[] Arg1 = new int[]{999, 999, 999, 999 }; verify_case(2, Arg1, restoreProgression(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{7, 47, 5, 113, 73, 179, 53}; int[] Arg1 = new int[]{14, 47, 80, 113, 146, 179, 212 }; verify_case(3, Arg1, restoreProgression(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{749, 999, 125, 1}; int[] Arg1 = new int[]{1498, 999, 500, 1 }; verify_case(4, Arg1, restoreProgression(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AfraidOfEven ___test = new AfraidOfEven();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
