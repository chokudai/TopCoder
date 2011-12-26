using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HexagonPuzzle {
    long mod = 1000000007;
    int[] vx = new int[] { -1, 0, 1, 1, 0, -1 };
    int[] vy = new int[] { -1, -1, 0, 1, 1, 0 };
    int len;

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y < len && x < len && y >= x;
    }

    public int theCount(string[] board)
    {
        int i, j, k, l;
        long res = 1;
        len = board.Length;
        bool[,] b = new bool[len, len];

        for (i = 0; i < len; i++)
            for (j = 0; j < i; j++)
            {
                if (!b[i, j] && (board[i][j] != 'X'))
                {
                    Queue<int> q = new Queue<int>();
                    q.Enqueue(i * 100 + j);
                    b[i, j] = true;
                    int num = 0;
                    while (q.Count != 0)
                    {
                        num++;
                        int next = q.Dequeue();
                        int y = next / 100;
                        int x = next % 100;
                        for (k = 0; k < 6; k++)
                        {
                            int nexty = y + vy[k];
                            int nextx = x + vx[k];
                            bool flag = false;
                            for (l = 1; l <= 5; l += 4)
                            {
                                int ny = y + vy[(k + l) % 6];
                                int nx = x + vx[(k + l) % 6];
                                if (ok(ny, nx) && (board[ny][nx] != 'X')) flag = true;
                            }
                            if (ok(nexty, nextx)&& (board[nexty][nextx] != 'X') && !b[nexty, nextx] && flag)
                            {
                                b[nexty, nextx] = true;
                                q.Enqueue(nexty * 100 + nextx);
                            }
                        }
                    }
                    for (k = 3; k <= num; k++) res = (res * k) % mod;
                }
            }
        return (int)(res % mod);
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
	private void test_case_0() { string[] Arg0 = new string[]{".",
 ".X",
 "X..",
 ".X.X"}
; int Arg1 = 3; verify_case(0, Arg1, theCount(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"X"}
; int Arg1 = 1; verify_case(1, Arg1, theCount(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{".",
 "..",
 "...",
 ".X.."}
; int Arg1 = 20160; verify_case(2, Arg1, theCount(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{".",
 "..",
 "XXX",
 "..X.",
 ".X..X",
 "XXXX..",
 "..X.X.X",
 "..X.XX.."}
; int Arg1 = 108; verify_case(3, Arg1, theCount(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{".",
 "..",
 "...",
 "....",
 ".....",
 "......",
 ".......",
 "........"}; int Arg1 = 261547992; verify_case(4, Arg1, theCount(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {

    HexagonPuzzle ___test = new HexagonPuzzle();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
