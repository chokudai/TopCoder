using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StringDecryption {
public int decrypt(string[] code) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"2122"}; int Arg1 = 3; verify_case(0, Arg1, decrypt(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"012345"}; int Arg1 = 0; verify_case(1, Arg1, decrypt(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"123","4056","789"}; int Arg1 = 1555366; verify_case(2, Arg1, decrypt(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1"}; int Arg1 = 0; verify_case(3, Arg1, decrypt(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"10000000101"}; int Arg1 = 1; verify_case(4, Arg1, decrypt(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"36029876684872327223276091861774662608610223162723",
 "03488815136338720301059585173865765204966825388127",
 "28905156607840356770675251838346615448480878517234",
 "48346801533058114299540857443030369316232988018148",
 "10266938012137248616925283167856138261491565599857",
 "63098906296356837907112034583226442670798371015701",
 "04431120878401385924047425666758653777487585276695",
 "60451685064284613241730873806124686837402534256835",
 "74510620643600499901411494702324867762597665590427",
 "82564618006706585886295436740966342057330943523869"}; int Arg1 = 882582353; verify_case(5, Arg1, decrypt(Arg0)); }
	private void test_case_6() { string[] Arg0 = new string[]{"11111111111111111111111111111111111111111111111111",
 "12222222222222211122222222222221112222222222222111",
 "12000000000000211120000000000021112000000000002111",
 "12222220222222211120222222222221112022222222202111",
 "11111120211111111120222222222221112022222222202111",
 "11111120211111111120000000000021112000000000002111",
 "11111120211111111122222222222021112022222222202111",
 "11111120211111111122222222222021112021111111202111",
 "11111120211111111120000000000021112021111111202111",
 "11111122211111111122222222222221112221111111222111"}; int Arg1 = 371459312; verify_case(6, Arg1, decrypt(Arg0)); }
	private void test_case_7() { string[] Arg0 = new string[]{"89210"}; int Arg1 = 95; verify_case(7, Arg1, decrypt(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
StringDecryption ___test = new StringDecryption();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
