using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CarrotJumping {
    public int theJump(int init)
    {
        Dictionary<int, bool> dic = new Dictionary<int, bool>();
        int i, j;
        long mod = 1000000007;
        Queue<int> q = new Queue<int>();
        q.Enqueue(init);
        if (init % mod == 0) return 0;
        for (i = 1; i <= 100000; i++)
        {
            Queue<int> nextq = new Queue<int>();
            while (q.Count != 0)
            {
                long next = q.Dequeue();
                long nexta = next;
                long nextb = next;
                nexta *= 4;
                nexta += 3;
                nexta %= mod;
                if (!dic.ContainsKey((int)nexta))
                {
                    if (nexta == 0) return i;
                    dic[(int)nexta] = true;
                    nextq.Enqueue((int)nexta);
                }
                nextb *= 8;
                nextb += 7;
                nextb %= mod;
                if (!dic.ContainsKey((int)nextb))
                {
                    if (nextb == 0) return i;
                    dic[(int)nextb] = true;
                    nextq.Enqueue((int)nextb);
                }
            }
            while (nextq.Count != 0) q.Enqueue(nextq.Dequeue());
        }
        return -1;
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
	private void test_case_0() { int Arg0 = 125000000; int Arg1 = 1; verify_case(0, Arg1, theJump(Arg0)); }
	private void test_case_1() { int Arg0 = 281250001; int Arg1 = 2; verify_case(1, Arg1, theJump(Arg0)); }
	private void test_case_2() { int Arg0 = 18426114; int Arg1 = 58; verify_case(2, Arg1, theJump(Arg0)); }
	private void test_case_3() { int Arg0 = 4530664; int Arg1 = 478; verify_case(3, Arg1, theJump(Arg0)); }
	private void test_case_4() { int Arg0 = 705616876; int Arg1 = 100000; verify_case(4, Arg1, theJump(Arg0)); }
	private void test_case_5() { int Arg0 = 852808441; int Arg1 = -1; verify_case(5, Arg1, theJump(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CarrotJumping ___test = new CarrotJumping();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
