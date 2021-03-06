using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ContiguousSubsequences {
    public int[] findMaxAverage(int[] a, int K)
    {
        int i, j;
        int[] res = new int[2];
        double max = double.MinValue;
        int maxlen = 0;
        for (i = 0; i < a.Length; i++)
        {
            double sum = 0;
            for (j = i; j < a.Length; j++)
            {
                int len = j - i + 1;
                sum += a[j];
                if (len < K) continue;
                //Console.WriteLine(sum);
                double now = sum / len;
                if (now + 1e-9 > max)
                {
                    if (now - 1e-9 > max || maxlen < len || (maxlen == len && res[0] == i))
                    {
                        max = now;
                        res[0] = i;
                        res[1] = j;
                        maxlen = len;
                    }
                }
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); }
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
	private void test_case_0() { int[] Arg0 = new int[]{1,3,7}; int Arg1 = 2; int[] Arg2 = new int[]{1, 2 }; verify_case(0, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{5,1,3,4}; int Arg1 = 2; int[] Arg2 = new int[]{2, 3 }; verify_case(1, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{10}; int Arg1 = 1; int[] Arg2 = new int[]{0, 0 }; verify_case(2, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{381,921,513,492,135,802,91,519}; int Arg1 = 1; int[] Arg2 = new int[]{1, 1 }; verify_case(3, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{381,921,513,492,135,802,91,519}; int Arg1 = 4; int[] Arg2 = new int[]{0, 3 }; verify_case(4, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_5() { int[] Arg0 = new int[]{3,5,7,7,2,5,4,7,7,2,4}; int Arg1 = 1; int[] Arg2 = new int[]{2, 3 }; verify_case(5, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_6() { int[] Arg0 = new int[]{3, 1, 3, 3, 3, 1, 3, 3, 3}; int Arg1 = 1; int[] Arg2 = new int[]{2, 4 }; verify_case(6, Arg2, findMaxAverage(Arg0, Arg1)); }
	private void test_case_7() { int[] Arg0 = new int[]{1, 3, 2, 1, 1, 2, 2, 2, 2}; int Arg1 = 3; int[] Arg2 = new int[]{5, 8 }; verify_case(7, Arg2, findMaxAverage(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ContiguousSubsequences ___test = new ContiguousSubsequences();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
