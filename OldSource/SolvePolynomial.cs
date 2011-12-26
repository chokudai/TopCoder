using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SolvePolynomial {

    long[] a;
    List<int> l;
    bool f;
    public int[] integerRoots(int[] X, int[] Y, int n)
    {
        /*
          lX = length(X)
          lY = length(Y)
          for i = 0, 1, ..., n:
          p = i mod lX
          q = (i + Y[i mod lY]) mod lX
          a[i] = X[p]
          X[p] = X[q]
          X[q] = a[i]
         */
        int lX = X.Length;
        int lY = Y.Length;
        int i, j, k;
        a = new long[n + 1];
        for (i = 0; i <= n; i++)
        {
            int p = i % lX;
            int q = (i + Y[i % lY]) % lX;
            a[i] = X[p];
            X[p] = X[q];
            X[q] = (int)a[i];
        }
        for (i = n; i > 0; i--)
        {
            if (a[i] == 0) continue;
            else break;
        }
        long[] na = new long[i + 1];
        for (j = 0; j <= i; j++) na[j] = a[j];
        a = (long[])na.Clone();
        checka();
        long g = 0;
        for (j = 0; j < a.Length; j++)
        {
            if (a[j] != 0) { g = a[j];  break; }
        }
        if (g != 0)
        {
            for (; j < a.Length; j++)
            {
                g = gcd(g, a[j]);
            }
            for (j = 0; j < a.Length; j++) a[j] /= g;
        }


        l = new List<int>();
        while (true)
        {
            f = false;
            for (i = 0; i <= (int)Math.Sqrt(Math.Abs(a[0]))+1; i++)
            {
                if (a.Length <= 1) break;
                if ((i == 0 && Math.Abs(a[0]) == 0) || (i != 0 && Math.Abs(a[0]) % i == 0))
                {
                    divcheck(i);
                    divcheck(-i);
                    if (i != 0)
                    {
                        divcheck((int)a[0] / i);
                        divcheck(-(int)a[0] / i);
                    }
                }
            }
            if (!f) break;
        }
        int[] res = l.ToArray();
        Array.Sort(res);
        return res;
    }

    void checka()
    {
        return;
        int i;
        for (i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + "x" + i + " ");
        }
        Console.WriteLine();
    }

    void divcheck(int i)
    {
        bool flag = true;
        while (check(a, i) && a.Length >= 2)
        {
            a = diva(a, i);
            if (flag) l.Add(i);
            flag = false;
        }
    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        else return gcd(b, a % b);
    }
    

    long[] diva(long[] a, long b)
    {
        f = true;
        long[] na = new long[a.Length - 1];
        int i;
        for (i = na.Length - 1; i >= 0; i--)
        {
            na[i] = a[i + 1];
            a[i] += na[i] * b;
            a[i + 1] = 0;
        }
        return na;
    }

    bool check(long[] a, long b)
    {
        long[] aa = (long[])a.Clone();
        long[] na = new long[a.Length - 1];
        int i;
        for (i = na.Length - 1; i >= 0; i--)
        {
            na[i] = aa[i + 1];
            if (aa[i] + (double)na[i] * b > long.MaxValue * 0.9) return false;
            if (aa[i] + (double)na[i] * b < long.MinValue * 0.9) return false;
            aa[i] += na[i] * b;
            aa[i + 1] = 0;
        }
        return aa[0] == 0;
    }
    /*
    bool check(long[] a, long b)
    {
        int i;
        long c = 1;
        long res = 0;
        for (i = 0; i < a.Length; i++)
        {
            if ((double)c * a[i] > long.MaxValue * 0.9) return false;
            if ((double)c * a[i] < long.MinValue * 0.9) return false;
            if ((double)c * a[i] + res > long.MaxValue * 0.9) return false;
            if ((double)c * a[i] + res < long.MinValue * 0.9) return false;
            res += a[i] * c;
            if ((double)c * b > long.MaxValue * 0.9) return false;
            if ((double)c * b < long.MinValue * 0.9) return false;
            c *= b;
        }
        if (res == 0) return true;
        else return false;
    }
    */



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
	private void test_case_0() { int[] Arg0 = new int[]{-4, 2, 2}; int[] Arg1 = new int[]{0}; int Arg2 = 2; int[] Arg3 = new int[]{-2, 1 }; verify_case(0, Arg3, integerRoots(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 2, 0}; int[] Arg1 = new int[]{2, 0, 0, 0}; int Arg2 = 3; int[] Arg3 = new int[]{-1 }; verify_case(1, Arg3, integerRoots(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{1, 4, 4}; int[] Arg1 = new int[]{0}; int Arg2 = 2; int[] Arg3 = new int[]{ }; verify_case(2, Arg3, integerRoots(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{-15, -10, 2, 1}; int[] Arg1 = new int[]{0}; int Arg2 = 3; int[] Arg3 = new int[]{3 }; verify_case(3, Arg3, integerRoots(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{735134400, 1383, 4121, 18875, 10463, 
 13512, 19603, 28679, 13483, 9509, 1701,
 13383, 24425, 7923, 7978, 21702, 30989,
 20676, 18547, 28130, 10944}; int[] Arg1 = new int[]{34,23,6,5,3,5,4,34,37,5,6,21,17,9}; int Arg2 = 10000; int[] Arg3 = new int[]{ }; verify_case(4, Arg3, integerRoots(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        SolvePolynomial ___test = new SolvePolynomial();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
