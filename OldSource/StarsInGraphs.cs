using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StarsInGraphs {
    public int starryPaths(string[] adjacencyMatrix, int C)
    {
        int len = adjacencyMatrix.Length;
        int i, j, k;
        int[] star = new int[len];
        for (i = 0; i < 50; i++)
        {
            Console.WriteLine(i + " " + c(i));
        }
        for (i = 0; i < len; i++)
        {
            int count = 0;
            for (j = 0; j < len; j++)
            {
                if (adjacencyMatrix[i][j] == '1') count++;
            }
            star[i] = c(count);
        }
        return 0;
    }

    int c(int a)
    {
        int now = 1;
        int i;
        int res = 0;
        for (i = 0; i <= a; i++)
        {
            now *= a - i;
            now /= i + 1;
            if (i >= 2) res += now;
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
	private void test_case_0() { string[] Arg0 = new string[]{"01110",
 "10111",
 "00000",
 "00000",
 "00000"}; int Arg1 = 1000; int Arg2 = 2; verify_case(0, Arg2, starryPaths(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"01011",
 "00111",
 "10011",
 "00000",
 "00000"}; int Arg1 = 1; int Arg2 = -1; verify_case(1, Arg2, starryPaths(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0111",
 "0000",
 "0000",
 "0000"}; int Arg1 = 1; int Arg2 = 1; verify_case(2, Arg2, starryPaths(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"01111",
 "00000",
 "00000",
 "00000",
 "00000"}; int Arg1 = 4; int Arg2 = 0; verify_case(3, Arg2, starryPaths(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"010001100",
 "001001100",
 "000101110",
 "000010111",
 "000001111",
 "010000000",
 "000110000",
 "000100001",
 "100001000"}; int Arg1 = 10; int Arg2 = 5; verify_case(4, Arg2, starryPaths(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
StarsInGraphs ___test = new StarsInGraphs();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
