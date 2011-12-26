using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ProgrammingDevice {
    public int minPackets(int[] offset, int[] size, int maxData)
    {
        long[] dp = new long[size.Length + 1];
        int i, j;
        for (i = 0; i < size.Length; i++)
        {
            for (j = i + 1; j < size.Length; j++)
            {
                if (offset[i] > offset[j])
                {
                    int temp;
                    temp = offset[j];
                    offset[j] = offset[i];
                    offset[i] = temp;
                    temp = size[j];
                    size[j] = size[i];
                    size[i] = temp;
                }
            }
        }
        for (i = 0; i < size.Length; i++) dp[i + 1] = int.MaxValue;
        dp[0] = 0;
        for (i = 0; i < size.Length; i++)
        {
            long min = offset[i];
            for (j = i; j < size.Length; j++)
            {
                long max = offset[j] + (long)size[j];
                long add = (max - min + maxData - 1) / maxData;
                dp[j + 1] = Math.Min(dp[j + 1], dp[i] + add);
            }
        }

        return (int) dp[size.Length];
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{0, 10, 20, 30}; int[] Arg1 = new int[]{8, 5, 3, 11}; int Arg2 = 6; int Arg3 = 6; verify_case(0, Arg3, minPackets(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{0, 10, 20, 30}; int[] Arg1 = new int[]{8, 2, 3, 11}; int Arg2 = 6; int Arg3 = 5; verify_case(1, Arg3, minPackets(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{15, 95}; int[] Arg1 = new int[]{1, 20}; int Arg2 = 100; int Arg3 = 1; verify_case(2, Arg3, minPackets(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{77, 7777, 777}; int[] Arg1 = new int[]{700, 70000, 7000}; int Arg2 = 1; int Arg3 = 77700; verify_case(3, Arg3, minPackets(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{0,1000000000}; int[] Arg1 = new int[]{1000000000,1000000000}; int Arg2 = 2000000000; int Arg3 = 1; verify_case(4, Arg3, minPackets(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int[] Arg0 = new int[]{0,1000000000}; int[] Arg1 = new int[]{1000000000,1000000000}; int Arg2 = 1; int Arg3 = 2000000000; verify_case(5, Arg3, minPackets(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ProgrammingDevice ___test = new ProgrammingDevice();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
