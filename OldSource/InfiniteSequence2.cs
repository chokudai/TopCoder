using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InfiniteSequence2
{
    public long calc(long n, int p, int q, int x, int y)
    {

    }

    // BEGIN CUT HERE
    public void run_test(int Case)
    {
        if ((Case == -1) || (Case == 0)) test_case_0();
        if ((Case == -1) || (Case == 1)) test_case_1();
        if ((Case == -1) || (Case == 2)) test_case_2();
        if ((Case == -1) || (Case == 3)) test_case_3();
        if ((Case == -1) || (Case == 4)) test_case_4();
        if ((Case == -1) || (Case == 5)) test_case_5();
    }
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
    private void test_case_0() { long Arg0 = 10000000l; int Arg1 = 2; int Arg2 = 3; int Arg3 = 10000000; int Arg4 = 10000000; long Arg5 = 2l; verify_case(0, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }
    private void test_case_1() { long Arg0 = 12l; int Arg1 = 2; int Arg2 = 3; int Arg3 = 1; int Arg4 = 0; long Arg5 = 8l; verify_case(1, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }
    private void test_case_2() { long Arg0 = 0l; int Arg1 = 2; int Arg2 = 2; int Arg3 = 0; int Arg4 = 0; long Arg5 = 1l; verify_case(2, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }
    private void test_case_3() { long Arg0 = 123l; int Arg1 = 45; int Arg2 = 67; int Arg3 = 8; int Arg4 = 9; long Arg5 = 2l; verify_case(3, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }
    private void test_case_4() { long Arg0 = 10000000000000l; int Arg1 = 2; int Arg2 = 2; int Arg3 = 123; int Arg4 = 1234566; long Arg5 = 54025419l; verify_case(4, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }
    private void test_case_5() { long Arg0 = 10000000000000l; int Arg1 = 2; int Arg2 = 2; int Arg3 = 0; int Arg4 = 390012; long Arg5 = 250626223l; verify_case(5, Arg5, calc(Arg0, Arg1, Arg2, Arg3, Arg4)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            InfiniteSequence2 ___test = new InfiniteSequence2();
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
