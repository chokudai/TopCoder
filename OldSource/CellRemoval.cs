using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CellRemoval {
    public int cellsLeft(int[] parent, int deletedCell)
    {
        int len = parent.Length;
        int res = 0;
        bool[] flag = new bool[len];
        int i;
        for (i = 0; i < len; i++) if (parent[i] != -1) flag[parent[i]] = true;
        for (i = 0; i < len; i++)
        {
            if (flag[i]) continue;
            int now = i;
            do
            {
                if (now == deletedCell) break;
                now = parent[now];
            } while (now != -1);
            if (now == -1) res++;
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
	private void test_case_0() { int[] Arg0 = new int[]{-1,0,0,1,1}; int Arg1 = 2; int Arg2 = 2; verify_case(0, Arg2, cellsLeft(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{-1,0,0,1,1}; int Arg1 = 1; int Arg2 = 1; verify_case(1, Arg2, cellsLeft(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{-1,0,0,1,1}; int Arg1 = 0; int Arg2 = 0; verify_case(2, Arg2, cellsLeft(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{-1,0,0,2,2,4,4,6,6}; int Arg1 = 4; int Arg2 = 2; verify_case(3, Arg2, cellsLeft(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{26,2,32,36,40,19,43,24,30,13,21,14,24,21,19,4,30,10,44,12,7,32,17,43,
 35,18,7,36,10,16,5,38,35,4,13,-1,16,26,1,12,2,5,18,40,1,17,38,44,14}; int Arg1 = 24; int Arg2 = 14; verify_case(4, Arg2, cellsLeft(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CellRemoval ___test = new CellRemoval();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
