using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StepperMotor {
    public int rotateToNearest(int n, int current, int[] target)
    {
        int i;
        long j;
        int len = target.Length;
        long res = long.MaxValue;
        for (i = 0; i < len; i++)
        {
            long need = target[i] - (long)current;
            long center = need / n;
            for (j = center - 2; j <= center + 2; j++)
            {
                long now = target[i] - ((long)n * j + current);
                if (Math.Abs(now) < Math.Abs(res)) res = now;
                if (Math.Abs(now) == Math.Abs(res) && now >= 0) res = now;
            }
        }
        return (int)res;
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
	private void test_case_0() { int Arg0 = 10; int Arg1 = 0; int[] Arg2 = new int[]{-2, -3, 4, 5, 6, 9999999}; int Arg3 = -1; verify_case(0, Arg3, rotateToNearest(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 314159; int[] Arg2 = new int[]{10, 8, 6, 4, 2}; int Arg3 = 1; verify_case(1, Arg3, rotateToNearest(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = -2147483648; int[] Arg2 = new int[]{-2147483648, -2147483648, 2147483647, 2147483647}; int Arg3 = 0; verify_case(2, Arg3, rotateToNearest(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 23; int Arg1 = 10; int[] Arg2 = new int[]{64077, -567273, 105845, -279980, 35557,
-286190, -652879, -431665, -634870, -454044}; int Arg3 = -11; verify_case(3, Arg3, rotateToNearest(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 1000000000; int Arg1 = 1403466951; int[] Arg2 = new int[]{1233321992, 11423750, 1356595134, 1130863021, 1183514764,
1943494859, 1714480374, 1529875954, 1738756510, 1190153525}; int Arg3 = -46871817; verify_case(4, Arg3, rotateToNearest(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
StepperMotor ___test = new StepperMotor();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
