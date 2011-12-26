using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Unicorn {
    int RR, CC;
    public int countWays(int R, int C, int L, int seed, string word)
    {
        RR = R; CC = C;
        long mod = 1000000007;
        char[,] chessboard = new char[R, C];
        int x = seed; int y;
        int d = (65535 / L) + 1;
        for (int r = 0; r < R; r++)
            for (int c = 0; c < C; c++)
            {
                x = (x * 25173 + 13849) % 65536;
                chessboard[r,c] = (char)(65 + (x / d));
            }
        if (word.Length == 0) return 0;
        long[,] dpnow = new long[R, C];
        long[,] dpnext = new long[R, C];
        for (int r = 0; r < R; r++)
            for (int c = 0; c < C; c++)
            {
                if (chessboard[r, c] == word[0]) dpnow[r, c] = 1;
                else dpnow[r, c] = 0;
            }
        int i, j, k;
        for (i = 1; i < word.Length; i++)
        {
            long sum = 0;
            for (int r = 0; r < R; r++)
                for (int c = 0; c < C; c++)
                {
                    sum += dpnow[r, c];
                    sum %= mod;
                }
            for (int r = 0; r < R; r++)
                for (int c = 0; c < C; c++)
                {
                    if (chessboard[r, c] != word[i]) continue;
                    long plus = sum;
                    for (j = -1; j <= 1; j++)
                    {
                        for (k = 0; k < R; k++)
                        {
                            x = k;
                            y = c + j;
                            if (!ok(x, y)) continue;
                            plus -= dpnow[x, y];
                        }
                    }
                    for (j = -1; j <= 1; j++)
                    {
                        for (k = 0; k < C; k++)
                        {
                            x = r + j;
                            y = k;
                            if (!ok(x, y)) continue;
                            plus -= dpnow[x, y];
                        }
                    }
                    for (j = -2; j <= 2; j++)
                    {
                        for (k = -2; k <= 2; k++)
                        {
                            x = r + j;
                            y = c + k;
                            if (!ok(x, y)) continue;
                            plus -= dpnow[x, y];
                        }
                    }
                    for (j = -1; j <= 1; j++)
                    {
                        for (k = -2; k <= 2; k++)
                        {
                            x = r + j;
                            y = c + k;
                            if (!ok(x, y)) continue;
                            plus += dpnow[x, y];
                        }
                    }
                    for (j = -2; j <= 2; j++)
                    {
                        for (k = -1; k <= 1; k++)
                        {
                            x = r + j;
                            y = c + k;
                            if (!ok(x, y)) continue;
                            plus += dpnow[x, y];
                        }
                    }
                    plus %= mod;
                    if (plus < 0) plus += mod;
                    dpnext[r, c] = plus;
                }

            for (int r = 0; r < R; r++)
                for (int c = 0; c < C; c++)
                {
                    if (chessboard[r, c] == word[i]) dpnow[r, c] = dpnext[r, c]%mod;
                    else dpnow[r, c] = 0;
                }
        }
        long res = 0;
        for (int r = 0; r < R; r++)
            for (int c = 0; c < C; c++)
            {
                res += (int)dpnow[r, c];
                res %= mod;
            }
        return (int)res;
    }

    bool ok(int x, int y)
    {
        return x >= 0 && y >= 0 && x < RR && y < CC;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int Arg1 = 4; int Arg2 = 2; int Arg3 = 47; string Arg4 = "AB"; int Arg5 = 2; verify_case(0, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 5; int Arg2 = 2; int Arg3 = 47; string Arg4 = "CD"; int Arg5 = 0; verify_case(1, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 1; int Arg3 = 42; string Arg4 = "AA"; int Arg5 = 20; verify_case(2, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 1; int Arg3 = 42; string Arg4 = "AAAAA"; int Arg5 = 172; verify_case(3, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 5; int Arg3 = 54321; string Arg4 = "ABCDE"; int Arg5 = 0; verify_case(4, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_5() { int Arg0 = 8; int Arg1 = 8; int Arg2 = 26; int Arg3 = 226; string Arg4 = "TOPCODER"; int Arg5 = 1; verify_case(5, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_6() { int Arg0 = 20; int Arg1 = 20; int Arg2 = 2; int Arg3 = 47; string Arg4 = "AAAAA"; int Arg5 = 373977054; verify_case(6, Arg5, countWays(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Unicorn ___test = new Unicorn();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
