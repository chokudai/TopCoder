using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MonochromaticBoard {
    public int theMin(string[] board)
    {
        int res = 0;
        int i, j;
        bool[] tate = new bool[board.Length];
        bool[] yoko = new bool[board[0].Length];
        bool flag = true;
        for (i = 0; i < board.Length; i++)
        {
            for (j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'W')
                {
                    tate[i] = true;
                    yoko[j] = true;
                    flag = false;
                }
            }
        }
        if (flag) return Math.Min(board.Length, board[0].Length);
        for (i = 0; i < board.Length; i++) if (!tate[i]) res++;
        for (i = 0; i < board[0].Length; i++) if (!yoko[i]) res++;
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
	private void test_case_0() { string[] Arg0 = new string[]{"WBWBW",
 "BBBBB",
 "WBWBW",
 "WBWBW"}; int Arg1 = 3; verify_case(0, Arg1, theMin(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"BBBB",
 "BBBB",
 "BBBB"}; int Arg1 = 3; verify_case(1, Arg1, theMin(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"BBBBB",
 "BBBBB",
 "BBBBB",
 "BBBBB",
 "BBBBB",
 "BBBBB",
 "BBBBB",
 "BBBBB"}; int Arg1 = 5; verify_case(2, Arg1, theMin(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"WW",
 "WW"}; int Arg1 = 0; verify_case(3, Arg1, theMin(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"BBBBBBBB",
 "BBBBBBBB",
 "BBBBBBBB",
 "WBWBBBWB",
 "BBBBBBBB"}; int Arg1 = 9; verify_case(4, Arg1, theMin(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MonochromaticBoard ___test = new MonochromaticBoard();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
