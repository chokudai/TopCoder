using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Sheep {
public int minCapacity(int numSheep, int maxRuns, string[] part1, string[] part2, string[] part3, string[] part4) {

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
	private void test_case_0() { int Arg0 = 6; int Arg1 = 2; string[] Arg2 = new string[]{ "26 7 10 30 5 4" }; string[] Arg3 = new string[]{ }; string[] Arg4 = new string[]{ }; string[] Arg5 = new string[]{ }; int Arg6 = 42; verify_case(0, Arg6, minCapacity(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int Arg0 = 6; int Arg1 = 2; string[] Arg2 = new string[]{ "4 8 15 16 23 42" }; string[] Arg3 = new string[]{ }; string[] Arg4 = new string[]{ }; string[] Arg5 = new string[]{ }; int Arg6 = 54; verify_case(1, Arg6, minCapacity(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int Arg0 = 15; int Arg1 = 4; string[] Arg2 = new string[]{ "666 42 7 13 400 511 600 200 202 111 313 94 280", " 72 42" }; string[] Arg3 = new string[]{ }; string[] Arg4 = new string[]{ }; string[] Arg5 = new string[]{ }; int Arg6 = 896; verify_case(2, Arg6, minCapacity(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int Arg0 = 7; int Arg1 = 6; string[] Arg2 = new string[]{ "200 2", "01 202 203" }; string[] Arg3 = new string[]{ " 204 " }; string[] Arg4 = new string[]{ }; string[] Arg5 = new string[]{ "205", " ", "206" }; int Arg6 = 401; verify_case(3, Arg6, minCapacity(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_4() { int Arg0 = 200; int Arg1 = 20; string[] Arg2 = new string[]{ "42 468 335 501 1170 1725 1479 1359 963 465 1706",
  " 146 1282 828 1962 492 996 1943 828 1437 392 605",
  " 1903 154 293 383 1422 717 1719 1896 1448 1727",
  " 772 1539 1870 1913 1668 300 1036 1895 704 1812",
  " 1323 334 1674 665 1142 1712 254 869 1548 1645",
  " 663 758 38 860 724 1742 1530 779 317 1036 191",
  " 1843 289 107 1041 943 1265 649 1447 1806 1891",
  " 730 371 1351 1007 1102 394 1549 1630 624 85 1955",
  " 757 1841 967 1377 1932 309 945 440 627 1324 1538",
  " 1539 119 83 930 542 834 1116 640 1659 705 1931",
  " 1978 307 1674 387 1022 746 925 1073 271 1830 778",
  " 1574 1098 513 1987 1291 1162 637 356 768 1656",
  " 1575 32 53 1351 1151 942 1725 1967 1431 1108 192",
  " 8 1338 1458 288 1754 384 946 910 210 1759 222",
  " 589 423 947 1507 1031 414 1169 901 592 763 1656",
  " 1411 360 1625 538 1549 484 1596 42 1603 351 292",
  " 837 1375 1021 597 22 1349 1200 1669 485 282 735",
  " 54 2000 419 1939 901 1789 128 468 1729 894 649",
  " 484 1808 422 311 618 814 1515" }; string[] Arg3 = new string[]{ }; string[] Arg4 = new string[]{ }; string[] Arg5 = new string[]{ }; int Arg6 = 9986; verify_case(4, Arg6, minCapacity(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Sheep ___test = new Sheep();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
