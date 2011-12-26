using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicalGirlLevelThreeDivOne {
    public long theMaxPower(string[] first, int n, long lo, long hi)
    {

    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"111", "011"}; int Arg1 = 4; long Arg2 = 2l; long Arg3 = 7l; long Arg4 = 4l; verify_case(0, Arg4, theMaxPower(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string[] Arg0 = new string[]{"1", "11", "111"}; int Arg1 = 123456789; long Arg2 = 123456789l; long Arg3 = 123456789012345l; long Arg4 = 123456665555557l; verify_case(1, Arg4, theMaxPower(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0", "00", "000"}; int Arg1 = 987654321; long Arg2 = 987654321l; long Arg3 = 987654321054321l; long Arg4 = 0l; verify_case(2, Arg4, theMaxPower(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1110", "11", "11111", "111", "1"}; int Arg1 = 314159265; long Arg2 = 271828182845904l; long Arg3 = 314159265358979l; long Arg4 = 15l; verify_case(3, Arg4, theMaxPower(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { string[] Arg0 = new string[]{"10000", "011011001011000001101000010100000111000110110", 
"000001010001011000001101110", "100100000110100001010000", 
"011011010", "01100000010101101110000011100011001000",
"0001010", "010011000", "000101001", "00", "1"}; int Arg1 = 1000000000; long Arg2 = 1000000000000000l; long Arg3 = 1000000000000000l; long Arg4 = 1l; verify_case(4, Arg4, theMaxPower(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MagicalGirlLevelThreeDivOne ___test = new MagicalGirlLevelThreeDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
