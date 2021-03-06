using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CompositeSmash {

    bool[] b;
    bool[] c;
    int t;

    public string thePossible(int N, int target)
    {
        b = new bool[100005];
        c = new bool[100005];
        t = target;
        if (saiki(N)) return "Yes";
        else return "No";
    }

    bool saiki(int a)
    {
        int i;
        if (a < 2) return false;
        if (a == t) return true;
        if (c[a]) return b[a];
        c[a] = true;
        bool flag = false;
        for (i = 2; i * i < a; i++)
        {
            if (a % i == 0)
            {
                if (!saiki(i) && !saiki(a / i))
                {
                    return b[a] = false;
                }
                flag = true;
            }
        }
        return b[a] = flag;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 9; int Arg1 = 3; string Arg2 = "Yes"; verify_case(0, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 8; int Arg1 = 4; string Arg2 = "Yes"; verify_case(1, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 12; int Arg1 = 6; string Arg2 = "No"; verify_case(2, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 5; int Arg1 = 8; string Arg2 = "No"; verify_case(3, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 100000; int Arg1 = 100000; string Arg2 = "Yes"; verify_case(4, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 5858; int Arg1 = 2; string Arg2 = "Yes"; verify_case(5, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_6() { int Arg0 = 81461; int Arg1 = 2809; string Arg2 = "No"; verify_case(6, Arg2, thePossible(Arg0, Arg1)); }
	private void test_case_7() { int Arg0 = 65536; int Arg1 = 256; string Arg2 = "No"; verify_case(7, Arg2, thePossible(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CompositeSmash ___test = new CompositeSmash();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
