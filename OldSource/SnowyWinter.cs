using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SnowyWinter {
    public int snowyHighwayLength(int[] startPoints, int[] endPoints)
    {
        int MAX = 20000;
        bool[] b = new bool[MAX];
        int i,j;
        int len = startPoints.Length;
        for (i = 0; i < len; i++)
        {
            for (j = startPoints[i]; j < endPoints[i]; j++)
            {
                b[j] = true;
            }
        }
        int res = 0;
        for (i = 0; i < MAX; i++) if (b[i]) res++;
        return res;
        
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
	private void test_case_0() { int[] Arg0 = new int[]{17,85,57}; int[] Arg1 = new int[]{33,86,84}; int Arg2 = 44; verify_case(0, Arg2, snowyHighwayLength(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{45,100,125,10,15,35,30,9}; int[] Arg1 = new int[]{46,200,175,20,25,45,40,10}; int Arg2 = 132; verify_case(1, Arg2, snowyHighwayLength(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{4387,711,2510,1001,4687,3400,5254,584,284,1423,3755,929,2154,5719,1326,2368,554}; int[] Arg1 = new int[]{7890,5075,2600,6867,7860,9789,6422,5002,4180,7086,8615,9832,4169,7188,9975,8690,1423}; int Arg2 = 9691; verify_case(2, Arg2, snowyHighwayLength(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{4906,5601,5087,1020,4362,2657,6257,5509,5107,5315,277,6801,2136,2921,5233,5082,497,8250,3956,5720}; int[] Arg1 = new int[]{4930,9130,9366,2322,4687,4848,8856,6302,5496,5438,829,9053,4233,4119,9781,8034,3956,9939,4908,5928}; int Arg2 = 9510; verify_case(3, Arg2, snowyHighwayLength(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{51,807,943,4313,8319,3644,481,220,2161,448,465,1657,6290,22,6152,647,3185,4474,2168}; int[] Arg1 = new int[]{1182,912,1832,7754,9557,7980,4144,3194,7129,5535,1172,2043,6437,7252,9508,4745,8313,8020,4017}; int Arg2 = 9535; verify_case(4, Arg2, snowyHighwayLength(Arg0, Arg1)); }
	private void test_case_5() { int[] Arg0 = new int[]{8786,7391,201,4414,5822,5872,157,1832,7487,7518,2267,1763,3984,3102,7627,4099,524,1543,1022,3060}; int[] Arg1 = new int[]{9905,7957,3625,6475,9314,9332,4370,8068,8295,8177,7772,2668,7191,8480,9211,4802,2625,1924,9970,4180}; int Arg2 = 9813; verify_case(5, Arg2, snowyHighwayLength(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SnowyWinter ___test = new SnowyWinter();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
