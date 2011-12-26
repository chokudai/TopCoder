using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ArithmeticProgressions {
    public string[] maxAptitude(string[] numbers)
    {
        int len = numbers.Length;
        long[] num = new long[len];
        int i, j, k, l;
        for (i = 0; i < len; i++) num[i] = long.Parse(numbers[i]);
        Array.Sort(num);
        long m = num[0];
        long M = num[len - 1];

        string[] res = new string[] { "0", "1" };
        if (len < 3) return res;
        double best = 0;
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                for (k = j + 1; k < len; k++)
                {
                    long g = gcd(num[k] - num[j], num[j] - num[i]);
                    long amari = num[i] % g;
                    long a = (M - amari + g) / g - (m - 1 - amari + g) / g;
                    long b = 0;
                    for (l = 0; l < len; l++)
                    {
                        if (num[l] % g == amari) b++;
                    }
                    //Console.WriteLine(a + " " + b + " " + g + " " + amari);
                    if ((double)b / a > best)
                    {
                        long gg = gcd(a, b);
                        a /= gg; b /= gg;
                        res[0] = b.ToString();
                        res[1] = a.ToString();
                        best = (double)b / a;
                    }
                }
            }
        }
        return res;
    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        return gcd(b, a % b);
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
	private void test_case_0() { string[] Arg0 = new string[]{"1", "3", "5", "8"}; string[] Arg1 = new string[]{"3", "4" }; verify_case(0, Arg1, maxAptitude(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"1", "3", "5", "7", "9", "11", "13", "15", "17", "19"}; string[] Arg1 = new string[]{"1", "1" }; verify_case(1, Arg1, maxAptitude(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"1", "999999999999999999"}; string[] Arg1 = new string[]{"0", "1" }; verify_case(2, Arg1, maxAptitude(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1", "7", "13", "3511", "1053", "10", "5"}; string[] Arg1 = new string[]{"3", "391" }; verify_case(3, Arg1, maxAptitude(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ArithmeticProgressions ___test = new ArithmeticProgressions();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
