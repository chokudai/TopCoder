using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OneDimensionalBalls
{
    public long countValidGuesses(int[] firstPicture, int[] secondPicture)
    {
        int i, j, k;
        Dictionary<int, int> useddist = new Dictionary<int, int>();
        Dictionary<int, int> second = new Dictionary<int, int>();
        for (j = 0; j < secondPicture.Length; j++) second[secondPicture[j]] = 1;
        long res = 0;
        Array.Sort(firstPicture);
        Array.Sort(secondPicture);
        for (i = 0; i < firstPicture.Length; i++)
        {
            for (j = 0; j < secondPicture.Length; j++)
            {
                int dist = Math.Abs(firstPicture[i] - secondPicture[j]);
                if (useddist.ContainsKey(dist)) continue;
                useddist[dist] = 1;
                if (dist == 0) continue;

                int[] num = new int[firstPicture.Length]; // base number
                int[] connect = new int[firstPicture.Length];// conneting
                int[] has = new int[secondPicture.Length]; //can connect
                Dictionary<int, int> pre = new Dictionary<int, int>();
                for (k = 0; k < firstPicture.Length; k++)
                {
                    int back = firstPicture[k] - dist;
                    int next = firstPicture[k] + dist;
                    int now = k;
                    if (second.ContainsKey(back))
                    {
                        if (pre.ContainsKey(back))
                        {
                            now = pre[back];
                        }
                        else
                        {
                            has[now]++;
                        }
                    }
                    if (second.ContainsKey(next))
                    {
                        has[now]++;
                        pre[next] = now;
                    }

                    connect[now]++;
                    num[k] = now;
                }
                long add = 1;
                for (k = 0; k < firstPicture.Length; k++)
                {
                    if (connect[k] != 0)
                    {
                        if (connect[k] < has[k])
                        {
                            add *= connect[k] + 1;
                        }
                        else if (connect[k] == has[k])
                        {
                            add *= 1;
                        }
                        else
                        {
                            add = 0;
                            break;
                        }
                    }
                }
                res += add;
            }
        }
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
    private void verify_case(int Case, long Expected, long Received)
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
    private void test_case_0() { int[] Arg0 = new int[] { 12, 11 }; int[] Arg1 = new int[] { 10, 11, 13 }; long Arg2 = 3l; verify_case(0, Arg2, countValidGuesses(Arg0, Arg1)); }
    private void test_case_1() { int[] Arg0 = new int[] { 1, 2, 3 }; int[] Arg1 = new int[] { 1, 2, 3 }; long Arg2 = 0l; verify_case(1, Arg2, countValidGuesses(Arg0, Arg1)); }
    private void test_case_2() { int[] Arg0 = new int[] { 1, 3 }; int[] Arg1 = new int[] { 1, 3 }; long Arg2 = 1l; verify_case(2, Arg2, countValidGuesses(Arg0, Arg1)); }
    private void test_case_3() { int[] Arg0 = new int[] { 7234 }; int[] Arg1 = new int[] { 6316, 689156, 689160, 689161, 800000, 1000001 }; long Arg2 = 6l; verify_case(3, Arg2, countValidGuesses(Arg0, Arg1)); }
    private void test_case_4() { int[] Arg0 = new int[] { 6, 2, 4 }; int[] Arg1 = new int[] { 1, 2, 3, 4, 5, 7, 8 }; long Arg2 = 7l; verify_case(4, Arg2, countValidGuesses(Arg0, Arg1)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            OneDimensionalBalls ___test = new OneDimensionalBalls();
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