using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RepresentableNumbers {
    public int getNext(int X)
    {
        while (true)
        {
            int nextplus = 1;
            int kake = 1;
            bool first = true;
            bool[,] check = new bool[2, 2];//kuri nokori(0->1 1->2)
            int i, j;
            check[0, 0] = check[0, 1] = true;
            check[1, 0] = check[1, 1] = false;
            int now = X;
            while (true)
            {
                if (now == 0)
                {
                    if (check[0, 0]) return X;
                    if (check[0, 1]) return X;
                    else break;
                }
                if (now == 1)
                {
                    if (check[1, 0]) return X;
                    if (check[1, 1]) return X;
                }
                kake *= 10;
                int a = now % 10;
                now /= 10;
                bool[,] ncheck = new bool[2, 2];
                bool flag = true;
                for (i = 0; i < 2; i++)
                    for (j = 0; j < 2; j++) ncheck[i, j] = false;
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        if (!check[i, j]) continue;
                        if (j == 1)
                        {
                            if ((a - i) % 2 == 0)
                            {
                                if ((a - i) != 0)
                                {
                                    ncheck[0, 0] = ncheck[0, 1] = true;
                                    ncheck[1, 0] = ncheck[1, 1] = true;
                                    flag = false;
                                }
                                else
                                {
                                    ncheck[1, 0] = ncheck[1, 1] = true;
                                    flag = false;
                                }
                            }
                        }
                        if (!first)
                        {
                            if ((a + i) % 2 == 1)
                            {
                                if (a == 0 && i == 1)
                                {
                                    ncheck[1, 0] = true;
                                    flag = false;
                                }
                                else
                                {
                                    ncheck[0, 0] = true;
                                    flag = false;
                                }
                            }
                        }
                    }
                }
                if (flag) break;
                first = false;
                bool okflag = true;
                check = (bool[,])ncheck.Clone();
                for (i = 0; i < 2; i++)
                    for (j = 0; j < 2; j++) if (!check[i, j]) okflag = false;
                if (okflag) nextplus = kake;
                    
            }
            X -= X % nextplus;
            X += nextplus;
            //X++;
        }
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 2; verify_case(0, Arg1, getNext(Arg0)); }
	private void test_case_1() { int Arg0 = 999; int Arg1 = 1000; verify_case(1, Arg1, getNext(Arg0)); }
	private void test_case_2() { int Arg0 = 2000; int Arg1 = 2000; verify_case(2, Arg1, getNext(Arg0)); }
	private void test_case_3() { int Arg0 = 4201234; int Arg1 = 4222222; verify_case(3, Arg1, getNext(Arg0)); }
	private void test_case_4() { int Arg0 = 10101010; int Arg1 = 10102222; verify_case(4, Arg1, getNext(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RepresentableNumbers ___test = new RepresentableNumbers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
