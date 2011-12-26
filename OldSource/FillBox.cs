using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FillBox {
    public int minCubes(int length, int width, int height, int[] cubes)
    {
        long[] need = new long[20];
        int i, j, k;
        for (i = 0; i < 20; i++)
        {
            if ((length >> i) % 2 != 1) continue;
            for (j = 0; j < 20; j++)
            {
                if ((width >> j) % 2 != 1) continue;
                for (k = 0; k < 20; k++)
                {
                    if ((height >> k) % 2 != 1) continue;
                    int min = Math.Min(Math.Min(i, j), k);
                    need[min] += (long)1 << (i + j + k - min * 3);
                }
            }
        }
        long[] c = new long[20];
        for (i = 0; i < cubes.Length; i++) c[i] = cubes[i];
        
        long use = 0;
        for (i = 19; i >= 0; i--)
        {
            long now = Math.Min(need[i], c[i]);
            //Console.WriteLine(i + " " + need[i] + " " + c[i] + " " + now);
            need[i] -= now;
            c[i] -= now;
            use += now;
            if (i != 0)
            {
                need[i - 1] += (need[i] << 3);
                need[i] = 0;
            }
        }
        Console.WriteLine(need[0]);
        if (need[0] != 0) return -1;
        return (int)use;
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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 8; int[] Arg3 = new int[]{10,10,10}; int Arg4 = 2; verify_case(0, Arg4, minCubes(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 8; int[] Arg3 = new int[]{10,10,1}; int Arg4 = 9; verify_case(1, Arg4, minCubes(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 11; int[] Arg3 = new int[]{2000}; int Arg4 = 1100; verify_case(2, Arg4, minCubes(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 11; int[] Arg3 = new int[]{1099}; int Arg4 = -1; verify_case(3, Arg4, minCubes(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 37; int Arg1 = 42; int Arg2 = 59; int[] Arg3 = new int[]{143821,14382,1438,143,14,1}; int Arg4 = 5061; verify_case(4, Arg4, minCubes(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FillBox ___test = new FillBox();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
