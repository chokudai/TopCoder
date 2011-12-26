using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DucksAlignment {
    public int minimumTime(string[] grid)
    {
        List<int> lx = new List<int>();
        List<int> ly = new List<int>();
        int i, j;
        for (i = 0; i < grid.Length; i++)
        {
            for (j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 'o')
                {
                    lx.Add(j);
                    ly.Add(i);
                }
            }
        }
        int ret = int.MaxValue;
        for (i = 0; i < grid.Length; i++)
        {
            int now = 0;
            foreach (int a in ly)
            {
                now += Math.Abs(i - a);
            }
            ret = Math.Min(now, ret);
        }
        int ret2 = int.MaxValue;
        for (j = 0; j < grid[0].Length; j++)
        {
            int now = 0;
            foreach (int a in lx)
            {
                now += Math.Abs(j - a);
            }
            ret2 = Math.Min(now, ret2);
        }
        //Console.WriteLine(ret + " " + ret2);

        int res = ret + ret2;
        for (i = 0; i < lx.Count; i++)
        {
            res -= (i + 1) / 2;
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
	private void test_case_0() { string[] Arg0 = new string[]{".o",
 "o."}; int Arg1 = 1; verify_case(0, Arg1, minimumTime(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{".o...",
 "..o..",
 "....o"}; int Arg1 = 3; verify_case(1, Arg1, minimumTime(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"o..........",
 "..o........",
 ".......o...",
 "...........",
 "...........",
 "...........",
 "........o..",
 "..........."}; int Arg1 = 16; verify_case(2, Arg1, minimumTime(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{".........",
 "....o....",
 "........."}; int Arg1 = 0; verify_case(3, Arg1, minimumTime(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"...o..........................",
 "............................o.",
 ".o............................",
 "............o.................",
 ".................o............",
 "......................o.......",
 "......o.......................",
 "....o.........................",
 "...............o..............",
 ".......................o......",
 "...........................o..",
 ".......o......................"}; int Arg1 = 99; verify_case(4, Arg1, minimumTime(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
DucksAlignment ___test = new DucksAlignment();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
