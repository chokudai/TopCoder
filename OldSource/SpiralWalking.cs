using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SpiralWalking {
    
    bool[,] b;
    int h, w;

    public int totalPoints(string[] levelMap)
    {
        int[] vx = new int[] { 1, 0, -1, 0 };
        int[] vy = new int[] { 0, 1, 0, -1 };
        int count = 0;
        int y = 0;
        int x = 0;
        h = levelMap.Length;
        w = levelMap[0].Length;
        int i, j;
        int max = h * w;
        b = new bool[h, w];
        int now = 0;
        for (i = 0; i < max; i++)
        {
            b[y, x] = true;
            int ny = y + vy[now];
            int nx = x + vx[now];
            if (!ok(ny, nx) && i != max - 1)
            {
                now = (now + 1) % 4;
                ny = y + vy[now];
                nx = x + vx[now];
            }
            else count += levelMap[y][x] - '0';
            y = ny;
            x = nx;
        }
        return count;
    }

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y < h && x < w && !b[y, x];
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
	private void test_case_0() { string[] Arg0 = new string[]{"111",
 "111",
 "111"}; int Arg1 = 5; verify_case(0, Arg1, totalPoints(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"101",
 "110"}; int Arg1 = 3; verify_case(1, Arg1, totalPoints(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"00",
 "10"}; int Arg1 = 1; verify_case(2, Arg1, totalPoints(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"86850",
 "76439",
 "15863",
 "24568",
 "45679",
 "71452",
 "05483"}; int Arg1 = 142; verify_case(3, Arg1, totalPoints(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SpiralWalking ___test = new SpiralWalking();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
