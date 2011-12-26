using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheProgrammingContestDivTwo {
    public int[] find(int T, int[] requiredTime)
    {
        Array.Sort(requiredTime);
        int i;
        int num = 0;
        int p = 0;
        for (i = 0; i < requiredTime.Length; i++)
        {
            if (T >= requiredTime[i])
            {
                T -= requiredTime[i];
                num += requiredTime[i];
                p += num;
            }
            else break;
        }
        return new int[] { i, p };
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
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
	private void test_case_0() { int Arg0 = 74; int[] Arg1 = new int[]{47}; int[] Arg2 = new int[]{1, 47 }; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 74; int[] Arg1 = new int[]{4747}; int[] Arg2 = new int[]{0, 0 }; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 47; int[] Arg1 = new int[]{8, 5}; int[] Arg2 = new int[]{2, 18 }; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 47; int[] Arg1 = new int[]{12, 3, 21, 6, 4, 13}; int[] Arg2 = new int[]{5, 86 }; verify_case(3, Arg2, find(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 58; int[] Arg1 = new int[]{4, 5, 82, 3, 4, 65, 7, 6, 8, 7, 6, 4, 8, 7, 6, 37, 8}; int[] Arg2 = new int[]{10, 249 }; verify_case(4, Arg2, find(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 100000; int[] Arg1 = new int[]{100000}; int[] Arg2 = new int[]{1, 100000 }; verify_case(5, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheProgrammingContestDivTwo ___test = new TheProgrammingContestDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
