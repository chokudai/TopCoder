using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Islands {
    public int beachLength(string[] kingdom)
    {
        int i, j;
        int res = 0;
        for (i = 0; i < kingdom.Length; i++)
        {
            int a = 0;
            if (i % 2 == 0) a = -1;
            if (i != kingdom.Length - 1)
            {
                for (j = 0; j < kingdom[i].Length; j++)
                {
                    int num;
                    num = j + a;
                    if (num < 0 || num >= kingdom[i].Length) ;
                    else if (kingdom[i][j] != kingdom[i + 1][num]) res++;
                    num = j + a + 1;
                    if (num < 0 || num >= kingdom[i].Length) ;
                    else if (kingdom[i][j] != kingdom[i + 1][num]) res++;
                }
            }
            for (j = 0; j < kingdom[i].Length-1; j++)
            {
                if (kingdom[i][j] != kingdom[i][j + 1]) res++;
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{".#...#.."}; int Arg1 = 4; verify_case(0, Arg1, beachLength(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"..#.##", 
 ".##.#.", 
 "#.#..."}; int Arg1 = 19; verify_case(1, Arg1, beachLength(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"#...#.....",
 "##..#...#."}; int Arg1 = 15; verify_case(2, Arg1, beachLength(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"....#.",
 ".#....",
 "..#..#",
 "####.."}; int Arg1 = 24; verify_case(3, Arg1, beachLength(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Islands ___test = new Islands();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
