using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TicketPrinters {
    public int minTime(int currentPrinter, int[] printerDistance, int[] startingValues, int[] wantedValues)
    {

    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 0; int[] Arg1 = new int[]{100, 20, 50}; int[] Arg2 = new int[]{66, 78, 99, 5}; int[] Arg3 = new int[]{99, 5, 78, 66}; int Arg4 = 171; verify_case(0, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 1; int[] Arg1 = new int[]{50, 50}; int[] Arg2 = new int[]{100, 200, 300}; int[] Arg3 = new int[]{101, 201, 302}; int Arg4 = 152; verify_case(1, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 2; int[] Arg1 = new int[]{13, 26, 39, 13}; int[] Arg2 = new int[]{123, 12, 32, 67, 1015}; int[] Arg3 = new int[]{1, 2, 3, 4, 5}; int Arg4 = 1063; verify_case(2, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TicketPrinters ___test = new TicketPrinters();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
