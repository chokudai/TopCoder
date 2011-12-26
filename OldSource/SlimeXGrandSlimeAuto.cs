using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SlimeXGrandSlimeAuto {
    public int travel(int[] cars, int[] districts, string[] roads, int inverseWalkSpeed, int inverseDriveSpeed)
    {
        int len = roads.Length;
        int[,] dist = new int[len, len];
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                dist[i, j] = getdist(roads[i][j]);
            }
            dist[i, i] = 0;
        }
        for (k = 0; k < len; k++)
        {
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len; j++)
                {
                    dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);
                }
            }
        }
        int blen = districts.Length + cars.Length;
        int[,] matrix = new int[blen, blen];
        int pre = 0;
        for (i = 0; i < districts.Length; i++)
        {
            for (j = 0; j < cars.Length; j++)
            {
                matrix[i, j] = - dist[pre, cars[j]] * inverseWalkSpeed - dist[cars[j], districts[i]] * inverseDriveSpeed;
            }
            for (; j < blen; j++)
            {
                matrix[i, j] =  - dist[pre, districts[i]] * inverseWalkSpeed;
            }
            pre = districts[i];
        }
        for (; i < blen; i++) for (j = 0; j < blen; j++) matrix[i, j] = 0;
        return -(int)hungarian(matrix);
    }

    long hungarian(int[,] a)
    {
        int n = a.GetLength(0);
        long p, q;
        long[] fx = new long[n];
        long[] fy = new long[n];
        long inf = (long)1e16;
        long i, j, k;
        for (i = 0; i < n; i++) fx[i] = inf;
        for (i = 0; i < n; i++) fy[i] = inf;
        long[] x = new long[n];
        long[] y = new long[n];
        for (i = 0; i < n; i++) x[i] = y[i] = -1;

        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
                fx[i] = Math.Max(fx[i], a[i, j]);
        for (i = 0; i < n; )
        {
            long[] t = new long[n];
            long[] s = new long[n + 1];
            for (j = 0; j < n; j++) t[j] = -1;
            for (j = 0; j <= n; j++) s[j] = i;
            for (p = q = 0; p <= q && x[i] < 0; ++p)
                for (k = s[p], j = 0; j < n && x[i] < 0; ++j)
                    if (fx[k] + fy[j] == a[k, j] && t[j] < 0)
                    {
                        s[++q] = y[j];
                        t[j] = k;
                        if (s[q] < 0)
                            for (p = j; p >= 0; j = p)
                            {
                                y[j] = k = t[j];
                                p = x[k];
                                x[k] = j;
                            }
                    }
            if (x[i] < 0)
            {
                long d = inf;
                for (k = 0; k <= q; ++k)
                    for (j = 0; j < n; ++j)
                        if (t[j] < 0) d = Math.Min(d, fx[s[k]] + fy[j] - a[s[k], j]);
                for (j = 0; j < n; ++j)
                {
                    if (t[j] >= 0) fy[j] += d;
                }
                for (k = 0; k <= q; ++k) fx[s[k]] -= d;
            }
            else ++i;
        }
        long ret = 0;
        for (i = 0; i < n; ++i) ret += a[i, x[i]];
        return (int)ret;
    }

    int getdist(char c)
    {
        if (c >= '0' && c <= '9') return c - '0' + 1;
        if (c >= 'a' && c <= 'z') return c - 'a' + 11;
        if (c >= 'A' && c <= 'Z') return c - 'A' + 37;
        else return 99999;
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{2,3,0}; string[] Arg2 = new string[]{
"..0.",
"...1",
"0..2",
".12."}; int Arg3 = 5; int Arg4 = 1; int Arg5 = 36; verify_case(0, Arg5, travel(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{2, 0}; string[] Arg2 = new string[]{
".A.",
"A.B",
".B."}; int Arg3 = 2; int Arg4 = 1; int Arg5 = 262; verify_case(1, Arg5, travel(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int[] Arg0 = new int[]{2,2}; int[] Arg1 = new int[]{1,2,1}; string[] Arg2 = new string[]{
".a4",
"a..",
"4.."}; int Arg3 = 3; int Arg4 = 1; int Arg5 = 95; verify_case(2, Arg5, travel(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{2, 0}; string[] Arg2 = new string[]{
".B.",
"B.A",
".A."}; int Arg3 = 2; int Arg4 = 1; int Arg5 = 262; verify_case(3, Arg5, travel(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int[] Arg0 = new int[]{2,5,1,2}; int[] Arg1 = new int[]{1,5,1,2,4}; string[] Arg2 = new string[]{
".12.4.",
"1....7",
"2..3..",
"..3..5",
"4.....",
".7.5.."}
; int Arg3 = 53; int Arg4 = 37; int Arg5 = 1259; verify_case(4, Arg5, travel(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SlimeXGrandSlimeAuto ___test = new SlimeXGrandSlimeAuto();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
