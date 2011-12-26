using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CollectingRiders
{

    int h, w;

    int getNum(int i, int j)
    {
        return i * w + j;
    }

    public int minimalMoves(string[] board)
    {
        long res = int.MaxValue;
        int i, j, k;
        long tempnum = 1;
        int NUM = 1001;
        for (i = 1; i <= NUM / 2; i++)
        {
            tempnum += (2 * i + 1) * (long)(2 * i + 1) * 4 - 2 * i * 6;
        }
        Console.WriteLine(tempnum);

        h = board.Length;
        w = board[0].Length;
        int len = h*w;
        long[,] dist = new long[len, len];
        for (i = 0; i < len; i++)
            for (j = 0; j < len; j++)
                dist[i, j] = int.MaxValue;
        int[] vi = new int[] { -2, -2, -1, -1, 1, 1, 2, 2 };
        int[] vj = new int[] { 1, -1, 2, -2, 2, -2, 1, -1 };

        for (i = 0; i < h; i++)
            for (j = 0; j < w; j++)
            {
                for (k = 0; k < 8; k++)
                {
                    int ni = i + vi[k];
                    int nj = j + vj[k];
                    if (ni < 0 || nj < 0 || ni >= h || nj >= w) continue;
                    int f = getNum(i, j);
                    int t = getNum(ni, nj);
                    dist[f, t] = dist[t, f] = 1;
                }
            }
        for (i = 0; i < len; i++) dist[i, i] = 0;
        for (i = 0; i < len; i++)
            for (j = 0; j < len; j++)
                for (k = 0; k < len; k++)
                    dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);

        for (k = 0; k < len; k++)
        {
            long sum = 0;
            for (i = 0; i < h; i++)
                for (j = 0; j < w; j++)
                    if (board[i][j] != '.')
                        sum += ((long)(board[i][j] - '0') + dist[k, getNum(i, j)] - 1) / (long)(board[i][j] - '0');
            res = Math.Min(sum, res);
        }
        if (res >= 9999999) return -1;
        else return (int)res;
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
    private void test_case_0()
    {
        string[] Arg0 = new string[]{"...1",
 "....",
 "2..."}; int Arg1 = 2; verify_case(0, Arg1, minimalMoves(Arg0));
    }
    private void test_case_1()
    {
        string[] Arg0 = new string[]{"........",
 ".1......",
 "........",
 "....3...",
 "........",
 "........",
 ".7......",
 "........"}; int Arg1 = 2; verify_case(1, Arg1, minimalMoves(Arg0));
    }
    private void test_case_2()
    {
        string[] Arg0 = new string[]{"..",
 "2.",
 ".."}; int Arg1 = 0; verify_case(2, Arg1, minimalMoves(Arg0));
    }
    private void test_case_3() { string[] Arg0 = new string[] { ".1....1." }; int Arg1 = -1; verify_case(3, Arg1, minimalMoves(Arg0)); }
    private void test_case_4()
    {
        string[] Arg0 = new string[]{"9133632343",
 "5286698232",
 "8329333369",
 "5425579782",
 "4465864375",
 "8192124686",
 "3191624314",
 "5198496853",
 "1638163997",
 "6457337215"}; int Arg1 = 121; verify_case(4, Arg1, minimalMoves(Arg0));
    }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            CollectingRiders ___test = new CollectingRiders();
            ___test.run_test(-1);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.ToString());
        }
    }
    // END CUT HERE
}