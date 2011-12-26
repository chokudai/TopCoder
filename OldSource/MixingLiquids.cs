using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MixingLiquids {
    public double howMuch(int[] percent, int[] amount, int need)
    {
        int i, j = 0,k;
        int len = percent.Length;
        for (k = 0; k < len; k++)
        {
            for (i = 0; i < len - 1; i++)
            {
                j = i + 1;
                if (percent[i] > percent[j])
                {
                    int temp;
                    temp = percent[i];
                    percent[i] = percent[j];
                    percent[j] = temp;
                    temp = amount[i];
                    amount[i] = amount[j];
                    amount[j] = temp;
                }
            }
        }
        double[] nokori = new double[len];
        for (i = 0; i < len; i++) nokori[i] = amount[i];
        for (i = 0; i < len; i++) if (percent[i] >= need) break;
        i--;
        j = i + 1;
        double res = 0;
        for (; i >= 0; i--)
        {
            if (percent[i] == need)
            {
                res += nokori[i];
                nokori[i] = 0;
            }
            else break;
        }
        for (; j < len; j++)
        {
            if (percent[j] == need)
            {
                res += nokori[j];
                nokori[j] = 0;
            }
            else break;
        }
        for (; i >= 0 && j < len; )
        {
            if (nokori[i] * (percent[i] - need) + nokori[j] * (percent[j] - need) <= 0)
            {
                res += nokori[j];
                res += nokori[j] * -(percent[j] - need) / (percent[i] - need);
                nokori[i] -= nokori[j] * -(percent[j] - need) / (percent[i] - need);
                nokori[j] = 0;
                j++;
            }
            else
            {
                res += nokori[i];
                res += nokori[i] * -(percent[i] - need) / (percent[j] - need);
                nokori[j] -= nokori[i] * -(percent[i] - need) / (percent[j] - need);
                nokori[i] = 0;
                i--;
            }
        }
        return res;
        
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{0, 100}; int[] Arg1 = new int[]{20, 30}; int Arg2 = 50; double Arg3 = 40.0; verify_case(0, Arg3, howMuch(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{0, 100}; int[] Arg1 = new int[]{20, 30}; int Arg2 = 60; double Arg3 = 50.0; verify_case(1, Arg3, howMuch(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{90, 70, 80}; int[] Arg1 = new int[]{10, 10, 10}; int Arg2 = 50; double Arg3 = 0.0; verify_case(2, Arg3, howMuch(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{30, 80, 60}; int[] Arg1 = new int[]{40, 10, 15}; int Arg2 = 57; double Arg3 = 35.18518518518519; verify_case(3, Arg3, howMuch(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{50,50,50}; int[] Arg1 = new int[]{395,971,964}; int Arg2 = 50; double Arg3 = 2330.0; verify_case(4, Arg3, howMuch(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        MixingLiquids ___test = new MixingLiquids();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
