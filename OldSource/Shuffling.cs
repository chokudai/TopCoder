using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Shuffling {
    public int position(int cards, int[] shuffles)
    {
        int[] num = new int[cards];
        int i, j;
        for (i = 0; i < cards; i++) num[i] = i;
        for (i = 0; i < shuffles.Length; i++) if (shuffles[i] >= 0) shuffles[i]--;
        for (i = 0; i < shuffles.Length; i++)
        {
            int[] newnum = new int[cards];
            int count = 0;
            for (j = Math.Min(shuffles[i], 0); j < Math.Max(cards/2, cards/2 + shuffles[i]); j++)
            {
                if (j >= 0 && j < cards / 2) newnum[count++] = num[j];
                int k = j - shuffles[i];
                if (k >= 0 && k < cards / 2) newnum[count++] = num[cards / 2 + k];
            }
            num = (int[])newnum.Clone();
        }
        for (i = 0; i < cards; i++) if (num[i] == 0) return i;
        return -1;
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
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{ -2 }; int Arg2 = 2; verify_case(0, Arg2, position(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 52; int[] Arg1 = new int[]{ 1, 17, 12, 26, 9 }; int Arg2 = 0; verify_case(1, Arg2, position(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 10; int[] Arg1 = new int[]{ -1, -1, -1, -1, -1, -1, -1, -1, -1 }; int Arg2 = 5; verify_case(2, Arg2, position(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 100; int[] Arg1 = new int[]{ -50 }; int Arg2 = 50; verify_case(3, Arg2, position(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 100; int[] Arg1 = new int[]{ -48, -49, -2, 10 }; int Arg2 = 95; verify_case(4, Arg2, position(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Shuffling ___test = new Shuffling();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
