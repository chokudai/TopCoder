using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class grafixClick {
    public int[] checkSaveButton(int[] mouseRows, int[] mouseCols)
    {
        List<int> res = new List<int>();
        for (int i = 0; i < mouseCols.Length; i++)
        {
            if (mouseRows[i] >= 20 && mouseRows[i] <= 39 && mouseCols[i] >= 50 && mouseCols[i] <= 99)
            {
                res.Add(i);
                //Console.WriteLine(mouseRows[i] + " " + mouseCols[i]);
            }
        }
        return res.ToArray();
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
	private void test_case_0() { int[] Arg0 = new int[]{20, 39, 100}; int[] Arg1 = new int[]{99, 50, 200}; int[] Arg2 = new int[]{ 0,  1 }; verify_case(0, Arg2, checkSaveButton(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{0, 100, 399}; int[] Arg1 = new int[]{0, 200, 599}; int[] Arg2 = new int[]{ }; verify_case(1, Arg2, checkSaveButton(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{30}; int[] Arg1 = new int[]{75}; int[] Arg2 = new int[]{ 0 }; verify_case(2, Arg2, checkSaveButton(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{10, 20, 30, 30, 30, 30, 34, 35, 345}; int[] Arg1 = new int[]{10, 20, 30, 50, 60, 80, 34, 35, 345}; int[] Arg2 = new int[]{ 3,  4,  5 }; verify_case(3, Arg2, checkSaveButton(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{57, 28, 18, 25, 36, 12, 33, 44, 13, 32,
 32, 51, 11, 27, 8, 51, 17, 34, 10, 16,
 47, 57, 20, 57, 32, 14, 13, 37, 10, 16,
 49, 37, 52, 8, 18, 44, 50, 43, 11, 1,
 21, 22, 17, 35, 28, 53, 56, 16, 11, 44}; int[] Arg1 = new int[]{146, 22, 41, 88, 123, 99, 43, 110, 25, 64,
 141, 110, 70, 34, 99, 103, 60, 64, 142, 109,
 133, 144, 72, 68, 25, 32, 21, 140, 30, 105,
 32, 72, 114, 97, 35, 131, 103, 110, 133, 81,
 125, 36, 76, 78, 77, 47, 50, 94, 22, 20}; int[] Arg2 = new int[]{ 3,  9,  17,  22,  31,  43,  44 }; verify_case(4, Arg2, checkSaveButton(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
grafixClick ___test = new grafixClick();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
