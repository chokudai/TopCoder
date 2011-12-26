using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BinaryCode {
    public string[] decode(string message)
    {
        string[] res = new string[2];
        int len = message.Length;
        int i, j;
        for (i = 0; i < 2; i++)
        {
            int[] memo = new int[len + 2];
            memo[1] = i;
            for (j = 0; j < len; j++)
            {
                memo[j + 2] = message[j] - '0' - memo[j] - memo[j + 1];
                if (memo[j + 2] < 0 || memo[j + 2] > 1) break;
            }
            if (j == len && memo[len + 1] == 0)
            {
                res[i] = "";
                for (j = 0; j < len; j++) res[i] += memo[j + 1];
            }
            else res[i] = "NONE";
        }
        return res;
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string[] Expected, string[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(string[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (string o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(string[] a, string[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { string Arg0 = "123210122"; string[] Arg1 = new string[]{ "011100011",  "NONE" }; verify_case(0, Arg1, decode(Arg0)); }
	private void test_case_1() { string Arg0 = "11"; string[] Arg1 = new string[]{ "01",  "10" }; verify_case(1, Arg1, decode(Arg0)); }
	private void test_case_2() { string Arg0 = "22111"; string[] Arg1 = new string[]{ "NONE",  "11001" }; verify_case(2, Arg1, decode(Arg0)); }
	private void test_case_3() { string Arg0 = "123210120"; string[] Arg1 = new string[]{ "NONE",  "NONE" }; verify_case(3, Arg1, decode(Arg0)); }
	private void test_case_4() { string Arg0 = "3"; string[] Arg1 = new string[]{ "NONE",  "NONE" }; verify_case(4, Arg1, decode(Arg0)); }
	private void test_case_5() { string Arg0 = "12221112222221112221111111112221111"; string[] Arg1 = new string[]{ "01101001101101001101001001001101001",  "10110010110110010110010010010110010" }; verify_case(5, Arg1, decode(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BinaryCode ___test = new BinaryCode();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
