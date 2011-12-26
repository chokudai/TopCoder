using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Bribes
{
    const int mask = (1 << 8) - 1;
    const int mask2 = (1 << 9) - 1;
    const int MAX = 9999;

    public int minBribes(int[] influence, int[] resistance)
    {
        int[,] dp = new int[1 << 8, 1 << 9];
        int i, j, k, l;
        int len = resistance.Length;
        
        for (l = 0; l < len; l++)
        {
            int[] first = new int[1 << 8];
            int[] second = new int[1 << 9];
            int[,] nextdp = new int[1 << 8, 1 << 9];

            for (i = 0; i <= mask2; i++)
                for (j = 0; j < 9; j++)
                    if ((i & (1 << j)) != 0)
                    {
                        if (i <= mask)
                        {
                            if (l - j - 1 < 0) first[i] = -1;
                            else first[i] += influence[l - j - 1] / (1 << (j + 1));
                        }
                        if (l + j >= len) second[i] = -1;
                        else second[i] += influence[l + j] / (1 << (j));
                    }
            for (i = 0; i <= mask; i++)
                for (j = 0; j <= mask2; j++)
                    nextdp[i, j] = MAX;

            for (i = 0; i <= mask; i++)
            {
                if (first[i] < 0) continue;
                for (j = 0; j <= mask2; j++)
                {
                    if (second[j] < 0) continue;
                    if (dp[i, j] == MAX) continue;

                    if (first[i] + second[j] >= resistance[l])
                    {
                        int nexti = ((i << 1) + j % 2) & mask;
                        int nextj = (j >> 1);
                        nextdp[nexti, nextj + (1 << 8)]
                            = Math.Min(nextdp[nexti, nextj + (1 << 8)], dp[i, j] + j % 2);
                        nextdp[nexti, nextj]
                            = Math.Min(nextdp[nexti, nextj], dp[i, j] + j % 2);
                    }
                }
            }
            dp = (int[,])nextdp.Clone();
        }
        int res = MAX;
        for (i = 0; i <= mask; i++) res = Math.Min(res, dp[i, 0]);
        if (res == MAX) return -1;
        else return res;

    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
    private void verify_case(int Case, int Expected, int Received)
    {
        Console.Write("Test Case #" + Case + "...");
        if (Expected == Received)
            Console.WriteLine("PASSED");
        else
        {
            Console.WriteLine("FAILED");
            Console.WriteLine("\tExpected: \"" + Expected + '\"');
            Console.WriteLine("\tReceived: \"" + Received + '\"');
        }
    }
    private void test_case_0() { int[] Arg0 = new int[] { 10, 3, 5, 3, 1 }; int[] Arg1 = new int[] { 11, 2, 7, 3, 1 }; int Arg2 = 2; verify_case(0, Arg2, minBribes(Arg0, Arg1)); }
    private void test_case_1() { int[] Arg0 = new int[] { 15, 15, 15 }; int[] Arg1 = new int[] { 13, 42, 13 }; int Arg2 = -1; verify_case(1, Arg2, minBribes(Arg0, Arg1)); }
    private void test_case_2() { int[] Arg0 = new int[] { 10, 16, 4, 7, 1, 1, 13 }; int[] Arg1 = new int[] { 10, 16, 4, 7, 1, 1, 13 }; int Arg2 = 4; verify_case(2, Arg2, minBribes(Arg0, Arg1)); }
    private void test_case_3() { int[] Arg0 = new int[] { 479, 340, 398, 40, 477, 181, 422, 377, 60, 486, 15, 500, 307, 1, 2, 65, 411, 374, 446, 401 }; int[] Arg1 = new int[] { 402, 87, 20, 76, 468, 493, 252, 98, 216, 58, 89, 500, 89, 26, 8, 125, 269, 116, 426, 81 }; int Arg2 = 7; verify_case(3, Arg2, minBribes(Arg0, Arg1)); }
    private void test_case_4() { int[] Arg0 = new int[] { 21, 196, 401, 157, 9, 497, 371, 84, 395, 495, 401, 190, 465, 359, 47, 441, 245, 487, 118, 405 }; int[] Arg1 = new int[] { 127, 313, 376, 94, 66, 37, 237, 142, 315, 495, 257, 153, 437, 339, 483, 356, 16, 132, 231, 342 }; int Arg2 = 8; verify_case(4, Arg2, minBribes(Arg0, Arg1)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        Bribes ___test = new Bribes();
        ___test.run_test(-1);
        try
        {
            
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.ToString());
        }
    }
    // END CUT HERE
}
