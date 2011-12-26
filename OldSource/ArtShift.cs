using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ArtShift {


    long result;
    public int maxShifts(string sequence)
    {
        int w = 0;
        int b = 0;
        int i;
        for (i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == 'W') w++;
            else b++;
        }
        result = 0;
        saiki(w, b, 1, 2);
        return (int)result;
    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        return gcd(b, a % b);
    }

    void saiki(int a, int b, long res, int next)
    {
        result = Math.Max(result, res);
        //Console.WriteLine(res);
        if (a == 0 || b == 0) return;
        int i, j;
        for (i = next; i <= a + b; i++)
        {
            //Console.WriteLine("i:" + i + " " + a + " " + b);
            for (j = 1; j <= a; j++)
            {
                if (b - (i - j) >= 0 && i - j >= 1)
                {
                    saiki(a - j, b - (i - j), res * i / gcd(res, i), i + 1);
                }
            }
        }

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
	private void test_case_0() { string Arg0 = "BW"; int Arg1 = 2; verify_case(0, Arg1, maxShifts(Arg0)); }
	private void test_case_1() { string Arg0 = "BBBWBBB"; int Arg1 = 7; verify_case(1, Arg1, maxShifts(Arg0)); }
	private void test_case_2() { string Arg0 = "BWBWB"; int Arg1 = 6; verify_case(2, Arg1, maxShifts(Arg0)); }
	private void test_case_3() { string Arg0 = "WWWWWWWWW"; int Arg1 = 1; verify_case(3, Arg1, maxShifts(Arg0)); }
	private void test_case_4() { string Arg0 = "WWWWWWWWWBBWB"; int Arg1 = 60; verify_case(4, Arg1, maxShifts(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ArtShift ___test = new ArtShift();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
