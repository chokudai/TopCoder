using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LateProfessor {
    public double getProbability(int waitTime, int walkTime, int lateTime, int bestArrival, int worstArrival)
    {
        int i;
        long count, res;
        count = res = 0;
        if (bestArrival != worstArrival)
        {
            for (i = bestArrival; i < worstArrival; i++)
            {
                count++;
                if (i % (waitTime + walkTime) < waitTime || i % (waitTime + walkTime) >= (waitTime + walkTime - lateTime)) res++;
            }
            return 1 - (double)res / count;
        }
        else
        {
            for (i = bestArrival; i <= worstArrival; i++)
            {
                count++;
                if (i % (waitTime + walkTime) <= waitTime || i % (waitTime + walkTime) > (waitTime + walkTime - lateTime)) res++;
            }
            return 1 - (double)res / count;
        }
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 20; int Arg1 = 30; int Arg2 = 10; int Arg3 = 0; int Arg4 = 50; double Arg5 = 0.4; verify_case(0, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 20; int Arg1 = 30; int Arg2 = 10; int Arg3 = 30; int Arg4 = 100; double Arg5 = 0.42857142857142855; verify_case(1, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 20; int Arg1 = 40; int Arg2 = 50; int Arg3 = 0; int Arg4 = 300; double Arg5 = 0.0; verify_case(2, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 101; int Arg1 = 230; int Arg2 = 10; int Arg3 = 654; int Arg4 = 17890; double Arg5 = 0.6637270828498492; verify_case(3, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int Arg0 = 20; int Arg1 = 30; int Arg2 = 10; int Arg3 = 90; int Arg4 = 90; double Arg5 = 1.0; verify_case(4, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_5() { int Arg0 = 1000; int Arg1 = 600; int Arg2 = 1; int Arg3 = 17000; int Arg4 = 17000; double Arg5 = 0.0; verify_case(5, Arg5, getProbability(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LateProfessor ___test = new LateProfessor();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
