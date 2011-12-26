using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TwistedMatrix {

    public string[] solve(string[] A, string[] B)
    {
        int i, j, k, l;
        int hlen = A.Length;
        int wlen = A[0].Length;
        bool first = true;
        char[,] bestc = new char[hlen, wlen];

        for (i = 0; i < hlen - 1; i++)
        {
            for (j = 0; j < wlen - 1; j++)
            {
                char[,] c = new char[hlen, wlen];


                for (k = 0; k < hlen; k++)
                {
                    for (l = 0; l < wlen; l++)
                    {
                        c[k, l] = A[k][l];
                    }
                }

                c[i, j] = A[i][j + 1];
                c[i, j + 1] = A[i + 1][j + 1];
                c[i + 1, j + 1] = A[i + 1][j];
                c[i + 1, j] = A[i][j];

                for (k = 0; k < hlen; k++)
                {
                    for (l = 0; l < wlen; l++)
                    {
                        if (c[k, l] == '?')
                        {
                            if (B[k][l] == '1') c[k, l] = '1';
                            else c[k, l] = '0';
                            continue;
                        }
                        else if (B[k][l] == '?' || B[k][l] == c[k, l]) continue;
                        k = 1000; break;
                    }
                }
                if (k != 1001)
                {
                    if (!first)
                    {
                        for (k = 0; k < hlen; k++)
                        {
                            for (l = 0; l < wlen; l++)
                            {
                                if (c[k, l] < bestc[k, l])
                                {
                                    k = 1001; break;
                                }
                                else if (c[k, l] > bestc[k, l])
                                {
                                    k = 1002; break;
                                }
                            }
                        }
                    }
                    if (k == 1002 || first)
                    {
                        first = false;
                        for (k = 0; k < hlen; k++)
                        {
                            for (l = 0; l < wlen; l++)
                            {
                                bestc[k, l] = c[k, l];
                            }
                        }
                    }
                }

                for (k = 0; k < hlen; k++)
                {
                    for (l = 0; l < wlen; l++)
                    {
                        c[k, l] = A[k][l];
                    }
                }

                c[i, j] = A[i + 1][j];
                c[i + 1, j] = A[i + 1][j + 1];
                c[i + 1, j + 1] = A[i][j + 1];
                c[i, j + 1] = A[i][j];

                for (k = 0; k < hlen; k++)
                {
                    for (l = 0; l < wlen; l++)
                    {
                        if (c[k, l] == '?')
                        {
                            if (B[k][l] == '1') c[k, l] = '1';
                            else c[k, l] = '0';
                            continue;
                        }
                        else if (B[k][l] == '?' || B[k][l] == c[k, l]) continue;
                        k = 1000; break;
                    }
                }
                if (k != 1001)
                {
                    if (!first)
                    {
                        for (k = 0; k < hlen; k++)
                        {
                            for (l = 0; l < wlen; l++)
                            {
                                if (c[k, l] < bestc[k, l])
                                {
                                    k = 1001; break;
                                }
                                else if (c[k, l] > bestc[k, l])
                                {
                                    k = 1002; break;
                                }
                            }
                        }
                    }
                    if (k == 1002 || first)
                    {
                        first = false;
                        for (k = 0; k < hlen; k++)
                        {
                            for (l = 0; l < wlen; l++)
                            {
                                bestc[k, l] = c[k, l];
                            }
                        }
                    }
                }
            }
        }
        if (first) return new string[0];
        string[] res = new string[hlen];
        for (k = 0; k < hlen; k++)
        {
            res[k] = "";
            for (l = 0; l < wlen; l++)
            {
                res[k] = res[k] + bestc[k, l];
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
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
	private void test_case_0() { string[] Arg0 = new string[]{"1000",
 "0000",
 "0000",
 "0000"}; string[] Arg1 = new string[]{"0000",
 "?000",
 "0000",
 "0000"}; string[] Arg2 = new string[]{"0000", "1000", "0000", "0000" }; verify_case(0, Arg2, solve(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"11",
 "01"}; string[] Arg1 = new string[]{"??",
 "??"}; string[] Arg2 = new string[]{"01", "11" }; verify_case(1, Arg2, solve(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"000",
 "0?0",
 "000"}; string[] Arg1 = new string[]{"111",
 "1?1",
 "111"}; string[] Arg2 = new string[]{ }; verify_case(2, Arg2, solve(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"?1111",
 "11111",
 "11011",
 "10111"}; string[] Arg1 = new string[]{"?1111",
 "11111",
 "1??11",
 "1??11"}; string[] Arg2 = new string[]{"01111", "11111", "10011", "11111" }; verify_case(3, Arg2, solve(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"00111",
 "00111",
 "11111",
 "11111"}; string[] Arg1 = new string[]{"??1??",
 "??1??",
 "?????",
 "?????"}; string[] Arg2 = new string[]{"00111", "00111", "11111", "11111" }; verify_case(4, Arg2, solve(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TwistedMatrix ___test = new TwistedMatrix();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
