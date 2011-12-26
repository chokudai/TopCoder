using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CorrectMultiplication {
    public long getMinimum(int a, int b, int c)
    {
        long ret = long.MaxValue;
        long MAX = 1000050000;
        long border = (long)Math.Sqrt(MAX);
        int i, j;
        a = 14275;
        b = 10372;
        c = 148210300;

        for (i = 1; i <= border + 1000; i++)
        {
            for (j = -2; j <= 2; j++)
            {
                long A = i;
                long B = c / i + j;
                while (A <= 0) A++;
                while (B <= 0) B++;
                ret = Math.Min(ret, Math.Abs(a - A) + Math.Abs(b - B) + Math.Abs(A * B - c));
                ret = Math.Min(ret, Math.Abs(a - B) + Math.Abs(b - A) + Math.Abs(A * B - c));
                if (ret == Math.Abs(a - A) + Math.Abs(b - B) + Math.Abs(A * B - c)) Console.WriteLine(A + " " + B);
                if (ret == Math.Abs(a - B) + Math.Abs(b - A) + Math.Abs(A * B - c)) Console.WriteLine(A + " " + B);
            }
        }
        return ret;
    }


    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 19; int Arg1 = 28; int Arg2 = 522; long Arg3 = 2l; verify_case(0, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 30; int Arg2 = 500; long Arg3 = 11l; verify_case(1, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 11111; int Arg1 = 11111; int Arg2 = 123454321; long Arg3 = 0l; verify_case(2, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 1000; int Arg1 = 100; int Arg2 = 10; long Arg3 = 1089l; verify_case(3, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 399; int Arg1 = 522; int Arg2 = 199999; long Arg3 = 24l; verify_case(4, Arg3, getMinimum(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            CorrectMultiplication ___test = new CorrectMultiplication();
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


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
