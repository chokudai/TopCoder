using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RobotSimulation {
    public int cellsVisited(string program, int times)
    {
        int i, j;
        int x, y;
        x = y = 0;
        int res = 1;
        int nokori = program.Length;
        Dictionary<int, int> dic = new Dictionary<int,int>();
        bool[] b = new bool[program.Length];
        int flag = 0;
        dic[0] = 0;
        for (j = 0; j < times; j++)
        {
            for (i = 0; i < program.Length; i++)
            {

                if (program[i] == 'U') y++;
                else if (program[i] == 'D') y--;
                else if (program[i] == 'R') x++;
                else if (program[i] == 'L') x--;
                if (!dic.ContainsKey(hash(x, y)))
                {
                    dic[hash(x, y)] = j;
                    res++;
                }
                else
                {
                    if (!b[i]) { flag = 0; b[i] = true; nokori--; }
                }
            }
            flag++;
            if (flag > 3)
            {
                res += nokori * (times - j - 1);
                break;
            } 
        }
        return res;
    }

    int hash(int a, int b)
    {
        return a * 10000 + b;
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
	private void test_case_0() { string Arg0 = "RRR"; int Arg1 = 100; int Arg2 = 301; verify_case(0, Arg2, cellsVisited(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "DDU"; int Arg1 = 100; int Arg2 = 102; verify_case(1, Arg2, cellsVisited(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "URLD"; int Arg1 = 100; int Arg2 = 3; verify_case(2, Arg2, cellsVisited(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "UUDUDDLLDR"; int Arg1 = 1; int Arg2 = 7; verify_case(3, Arg2, cellsVisited(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "UUDUDDLLDR"; int Arg1 = 12345678; int Arg2 = 37037039; verify_case(4, Arg2, cellsVisited(Arg0, Arg1)); }
	private void test_case_5() { string Arg0 = "RRUUULLDD"; int Arg1 = 3603602; int Arg2 = 10810815; verify_case(5, Arg2, cellsVisited(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RobotSimulation ___test = new RobotSimulation();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
