using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GrabbingTaxi {
    public int minTime(int[] tXs, int[] tYs, int gX, int gY, int walkTime, int taxiTime)
    {
        int res = (Math.Abs(gX) + Math.Abs(gY))*walkTime;
        int i;
        for (i = 0; i < tXs.Length; i++)
        {
            int distwa = Math.Abs(tXs[i]);
            distwa += Math.Abs(tYs[i]);
            int disttax = Math.Abs(tXs[i] - gX);
            disttax += Math.Abs(tYs[i] - gY);
            res = Math.Min(res, disttax * taxiTime + distwa * walkTime);
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
	private void test_case_0() { int[] Arg0 = new int[]{}; int[] Arg1 = new int[]{}; int Arg2 = 3; int Arg3 = 2; int Arg4 = 10; int Arg5 = 2; int Arg6 = 50; verify_case(0, Arg6, minTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int[] Arg0 = new int[]{-2, -2}; int[] Arg1 = new int[]{0, -2}; int Arg2 = -4; int Arg3 = -2; int Arg4 = 15; int Arg5 = 3; int Arg6 = 42; verify_case(1, Arg6, minTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int[] Arg0 = new int[]{3}; int[] Arg1 = new int[]{0}; int Arg2 = 5; int Arg3 = 0; int Arg4 = 10; int Arg5 = 20; int Arg6 = 50; verify_case(2, Arg6, minTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int[] Arg0 = new int[]{34, -12, 1, 0, 21, -43, -98, 11, 86, -31}; int[] Arg1 = new int[]{11, 5, -68, 69, -78, -49, -36, -2, 1, 70}; int Arg2 = -97; int Arg3 = -39; int Arg4 = 47; int Arg5 = 13; int Arg6 = 2476; verify_case(3, Arg6, minTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_4() { int[] Arg0 = new int[]{82, -60, 57, 98, 30, -67, 84, -42, -100, 62}; int[] Arg1 = new int[]{-7, 90, 53, -56, -15, -87, 22, -3, -61, -30}; int Arg2 = 21; int Arg3 = 15; int Arg4 = 53; int Arg5 = 2; int Arg6 = 1908; verify_case(4, Arg6, minTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GrabbingTaxi ___test = new GrabbingTaxi();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
