using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SequenceOfCommands {

    int[] vy = new int[] { 1, 0, -1, 0 };
    int[] vx = new int[] { 0, 1, 0, -1 };

    public string whatHappens(string[] commands)
    {
        int x = 0, y = 0;
        int muki = 0;
        int i, j;
        string command = "";
        for (i = 0; i < commands.Length; i++) command += commands[i];
        for (i = 0; i < 4; i++)
        {
            for (j = 0; j < command.Length; j++)
            {
                if (command[j] == 'R')
                {
                    muki += 1;
                    muki %= 4;
                }
                else if (command[j] == 'L')
                {
                    muki += 3;
                    muki %= 4;
                }
                else
                {
                    x += vx[muki];
                    y += vy[muki];
                }
            }
        }
        if (x == 0 && y == 0) return "bounded";
        else return "unbounded";

    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"L"}; string Arg1 = "bounded"; verify_case(0, Arg1, whatHappens(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"SRSL"}; string Arg1 = "unbounded"; verify_case(1, Arg1, whatHappens(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"SSSS","R"}; string Arg1 = "bounded"; verify_case(2, Arg1, whatHappens(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"SRSL","LLSSSSSSL","SSSSSS","L"}; string Arg1 = "unbounded"; verify_case(3, Arg1, whatHappens(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SequenceOfCommands ___test = new SequenceOfCommands();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
