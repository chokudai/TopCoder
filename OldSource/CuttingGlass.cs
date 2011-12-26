using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CuttingGlass {

    int[] uni;
    public int pieces(int W, int H, int startx, int starty, string[] program)
    {
        int i, j,k;
        uni = new int[H*W];
        bool[,,] check = new bool[H, W, 4]; //U,L,D,R
        string st = "";
        for (i = 0; i < program.Length; i++)
        {
            st += program[i];
        }
        int X = startx;
        int Y = starty;
        for (i = 0; i < st.Length; i++)
        {
            char c = st[i];
            int a = 0;
            if (c == 'U') a = 0;
            else if (c == 'L') a = 1;
            else if (c == 'D') a = 2;
            else if (c == 'R') a = 3;
            if (a == 0)
            {
                int X1 = X - 1;
                int Y1 = Y - 1;
                int X2 = X;
                int Y2 = Y - 1;
                if (ok(W, H, X1, Y1)) check[Y1, X1, a] = true;
                if (ok(W, H, X2, Y2)) check[Y2, X2, a ^ 2] = true;
                Y--;
            }
            else if (a == 1)
            {
                int X1 = X - 1;
                int Y1 = Y - 1;
                int X2 = X - 1;
                int Y2 = Y;
                if (ok(W, H, X1, Y1)) check[Y1, X1, a] = true;
                if (ok(W, H, X2, Y2)) check[Y2, X2, a ^ 2] = true;
                X--;
            }
            else if (a == 2)
            {
                int X1 = X;
                int Y1 = Y;
                int X2 = X - 1;
                int Y2 = Y;
                if (ok(W, H, X1, Y1)) check[Y1, X1, a] = true;
                if (ok(W, H, X2, Y2)) check[Y2, X2, a ^ 2] = true;
                Y++;
            }
            else if (a == 3)
            {
                int X1 = X;
                int Y1 = Y;
                int X2 = X;
                int Y2 = Y - 1;
                if (ok(W, H, X1, Y1)) check[Y1, X1, a] = true;
                if (ok(W, H, X2, Y2)) check[Y2, X2, a ^ 2] = true;
                X++;
            }
        }
        for (i = 0; i < H * W; i++)
        {
            uni[i] = -1;
        }

        int[] vy = new int[4] { 0, 1, 0, -1};
        int[] vx = new int[4] { 1, 0, -1, 0};

        for (i = 0; i < H; i++)
        {
            for (j = 0; j < W; j++)
            {
                for (k = 0; k < 4; k++)
                {
                    if (check[i, j, k]) continue;
                    Y = i + vy[k];
                    X = j + vx[k];
                    if (!ok(W, H, X, Y)) continue;
                    int fir = i * W + j;
                    int sec = Y * W + X;
                    if (checkbase(fir) != checkbase(sec))
                    {
                        uni[checkbase(sec)] = checkbase(fir);
                    }
                }
            }
        }


        int res = 0;
        for (i = 0; i < H * W; i++)
        {
            if (uni[i] == -1) res++;
        }
        return res;
    }

    bool ok(int W, int H, int x, int y)
    {
        return x >= 0 && y >= 0 && x < W && y < H;
    }



    int checkbase(int a)
    {
        if (uni[a] == -1) return a;
        return (uni[a] = checkbase(uni[a]));
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
	private void test_case_0() { int Arg0 = 100; int Arg1 = 100; int Arg2 = 50; int Arg3 = 50; string[] Arg4 = new string[]{"ULDR"}; int Arg5 = 2; verify_case(0, Arg5, pieces(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 3; int Arg3 = 4; string[] Arg4 = new string[]{"UDUDUDUDUDU"}; int Arg5 = 1; verify_case(1, Arg5, pieces(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 0; int Arg3 = 0; string[] Arg4 = new string[]{"RDDDUUU","RDDDUUU","R","DLLLRRR","DLLL"}; int Arg5 = 9; verify_case(2, Arg5, pieces(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 5; int Arg1 = 3; int Arg2 = 5; int Arg3 = 3; string[] Arg4 = new string[]{"LULLULLU"}; int Arg5 = 2; verify_case(3, Arg5, pieces(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CuttingGlass ___test = new CuttingGlass();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
