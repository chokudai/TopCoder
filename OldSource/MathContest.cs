using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MathContest
{
    public int countBlack(string ballSequence, int repetitions)
    {
        int len = ballSequence.Length * repetitions;
        bool[] b = new bool[len];
        int i;
        for (i = 0; i < len; i++)
        {
            if (ballSequence[i % ballSequence.Length] == 'W')
            {
                b[i] = true;
            }
            else b[i] = false;
        }
        int start = 0;
        int end = len - 1;
        bool startpos = true;
        bool change = false;
        int res = 0;
        for (i = 0; i < len; i++)
        {
            bool now = false;
            if (startpos)
            {
                now = b[start] ^ change;
                start++;
            }
            else
            {
                now = b[end] ^ change;
                end--;
            }
            if (!now)
            {
                res++;
                change = change ^ true;
            }
            else
            {
                startpos = startpos ^ true;
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
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
    private void test_case_0() { string Arg0 = "BBWWB"; int Arg1 = 1; int Arg2 = 2; verify_case(0, Arg2, countBlack(Arg0, Arg1)); }
    private void test_case_1() { string Arg0 = "BBB"; int Arg1 = 10; int Arg2 = 1; verify_case(1, Arg2, countBlack(Arg0, Arg1)); }
    private void test_case_2() { string Arg0 = "BW"; int Arg1 = 10; int Arg2 = 20; verify_case(2, Arg2, countBlack(Arg0, Arg1)); }
    private void test_case_3() { string Arg0 = "WWWWWWWBWWWWWWWWWWWWWW"; int Arg1 = 1; int Arg2 = 2; verify_case(3, Arg2, countBlack(Arg0, Arg1)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            MathContest ___test = new MathContest();
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
