using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrinceOfPersia {

    int h, w;
    int[,] memo;
    int h1, w1, h2, w2;
    public int minObstacles(string[] maze)
    {
        h = maze.Length;
        w = maze[0].Length;
        memo = new int[h, w];
        h1 = w1 = -1;
        int i, j, k;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (maze[i][j] == '#') memo[i, j] = 1;
                else memo[i, j] = 0;
                if (maze[i][j] == 'P')
                {
                    if (h1 == -1)
                    {
                        h1 = i; w1 = j;
                    }
                    else
                    {
                        h2 = i; w2 = j;
                    }
                }
            }
        }
        if (Math.Abs(h1 - h2) + Math.Abs(w1 - w2) <= 1) return -1;
        if (check((int[,])memo.Clone())) return 0;
        for (i = 0; i < h * w; i++)
        {
            if (!put(i)) continue;
            if (check((int[,])memo.Clone())) return 1;
            remove(i);
        }
        for (i = 0; i < h * w; i++)
        {
            if (!put(i)) continue;
            for (j = i + 1; j < h * w; j++)
            {
                if (!put(j)) continue;
                if (check((int[,])memo.Clone())) return 2;
                remove(j);
            }
            remove(i);
        }
        for (i = 0; i < h * w; i++)
        {
            if (!put(i)) continue;
            for (j = i + 1; j < h * w; j++)
            {
                if (!put(j)) continue;
                for (k = j + 1; k < h * w; k++)
                {
                    if (!put(k)) continue;
                    if (check((int[,])memo.Clone())) return 3;
                    remove(k);
                }
                remove(j);
            }
            remove(i);
        }
        return 4;
    }

    bool put(int a)
    {
        int y = a / w;
        int x = a % w;
        if (memo[y, x] == 1) return false;
        memo[y, x] = 1;
        return true;
    }

    void remove(int a)
    {
        int y = a / w;
        int x = a % w;
        memo[y, x] = 0;
    }

    bool check(int[,] num)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(h1 * w + w1);
        int[] vx = new int[] { 1, 0, -1, 0 };
        int[] vy = new int[] { 0, 1, 0, -1 };
        while (q.Count != 0)
        {
            int now = q.Dequeue();
            int y = now / w;
            int x = now % w;
            for (int i = 0; i < 4; i++)
            {
                int ny = y + vy[i];
                int nx = x + vx[i];
                if (ok(ny, nx) && num[ny, nx] == 0)
                {
                    num[ny, nx] = 1;
                    q.Enqueue(ny * w + nx);
                }
                if (ny == h2 && nx == w2) return false;
            }
        }
        return true;
    }

    bool ok(int a, int b)
    {
        return a >= 0 && b >= 0 && a < h && b < w;
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
	private void test_case_0() { string[] Arg0 = new string[]{"P....",
 "...##",
 "##...",
 "....P"}
; int Arg1 = 1; verify_case(0, Arg1, minObstacles(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{".....",
 ".P.P.",
 "....."}; int Arg1 = 3; verify_case(1, Arg1, minObstacles(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{".#P.",
 ".P#."}; int Arg1 = 0; verify_case(2, Arg1, minObstacles(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"####",
 "#PP#",
 "####"}; int Arg1 = -1; verify_case(3, Arg1, minObstacles(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PrinceOfPersia ___test = new PrinceOfPersia();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
