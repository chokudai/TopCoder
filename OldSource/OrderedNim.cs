using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OrderedNim {
    public string winner(int[] layout)
    {
        int i;
        int k = 0;
        for (i = 0; i < layout.Length; i++)
        {
            if (layout[i] >= 2)
            {
                if (k % 2 == 0) return "Alice";
                else return "Bob";
            }
            if (layout[i] == 0) continue;
            if (layout[i] == 1) k++;
        }
        if (k % 2 == 0) return "Bob";
        else return "Alice";
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{5}; string Arg1 = "Alice"; verify_case(0, Arg1, winner(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2}; string Arg1 = "Bob"; verify_case(1, Arg1, winner(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{2,1}; string Arg1 = "Alice"; verify_case(2, Arg1, winner(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{10,9,8,7,6,5,4,3,2,1}; string Arg1 = "Alice"; verify_case(3, Arg1, winner(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1,1,1,1}; string Arg1 = "Bob"; verify_case(4, Arg1, winner(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OrderedNim ___test = new OrderedNim();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
