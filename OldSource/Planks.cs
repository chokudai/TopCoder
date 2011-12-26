using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Planks {
    public int makeSimilar(int[] lengths, int costPerCut, int woodValue)
    {
        int result = 0;
        int i,j;
        for (i = 1; i <= 10000; i++)
        {
            int now = 0;
            for (j = 0; j < lengths.Length; j++)
            {
                int plus = 0;
                plus += lengths[j] / i * woodValue * i;
                if (lengths[j] % i == 0 && lengths[j] >= i) plus -= (lengths[j] / i - 1) * costPerCut;
                else plus -= (lengths[j] / i) * costPerCut;
                now += Math.Max(0, plus);
            }
            result = Math.Max(result, now);
        }
        return result;
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
	private void test_case_0() { int[] Arg0 = new int[]{26,103,59}; int Arg1 = 1; int Arg2 = 10; int Arg3 = 1770; verify_case(0, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{26,103,59}; int Arg1 = 10; int Arg2 = 10; int Arg3 = 1680; verify_case(1, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{26,103,59}; int Arg1 = 100; int Arg2 = 10; int Arg3 = 1230; verify_case(2, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{5281,5297,5303,5309,5323,5333,5347,5351,5381,5387}; int Arg1 = 5; int Arg2 = 20; int Arg3 = 1057260; verify_case(3, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{31,73,127,179,181,191,283,353,359,1019} ; int Arg1 = 25; int Arg2 = 10; int Arg3 = 25145; verify_case(4, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int[] Arg0 = new int[]{200,200,200,400}; int Arg1 = 1000; int Arg2 = 1; int Arg3 = 600; verify_case(5, Arg3, makeSimilar(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Planks ___test = new Planks();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
