using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxCardGame {
    public double theMaxProportion(double[] pileA, double[] pileB, int k)
    {
        int i, j;
        double res = double.MinValue;
        Array.Sort(pileA);
        Array.Sort(pileB);
        for (i = 0; i < k; i++)
        {
            double jiro = 0;
            double hanako = 0;
            for (j = 0; j < k - i; j++)
            {
                double a = pileA[j] + pileB[j];
                double b = pileA[j] * pileB[j];
                jiro += Math.Max(a, b);
                hanako += Math.Min(a, b);
            }
            for (j = pileA.Length - i; j < pileA.Length; j++)
            {
                double a = pileA[j] + pileB[j];
                double b = pileA[j] * pileB[j];
                jiro += Math.Max(a, b);
                hanako += Math.Min(a, b);
            }
            res = Math.Max(res, jiro / hanako);
        }

        return res;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { double[] Arg0 = new double[]{1, 2, 3}; double[] Arg1 = new double[]{4, 5, 6}; int Arg2 = 2; double Arg3 = 1.7692307692309948; verify_case(0, Arg3, theMaxProportion(Arg0, Arg1, Arg2)); }
	private void test_case_1() { double[] Arg0 = new double[]{1.234, 5.678, 9.012, 3.456, 7.89}; double[] Arg1 = new double[]{2.345, 6.789, 9.876, 5.432, 1.012}; int Arg2 = 3; double Arg3 = 4.159424420079586; verify_case(1, Arg3, theMaxProportion(Arg0, Arg1, Arg2)); }
	private void test_case_2() { double[] Arg0 = new double[]{1, 1.1, 1.2, 1.3, 1.4, 1.5}; double[] Arg1 = new double[]{5, 10, 15, 20, 25, 30}; int Arg2 = 2; double Arg3 = 1.3972602739726827; verify_case(2, Arg3, theMaxProportion(Arg0, Arg1, Arg2)); }
	private void test_case_3() { double[] Arg0 = new double[]{85.302, 92.798, 76.813, 37.994, 36.737, 98.659}; double[] Arg1 = new double[]{13.352, 7.3094, 54.761, 8.2706, 63.223, 37.486}; int Arg2 = 3; double Arg3 = 33.58603889836175; verify_case(3, Arg3, theMaxProportion(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxCardGame ___test = new FoxCardGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
