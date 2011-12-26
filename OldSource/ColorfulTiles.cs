using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorfulTiles {
    long mod = 1000000007;
    public int theCount(string[] firstrooms, int K)
    {
        int i, j, k, l, m, n;
        char[] color = new char[4] { 'R', 'G', 'B', 'Y' };
        long res = 0;
        if (firstrooms.Length == 1 || firstrooms[0].Length == 1)
        {
            string r = "";
            long myres = 0;
            for (i = 0; i < firstrooms.Length; i++)
            {
                r += firstrooms[i];
            }
            int len = 0;

            long[,] dp = new long[4, K + 1];
            for (j = 0; j < 4; j++)
            {
                if (room[0] == color[j]) dp[j, 0] = 1;
                else dp[j, 1] = 1;
            }
            for (i = 1; i < len; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    for (k = 0; k < 4; k++)
                    {
                        if (room[i] == color[k])
                        {
                            
                        }
                    }
                }
            }

            return myres;
        }
        string[] room = (string[])firstrooms.Clone();
        for (i = 0; i < 4; i++)
        {
            for (j = i + 1; j < 4; j++)
            {
                char[,] c = new char[2, 2];
                c[0, 0] = color[i];
                c[0, 1] = color[j];
                for (k = 0; k < 4; k++) if (k != i && k != j) { c[1, 0] = color[k]; break;}
                for (k = k + 1; k < 4; k++) if (k != i && k != j) { c[1, 1] = color[k]; break; }
                long[] dp = new long[K + 1];
                dp[0] = 1;
                for (k = 0; k < room.Length; k++)
                {
                    long[] nextdp = new long[K + 1];
                    int count1 = 0;
                    int count2 = 0;
                    for (l = 0; l < room[k].Length; l++)
                    {
                        if (room[k][l] != c[k % 2, l % 2]) count1++;
                        if (room[k][l] != c[k % 2, (l + 1) % 2]) count2++;
                    }
                    for (l = 0; l <= K - count1; l++)
                    {
                        nextdp[l + count1] += dp[l];
                        nextdp[l + count1] %= mod;
                    }
                    for (l = 0; l <= K - count2; l++)
                    {
                        nextdp[l + count2] += dp[l];
                        nextdp[l + count2] %= mod;
                    }
                    dp = (long[])nextdp.Clone();
                }
                for (k = 0; k < dp.Length; k++)
                {
                    res += dp[k];
                    res %= mod;
                }
            }
        }
        room = new string[firstrooms[0].Length];
        for (i = 0; i < room.Length; i++) room[i] = "";
        for (i = 0; i < firstrooms.Length; i++)
        {
            for (j = 0; j < firstrooms[0].Length; j++)
            {
                room[j] += firstrooms[i][j];
            }
        }
        for (i = 0; i < 4; i++)
        {
            for (j = i + 1; j < 4; j++)
            {
                char[,] c = new char[2, 2];
                c[0, 0] = color[i];
                c[0, 1] = color[j];
                for (k = 0; k < 4; k++) if (k != i && k != j) { c[1, 0] = color[k]; break; }
                for (k = k + 1; k < 4; k++) if (k != i && k != j) { c[1, 1] = color[k]; break; }
                long[] dp = new long[K + 1];
                dp[0] = 1;
                for (k = 0; k < room.Length; k++)
                {
                    long[] nextdp = new long[K + 1];
                    int count1 = 0;
                    int count2 = 0;
                    for (l = 0; l < room[k].Length; l++)
                    {
                        if (room[k][l] != c[k % 2, l % 2]) count1++;
                        if (room[k][l] != c[k % 2, (l + 1) % 2]) count2++;
                    }
                    for (l = 0; l <= K - count1; l++)
                    {
                        nextdp[l + count1] += dp[l];
                        nextdp[l + count1] %= mod;
                    }
                    for (l = 0; l <= K - count2; l++)
                    {
                        nextdp[l + count2] += dp[l];
                        nextdp[l + count2] %= mod;
                    }
                    dp = (long[])nextdp.Clone();
                }
                for (k = 0; k < dp.Length; k++)
                {
                    res += dp[k];
                    res %= mod;
                }
            }
        }
        for (i = 0; i < 4; i++)
        {
            for (j = 0; j < 4; j++)
            {
                if (i == j) continue;
                for (k = 0; k < 4; k++)
                {
                    if (i == k || j == k) continue;
                    for (l = 0; l < 4; l++)
                    {
                        char[,] c = new char[2, 2];
                        if (i == l || j == l || k == l) continue;
                        c[0, 0] = color[i];
                        c[0, 1] = color[j];
                        c[1, 0] = color[k];
                        c[1, 1] = color[l];
                        int count = 0;
                        for (m = 0; m < room.Length; m++)
                        {
                            for (n = 0; n < room[0].Length; n++)
                            {
                                if (room[m][n] != c[m % 2, n % 2]) count++;
                            }
                        }
                        if (count <= K) res = (res + mod - 1) % mod;
                    }
                }
            }
        }
        return (int)(res % mod);
    }

    long checkmod(long a)
    {
        return powmod(a % mod, mod - 2);
    }

    long powmod(long a, long b)
    {
        if (b == 0) return 1;
        if (b % 2 == 1) return (a * powmod(a, b - 1)) % mod;
        long c = powmod(a, b / 2);
        return (c * c) % mod;
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
	private void test_case_0() { string[] Arg0 = new string[]{"RG"}; int Arg1 = 1; int Arg2 = 5; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"BY"}; int Arg1 = 2; int Arg2 = 12; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"RG",
 "GR"}; int Arg1 = 2; int Arg2 = 8; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"BRYBGYRB"
,"GRYGYBBG"
,"RGBGYBYG"
,"YRBRGBYG"
,"RBGRBRGG"
,"RBGYRYBY"}; int Arg1 = 34; int Arg2 = 489; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBBBBYYYYYBBBBBBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBYYYYYYYYYYYBBBBBBBB"
,"BBBBBBYYYYYYYYYYYYYYYYBBBBBBBBYYYYBBBBBYYYYBBBBBBB"
,"BBBBBBYYYYYYYYYYYYYYYYBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB"
,"BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBBYYYYYYYYYBBBBBBBBB"
,"BBBBBBYYYYYYYYYYYYBBBBBBBBBBBBBBYYYYYYYYYBBBBBBBBB"
,"BBBBBBYYYYYYYYYYYYYYBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB"
,"BBBBBBBBBBBBBBBBYYYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBBBBBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBBBBBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBYYYBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB"
,"BBBBBBBYYYYBBBBBYYYYBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB"
,"BBBBBBBBYYYYYYYYYYYBBBBBBBBBBBBYYYYYYYYYYYBBBBBBBB"
,"BBBBBBBBBBBYYYYYBBBBBBBBBBBBBBBBBBYYYYYBBBBBBBBBBB"
,"BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"}; int Arg1 = 825; int Arg2 = 404506540; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColorfulTiles ___test = new ColorfulTiles();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
