using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ExtendableTriangles {
public int getCount(string[] grid) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"RGB"}; int Arg1 = 0; verify_case(0, Arg1, getCount(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"RGB",
 "RGB"}; int Arg1 = 6; verify_case(1, Arg1, getCount(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"RRRRRRRR",
 "GGGGBBBB",
 "RRRRRRRR"}; int Arg1 = 240; verify_case(2, Arg1, getCount(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"RBRBRBRB",
 "BRBRBRBR",
 "RBRBRBRB",
 "BRBRBRBR",
 "RRRRRRRR",
 "BBBBBBBB",
 "RRRRBBBB",
 "BBBBRRRR"}; int Arg1 = 0; verify_case(3, Arg1, getCount(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"RGB",
 "RBG",
 "GRB",
 "GBR",
 "BRG",
 "BGR"}; int Arg1 = 208; verify_case(4, Arg1, getCount(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ExtendableTriangles ___test = new ExtendableTriangles();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
