using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MazeMaker {

    int r, c;
    int[,] board;
    List<int> memo;
    List<int> next;

    public int longestPath(string[] maze, int startRow, int startCol, int[] moveRow, int[] moveCol)
    {
        r = maze.Length;
        c = maze[0].Length;
        board = new int[r, c];
        int i, j;
        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {
                if (maze[i][j] == '.') board[i, j] = 9999999;
                else board[i, j] = -2;
            }
        }
        board[startRow,startCol] = 0;
        memo = new List<int>();
        memo.Add((startRow << 8) + startCol);
        int res = 1;
        while (memo.Count != 0)
        {
            next = new List<int>();
            foreach (int nextnum in memo)
            {
                int nextr = nextnum >> 8;
                int nextc = nextnum % 256;
                for (i = 0; i < moveCol.Length; i++)
                {
                    int R = nextr + moveRow[i];
                    int C = nextc + moveCol[i];
                    if (ok(R, C))
                    {
                        if (board[R, C] != -2 && board[R, C] > res)
                        {
                            next.Add((R << 8) + C);
                            board[R, C] = res;
                        }
                    }
                }
            }
            //Console.WriteLine(next.Count);
            memo.Clear();
            foreach (int aaa in next) memo.Add(aaa);
            next.Clear();
            res++;
        }
        res = 0;
        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {
                res = Math.Max(res, board[i, j]);
                //if (board[i, j] > 0 && board[i, j] < 10) Console.Write(board[i, j]);
                //else Console.Write("X");
            }
            //Console.WriteLine();
        }
        if (res == 9999999) return -1;
        else return res;
    }

    bool ok(int a, int b)
    {
        return a >= 0 && b >= 0 && a < r && b < c;
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
	private void test_case_0() { string[] Arg0 = new string[]{"...",
 "...",
 "..."}; int Arg1 = 0; int Arg2 = 1; int[] Arg3 = new int[]{1,0,-1,0}; int[] Arg4 = new int[]{0,1,0,-1}; int Arg5 = 3; verify_case(0, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { string[] Arg0 = new string[]{"...",
 "...",
 "..."}; int Arg1 = 0; int Arg2 = 1; int[] Arg3 = new int[]{1, 0, -1, 0, 1, 1, -1, -1}; int[] Arg4 = new int[]{0, 1, 0, -1, 1, -1, 1, -1}; int Arg5 = 2; verify_case(1, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { string[] Arg0 = new string[]{"X.X",
 "...",
 "XXX",
 "X.X"}; int Arg1 = 0; int Arg2 = 1; int[] Arg3 = new int[]{1, 0, -1, 0}; int[] Arg4 = new int[]{0, 1, 0, -1}; int Arg5 = -1; verify_case(2, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { string[] Arg0 = new string[]{".......",
 "X.X.X..",
 "XXX...X",
 "....X..",
 "X....X.",
 "......."}; int Arg1 = 5; int Arg2 = 0; int[] Arg3 = new int[]{1, 0, -1, 0,-2, 1}; int[] Arg4 = new int[]{0, -1, 0, 1, 3, 0}; int Arg5 = 7; verify_case(3, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { string[] Arg0 = new string[]{"......."}; int Arg1 = 0; int Arg2 = 0; int[] Arg3 = new int[]{1, 0, 1, 0, 1, 0}; int[] Arg4 = new int[]{0, 1, 0, 1, 0, 1}; int Arg5 = 6; verify_case(4, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_5() { string[] Arg0 = new string[]{"..X.X.X.X.X.X."}; int Arg1 = 0; int Arg2 = 0; int[] Arg3 = new int[]{2,0,-2,0}; int[] Arg4 = new int[]{0,2,0,-2}; int Arg5 = -1; verify_case(5, Arg5, longestPath(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MazeMaker ___test = new MazeMaker();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
