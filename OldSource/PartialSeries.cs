using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PartialSeries {
    public int[] getFirst(int[] series, int[] available)
    {
        int len = available.Length;
        int slen = series.Length;
        Array.Sort(available);
        long[, ,] dp = new long[1 << len, 11, 2]; //0:+ 1:-
        byte[, ,] num = new byte[1 << len, 11, 2];
        int[] bit = new int[1 << len];
        int i, j, k, l, m;
        for (j = 0; j < (1 << len); j++)
        {
            for (k = 0; k < len; k++)
            {
                if ((j >> k) % 2 == 1) bit[j]++;
            }
        }
        for (j = 0; j < (1 << len); j++)
        {
            for (k = 0; k < 11; k++)
            {
                for (l = 0; l < 2; l++)
                {
                    dp[j, k, l] = 0;
                    num[j, k, l] = 100;
                }
            }
        }
        for (k = 0; k < 11; k++)
        {
            for (l = 0; l < 2; l++)
            {
                dp[0, k, l] = 0;
                num[0, k, l] = 0;
            }
        }
        int count = 0;
        for (i = 0; i < slen; i++)
        {
            for (j = 0; j < (1 << len); j++)
            {
                if (bit[j] != count) continue;
                if (series[i] == -1)
                {
                    int n = -1;
                    for (k = 0; k < len; k++) //add
                    {
                        if ((j >> k) % 2 == 1) continue;
                        if (available[k] == n) continue;
                        n = available[k];
                        for (l = 0; l < 11; l++) //prenum
                        {
                            for (m = 0; m < 2; m++)
                            {
                                byte add = 0;
                                if (m == 0 && n < l) add++;
                                if (m == 1 && n > l) add++;
                                byte next = (byte)(num[j, l, m] + add);
                                long nextdp = dp[j, l, m] * 15 + k;
                                int nextj = j | (1 << k);
                                int nextl = n;
                                if (n >= l)
                                {
                                    if (num[nextj, nextl, 0] > next
                                        || (num[nextj, nextl, 0] == next && dp[nextj, nextl, 0] > nextdp))
                                    {
                                        num[nextj, nextl, 0] = next;
                                        dp[nextj, nextl, 0] = nextdp;
                                    }
                                }
                                if (n <= l)
                                {
                                    if (num[nextj, nextl, 1] > next
                                        || (num[nextj, nextl, 1] == next && dp[nextj, nextl, 1] > nextdp))
                                    {
                                        num[nextj, nextl, 1] = next;
                                        dp[nextj, nextl, 1] = nextdp;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int n = series[i];
                    byte up = 100;
                    long updp = 0;
                    byte down = 100;
                    long downdp = 0;
                    for (l = 0; l < 11; l++) //prenum
                    {
                        for (m = 0; m < 2; m++)
                        {
                            byte add = 0;
                            if (m == 0 && n < l) add++;
                            if (m == 1 && n > l) add++;
                            byte next = (byte)(num[j, l, m] + add);
                            long nextdp = dp[j, l, m];
                            if (n >= l)
                            {
                                if (up > next
                                    || (up == next && updp > nextdp))
                                {
                                    up = next;
                                    updp = nextdp;
                                }
                            }
                            if (n <= l)
                            {
                                if (down > next
                                    || (down == next && downdp > nextdp))
                                {
                                    down = next;
                                    downdp = nextdp;
                                }
                            }
                        }
                    }
                    for (l = 0; l < 11; l++) //prenum
                    {
                        for (m = 0; m < 2; m++)
                        {
                            num[j, l, m] = 100;
                            dp[j, l, m] = 0;
                        }
                    }
                    num[j, n, 0] = up;
                    dp[j, n, 0] = updp;
                    num[j, n, 1] = down;
                    dp[j, n, 1] = downdp;
                }
            }
            if (series[i] == -1) count++;
        }
        byte resnum = 100;
        long resdp = 0;
        for (j = 0; j < (1 << len); j++)
        {
            if (bit[j] != count) continue;
            for (l = 0; l < 11; l++) //prenum
            {
                for (m = 0; m < 2; m++)
                {
                    if (resnum > num[j, l, m]
                        || (resnum == num[j, l, m] && resdp > dp[j, l, m]))
                    {
                        resnum = num[j, l, m];
                        resdp = dp[j, l, m];
                    }
                }
            }
        }
        int[] ret = new int[slen];
        for (i = 0; i < slen; i++)
        {
            if (series[i] != -1) ret[i] = series[i];
            else
            {
                count--;
                ret[i] = available[(resdp / (long)(Math.Pow(15, count) + 0.5)) % 15];
            }
        }
        Console.WriteLine(resnum);
        return ret;
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
	private void test_case_0() { int[] Arg0 = new int[]{-1,-1,-1,-1,-1}; int[] Arg1 = new int[]{1,2,3,4,5}; int[] Arg2 = new int[]{1, 2, 3, 4, 5 }; verify_case(0, Arg2, getFirst(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,-1,4,5}; int[] Arg1 = new int[]{10}; int[] Arg2 = new int[]{1, 2, 10, 4, 5 }; verify_case(1, Arg2, getFirst(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,-1,6,2,4,-1,2,7,-1,-1}; int[] Arg1 = new int[]{1,2,4,7,8,8}; int[] Arg2 = new int[]{1, 1, 6, 2, 4, 2, 2, 7, 7, 4 }; verify_case(2, Arg2, getFirst(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{8,-1,6,4,-1,-1,6}; int[] Arg1 = new int[]{2,3,6}; int[] Arg2 = new int[]{8, 6, 6, 4, 2, 3, 6 }; verify_case(3, Arg2, getFirst(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{-1, 5, -1}; int[] Arg1 = new int[]{1, 1, 9}; int[] Arg2 = new int[]{1, 5, 9 }; verify_case(4, Arg2, getFirst(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PartialSeries ___test = new PartialSeries();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
