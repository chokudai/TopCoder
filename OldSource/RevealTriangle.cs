using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RevealTriangle {
    public string[] calcTriangle(string[] questionMarkTriangle)
    {
        int len = questionMarkTriangle.Length;
        int[,] num = new int[len, len];
        int i, j;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - i; j++)
            {
                if (questionMarkTriangle[i][j] == '?') num[i, j] = -1;
                else num[i, j] = questionMarkTriangle[i][j] - '0';
            }
        }
        while(true)
        {
            bool flag = true;
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len - i - 1; j++)
                {
                    if (num[i, j] == -1 && num[i, j + 1] != -1 && num[i + 1, j] != -1)
                    {
                        num[i, j] = (num[i + 1, j] - num[i, j + 1] + 20) % 10;
                        flag = false;

                    }
                    if (num[i, j] != -1 && num[i, j + 1] == -1 && num[i + 1, j] != -1)
                    {
                        num[i, j + 1] = (num[i + 1, j] - num[i, j] + 20) % 10;
                        flag = false;
                    }
                    if (num[i, j] != -1 && num[i, j + 1] != -1 && num[i + 1, j] == -1)
                    {
                        num[i + 1, j] = (num[i, j] + num[i, j + 1] + 20) % 10;
                        flag = false;
                    }
                }
            }
            if (flag) break;
        }
        string[] res = new string[len];
        for (i = 0; i < len; i++)
        {
            res[i] = "";
            for (j = 0; j < len - i; j++)
            {
                if (num[i, j] != -1) res[i] += num[i, j];
                else res[i] += '?';
            }
        }
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
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
	private void test_case_0() { string[] Arg0 = new string[]{"4??", 
 "?2", 
 "1"}; string[] Arg1 = new string[]{"457", "92", "1" }; verify_case(0, Arg1, calcTriangle(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"1"}; string[] Arg1 = new string[]{"1" }; verify_case(1, Arg1, calcTriangle(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"???2", "??2", "?2", "2"}; string[] Arg1 = new string[]{"0002", "002", "02", "2" }; verify_case(2, Arg1, calcTriangle(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"??5?", "??9", "?4", "6"}; string[] Arg1 = new string[]{"7054", "759", "24", "6" }; verify_case(3, Arg1, calcTriangle(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RevealTriangle ___test = new RevealTriangle();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
