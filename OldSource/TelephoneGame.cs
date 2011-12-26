using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TelephoneGame {
    public int howMany(int[] connect1, int[] connect2, int numPeople)
    {
        int i, j, k;
        int len = connect1.Length;
        int res = int.MaxValue;
        bool[,] check = new bool[len, len];
        for (j = 0; j < len; j++)
            for (k = 0; k < len; k++)
                check[j, k] = cross(connect1[j], connect2[j], connect1[k], connect2[k]);
        for (i = 0; i < (1 << len); i++)
        {
            bool[] b = new bool[len];
            int[] a = new int[len];
            Queue<int> q = new Queue<int>();
            bool flag = true;
            while (true)
            {
                int nextnum = -1;
                for (j = 0; j < len; j++)
                {
                    if ((i >> j) % 2 == 1 && !b[j])
                    {
                        nextnum = j;
                        break;
                    }
                }
                if (nextnum == -1) break;
                q.Enqueue(nextnum);
                b[nextnum] = true;
                while (q.Count != 0)
                {
                    j = q.Dequeue();
                    for (k = 0; k < len; k++)
                    {
                        if ((i >> k) % 2 == 1 && check[j, k])
                        {
                            if (b[k])
                            {
                                if (a[j] == a[k])
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            else
                            {
                                a[k] = 1 - a[j];
                                b[k] = true;
                                q.Enqueue(k);
                            }
                        }
                    }
                    if (k < len) break;
                }
            }
            if (flag)
            {
                int now = 0;
                for (j = 0; j < len; j++) if ((i >> j) % 2 == 0) now++;
                res = Math.Min(now, res);
            }
        }
        return res;
    }

    bool cross(int a1, int a2, int b1, int b2)
    {
        return (long)(a1 - b1) * (a2 - b1) * (a1 - b2) * (a2 - b2) < 0;
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
	private void test_case_0() { int[] Arg0 = new int[]{0,1}; int[] Arg1 = new int[]{2,3}; int Arg2 = 4; int Arg3 = 0; verify_case(0, Arg3, howMany(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{4,4,4,5,5,6}; int[] Arg1 = new int[]{6,7,8,7,8,8}; int Arg2 = 10; int Arg3 = 1; verify_case(1, Arg3, howMany(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{0,2,4}; int[] Arg1 = new int[]{3,5,1}; int Arg2 = 6; int Arg3 = 1; verify_case(2, Arg3, howMany(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18}; int[] Arg1 = new int[]{2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,20}; int Arg2 = 100; int Arg3 = 0; verify_case(3, Arg3, howMany(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17}; int[] Arg1 = new int[]{30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47}; int Arg2 = 1000; int Arg3 = 16; verify_case(4, Arg3, howMany(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TelephoneGame ___test = new TelephoneGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
