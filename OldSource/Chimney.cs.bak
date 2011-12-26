using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Chimney {

    long mod = 1000000007;

    enum name
    {
        n0, n1, n2A, n2B, n3,
        n2A1, n31, n32, n321, n4,
        n41, n42A, n42B, n42A1, n43, n431,
        n432, n44, n441, n442A, n442B,
        n443, n444
    }

    int len;
    public int countWays(long n)
    {
        len = 23;
        long[,] first = new long[1, 23];
        first[0, (int)name.n4] = 1;

        long[,] powa = new long[23, 23];
        long[,] powb = new long[23, 23];
        powa[(int)name.n0, (int)name.n1] = 4;

        powa[(int)name.n1, (int)name.n2A] = 2;
        powa[(int)name.n1, (int)name.n2B] = 1;
        //2A 2B
        powa[(int)name.n2A, (int)name.n3] = 2;
        powa[(int)name.n2A, (int)name.n2A1] = 1;
        powa[(int)name.n2B, (int)name.n3] = 2;
        //3 2A-1
        powa[(int)name.n3, (int)name.n31] = 2;
        powa[(int)name.n3, (int)name.n4] = 1;
        powa[(int)name.n2A1, (int)name.n31] = 2;
        //3-1 4
        powa[(int)name.n31, (int)name.n32] = 1;
        powa[(int)name.n31, (int)name.n41] = 1;
        powa[(int)name.n4, (int)name.n41] = 4;
        //3-2 4-1
        powa[(int)name.n32, (int)name.n321] = 1;
        powa[(int)name.n32, (int)name.n42A] = 1;
        powa[(int)name.n41, (int)name.n42A] = 2;
        powa[(int)name.n41, (int)name.n42B] = 1;
        //321 42A 42B
        powa[(int)name.n321, (int)name.n42A1] = 1;
        powa[(int)name.n42A, (int)name.n42A1] = 1;
        powa[(int)name.n42A, (int)name.n43] = 2;
        powa[(int)name.n42B, (int)name.n43] = 2;
        //42A1 43
        powa[(int)name.n43, (int)name.n431] = 2;
        powa[(int)name.n43, (int)name.n44] = 1;
        powa[(int)name.n42A1, (int)name.n431] = 2;
        //431 44
        powa[(int)name.n431, (int)name.n432] = 1;
        powa[(int)name.n431, (int)name.n441] = 1;
        powa[(int)name.n44, (int)name.n441] = 4;
        //432 441
        powa[(int)name.n432, (int)name.n442A] = 1;
        powa[(int)name.n441, (int)name.n442A] = 2;
        powa[(int)name.n441, (int)name.n442B] = 1;
        //442A,442B
        powa[(int)name.n442A, (int)name.n443] = 2;
        powa[(int)name.n442B, (int)name.n443] = 2;
        //443
        powa[(int)name.n443, (int)name.n444] = 1;

        powb[(int)name.n4, (int)name.n0] = 1;
        powb[(int)name.n41, (int)name.n1] = 1;
        powb[(int)name.n42A, (int)name.n2A] = 1;
        powb[(int)name.n42A1, (int)name.n2A1] = 1;
        powb[(int)name.n42B, (int)name.n2B] = 1;
        powb[(int)name.n43, (int)name.n3] = 1;
        powb[(int)name.n431, (int)name.n31] = 1;
        powb[(int)name.n432, (int)name.n32] = 1;
        powb[(int)name.n44, (int)name.n4] = 1;
        powb[(int)name.n441, (int)name.n41] = 1;
        powb[(int)name.n442A, (int)name.n42A] = 1;
        powb[(int)name.n442B, (int)name.n42B] = 1;
        powb[(int)name.n443, (int)name.n43] = 1;
        powb[(int)name.n444, (int)name.n44] = 1;

        long[,] powc = matmul(matpow(powa, 4), powb);
        long[,] last = matmul(first, matpow(powc, n));
        return (int)last[0, (int)name.n4];
    }

    long[,] matpow(long[,] m, long a)
    {
        if (a == 0)
        {
            long[,] res = new long[len, len];
            int i;
            for (i = 0; i < len; i++) res[i, i] = 1;
            return res;
        }
        else if (a % 2 == 0)
        {
            long[,] res = matpow(m, a / 2);
            return matmul(res, res);
        }
        else
        {
            return matmul(m, matpow(m, a - 1));
        }
    }

    long[,] matmul(long[,] ma, long[,] mb)
    {
        int i, j, k;
        int len1 = ma.GetLength(0);
        int len2 = mb.GetLength(1);
        int len3 = ma.GetLength(1);
        long[,] res = new long[len1, len2];
        for (i = 0; i < len1; i++)
        {
            for (j = 0; j < len2; j++)
            {
                for (k = 0; k < len3; k++)
                {
                    res[i, j] += ma[i, k] * mb[k, j] % mod;
                }
                res[i, j] %= mod;
            }
        }
        return res;
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
	private void test_case_0() { long Arg0 = 1l; int Arg1 = 24; verify_case(0, Arg1, countWays(Arg0)); }
	private void test_case_1() { long Arg0 = 2l; int Arg1 = 1088; verify_case(1, Arg1, countWays(Arg0)); }
	private void test_case_2() { long Arg0 = 5l; int Arg1 = 110198784; verify_case(2, Arg1, countWays(Arg0)); }
	private void test_case_3() { long Arg0 = 6l; int Arg1 = 138284509; verify_case(3, Arg1, countWays(Arg0)); }
	private void test_case_4() { long Arg0 = 100000l; int Arg1 = 19900327; verify_case(4, Arg1, countWays(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        Chimney ___test = new Chimney();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
