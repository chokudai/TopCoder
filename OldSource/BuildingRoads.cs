using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BuildingRoads {
    public int destroyRocks(string[] field)
    {

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
	private void test_case_0() { string[] Arg0 = new string[]{"!1.!",
 "aab2"}; int Arg1 = 3; verify_case(0, Arg1, destroyRocks(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"#@",
 "A.",
 "A1",
 "@#"}; int Arg1 = 100; verify_case(1, Arg1, destroyRocks(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"$....",
 "BBBBB",
 "B000B",
 "B0$0B",
 "B000B",
 "BBBBB"}; int Arg1 = 100200; verify_case(2, Arg1, destroyRocks(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"$a",
 ".B",
 "$3"}; int Arg1 = 0; verify_case(3, Arg1, destroyRocks(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{".#!@.$",
 ".11111",
 "..AB..",
 "33AB..",
 "$3AB..",
 "88888a",
 "#!@..."}; int Arg1 = 30301; verify_case(4, Arg1, destroyRocks(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BuildingRoads ___test = new BuildingRoads();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
