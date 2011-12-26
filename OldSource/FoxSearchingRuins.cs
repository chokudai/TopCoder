using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxSearchingRuins {
    public long theMinTime(int W, int H, int jewelCount, int LR, int goalValue, int timeX, int timeY, int[] seeds)
    {
        int[] x = new int[jewelCount];
        int[] y = new int[jewelCount];
        int[] z = new int[jewelCount];
        int i, j, k;
        long res = long.MaxValue;
        x[0] = (int)(((long)seeds[1] * seeds[0] + seeds[2]) % W);
        y[0] = (int)(((long)seeds[4] * seeds[3] + seeds[5]) % H);
        v[0] = (int)(((long)seeds[7] * seeds[6] + seeds[8]) % seeds[9]);
        for (i = 0; i < jewelCount; i++)
        {
            x[i] = (int)(((long)seeds[1] * x[i - 1] + seeds[2]) % W);
            y[i] = (int)(((long)seeds[4] * y[i - 1] + seeds[5]) % H);
            v[i] = (int)(((long)seeds[7] * v[i - 1] + seeds[8]) % seeds[9]);
        }
        int[] yar = y.Clone();
        Array.Sort(yar);
        int count = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (i = 0; i < yar.Length; i++)
        {
            if (dic.ContainsKey(yar[i])) continue;
            dic[yar[i]] = count;
            count++;
        }
        List<int>[] li = new List<int>[count];
        for (i = 0; i < count; i++) li[i] = new List<int>();
        long[] dp = new long[W, LR + 1];
        for (i = 0; i < count; i++)
        {
            for (j = 0; j < W; j++)
            {
                ;
            }
        }


        if (res == long.MaxValue) return -1;
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 5; int Arg1 = 8; int Arg2 = 5; int Arg3 = 7; int Arg4 = 10; int Arg5 = 3; int Arg6 = 1; int[] Arg7 = new int[]{979, 777, 878, 646, 441, 545, 789, 896, 987, 10}; long Arg8 = 5l; verify_case(0, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }
	private void test_case_1() { int Arg0 = 7; int Arg1 = 8; int Arg2 = 10; int Arg3 = 3; int Arg4 = 10; int Arg5 = 3; int Arg6 = 10; int[] Arg7 = new int[]{0, 1, 1, 0, 1, 3, 1011, 3033, 2022, 10}; long Arg8 = 29l; verify_case(1, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }
	private void test_case_2() { int Arg0 = 7; int Arg1 = 8; int Arg2 = 10; int Arg3 = 3; int Arg4 = 14; int Arg5 = 3; int Arg6 = 10; int[] Arg7 = new int[]{0, 1, 1, 0, 1, 3, 1011, 3033, 2022, 10}; long Arg8 = 59l; verify_case(2, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }
	private void test_case_3() { int Arg0 = 7; int Arg1 = 8; int Arg2 = 10; int Arg3 = 4; int Arg4 = 14; int Arg5 = 3; int Arg6 = 10; int[] Arg7 = new int[]{0, 1, 1, 0, 1, 3, 1011, 3033, 2022, 10}; long Arg8 = 42l; verify_case(3, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }
	private void test_case_4() { int Arg0 = 497; int Arg1 = 503; int Arg2 = 989; int Arg3 = 647; int Arg4 = 100000; int Arg5 = 13; int Arg6 = 14; int[] Arg7 = new int[]{7613497, 5316789, 1334537, 2217889, 6349551, 978463, 1234567, 2345678, 3456789, 1000}; long Arg8 = -1l; verify_case(4, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }
	private void test_case_5() { int Arg0 = 1000; int Arg1 = 749613275; int Arg2 = 1000; int Arg3 = 1000; int Arg4 = 7500000; int Arg5 = 97; int Arg6 = 6; int[] Arg7 = new int[]{224284427, 617001937, 294074399, 606566321, 202762619, 419798101, 200613401, 640663967, 417565817, 170000}; long Arg8 = 3780225876l; verify_case(5, Arg8, theMinTime(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxSearchingRuins ___test = new FoxSearchingRuins();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
