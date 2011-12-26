using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MarbleMachine {
    int T = 60;
    int h, w;
    int len;
    int[,] l;
    
    public long maxMarbles(string[] layout, string[] actions, int t)
    {
        h = layout.Length;
        w = layout[0].Length;
        len = h * w + 1;
        long[,] board = new long[h, w];
        l = new int[h, w];
        int i, j, k;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                l[i, j] = layout[i][j] - '0';
            }
        }
        sim(board, actions, 60);
        long[,] matrix = new long[len, len];
        for (k = 0; k < len - 1; k++)
        {
            matrix[len - 1, k] = board[k / w, k % w];
        }
        matrix[len - 1, k] = 1;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                board = new long[h, w];
                board[i, j] = 1;
                sim(board, actions, T);
                for (k = 0; k < len - 1; k++)
                {
                    matrix[i * w + j, k] = board[k / w, k % w] - matrix[len - 1, k];
                }
            }
        }
        long[,] nmatrix = matrixpow(matrix, t / 60);
        board = new long[h, w];
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                board[i, j] = nmatrix[len - 1, i * w + j];
            }
        }
        sim(board, actions, t % 60);

        long res = 0;
        for (i = 0; i < h; i++) for (j = 0; j < w; j++) res = Math.Max(res, board[i, j]);
        return res;
    }

    long[,] matrixpow(long[,] matrix, long a)
    {
        if (a == 0)
        {
            long[,] res = new long[len, len];
            int i;
            for (i = 0; i < len; i++) res[i, i] = 1;
            return res;
        }
        else if (a % 2 == 0)
        {
            long[,] res = matrixpow(matrix, a / 2);
            return matrixmul(res, res);
        }
        else
        {
            return matrixmul(matrix, matrixpow(matrix, a - 1));
        }
    }

    long[,] matrixmul(long[,] matrixa, long[,] matrixb)
    {
        int i, j, k;
        long[,] res = new long[len, len];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                for (k = 0; k < len; k++)
                {
                    res[i, j] += matrixa[i, k] * matrixb[k, j];
                }
            }
        }
        return res;
    }

    void sim(long[,] board, string[] actions, int t)
    {
        int i, j, k;
        for (k = 0; k < t; k++)
        {
            long[,] nboard = new long[h, w];
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    string act = actions[l[i, j]];
                    char c = act[k%act.Length];
                    if (c == 'D')
                    {
                        continue;
                    }
                    else if (c == 'E')
                    {
                        int nexty = i;
                        int nextx = j + 1;
                        if (ok(nexty, nextx)) nboard[nexty, nextx] += board[i, j];
                    }
                    else if (c == 'W')
                    {
                        int nexty = i;
                        int nextx = j - 1;
                        if (ok(nexty, nextx)) nboard[nexty, nextx] += board[i, j];
                    }
                    else if (c == 'N')
                    {
                        int nexty = i - 1;
                        int nextx = j;
                        if (ok(nexty, nextx)) nboard[nexty, nextx] += board[i, j];
                    }
                    else if (c == 'S')
                    {
                        int nexty = i + 1;
                        int nextx = j;
                        if (ok(nexty, nextx)) nboard[nexty, nextx] += board[i, j];
                    }
                    else
                    {
                        int add = c - '0';
                        nboard[i, j] += board[i, j] + add;
                    }
                }
            }
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    board[i, j] = nboard[i, j];
                }
            }
        }
    }

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y < h && x < w;
    }







    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{
"0101",
"1010",
"0101"}; string[] Arg1 = new string[]{"4","5353"}; int Arg2 = 5; long Arg3 = 21l; verify_case(0, Arg3, maxMarbles(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"011112"}
; string[] Arg1 = new string[]{"1E","E","0"}; int Arg2 = 1000; long Arg3 = 498l; verify_case(1, Arg3, maxMarbles(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"01",
"32"}; string[] Arg1 = new string[]{"1E","SSDSS","W","00000W"}; int Arg2 = 23; long Arg3 = 3l; verify_case(2, Arg3, maxMarbles(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MarbleMachine ___test = new MarbleMachine();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
