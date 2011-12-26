using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TileMatch {
    public int uncolor(string[] pattern)
    {
        int len = pattern.Length;
        bool[,] board = new bool[4, len + 2];
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            if (pattern[0][i] == 'X') board[0, i + 1] = true;
            if (pattern[i][len - 1] == 'X') board[1, i + 1] = true;
            if (pattern[len - 1][len - 1 - i] == 'X') board[2, i + 1] = true;
            if (pattern[len - 1 - i][0] == 'X') board[3, i + 1] = true;
        }
        bool[] ok = new bool[len];
        int prev = -1;
        int sum = 0;
        for (j = 0; j < len; j++) ok[j] = true;
        while (sum > prev)
        {
            prev = sum;
            for (j = 0; j < len; j++)
            {
                for (i = 0; i < 4; i++)
                {
                    for (k = -1; k <= 1; k++)
                    {
                        if (board[i, len - j + k]) break;
                    }
                    if (k == 2) break;
                }
                if (i != 4)
                {
                    ok[j] = false;
                }
            }
            ok[0] |= ok[len - 1];
            ok[len - 1] |= ok[0];
            for (j = 0; j < len; j++)
            {
                if (!ok[j])
                {
                    for (i = 0; i < 4; i++)
                    {
                        if (board[i, j + 1])
                        {
                            if (j != len - 1) sum++;
                            board[i, j + 1] = false;
                        }
                    }
                }
            }
        }
        return sum;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"XXX",
 "XXX",
 "---"}; int Arg1 = 5; verify_case(0, Arg1, uncolor(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"XXX",
 "XXX",
 "-X-"}; int Arg1 = 0; verify_case(1, Arg1, uncolor(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"XXXX",
 "XXXX",
 "-X--",
 "XX--"}; int Arg1 = 3; verify_case(2, Arg1, uncolor(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"XX--",
 "---X",
 "X---",
 "--X-"}; int Arg1 = 0; verify_case(3, Arg1, uncolor(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"-XX-",
 "XXXX",
 "XXXX",
 "---X"}; int Arg1 = 7; verify_case(4, Arg1, uncolor(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"---X--",
 "-----X",
 "------",
 "------",
 "X-----",
 "----X-"}; int Arg1 = 4; verify_case(5, Arg1, uncolor(Arg0)); }
	private void test_case_6() { string[] Arg0 = new string[]{"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXX-",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XX--X-X-XX-XX-XXXXX-X-XXX-X-X--XXXXXXXXXXXXXXXXXXX",
 "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"}; int Arg1 = 170; verify_case(6, Arg1, uncolor(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TileMatch ___test = new TileMatch();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
