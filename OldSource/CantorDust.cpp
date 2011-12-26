#include <cstdio>
#include <cstdlib>
#include <cmath>
#include <climits>
#include <cfloat>
#include <map>
#include <utility>
#include <set>
#include <iostream>
#include <memory>
#include <string>
#include <vector>
#include <algorithm>
#include <functional>
#include <sstream>
#include <complex>
#include <stack>
#include <queue>
using namespace std;
static const double EPS = 1e-5;
typedef long long ll;

class CantorDust {
public:
int occurrencesNumber(vector <string> pattern, int time) {

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
	private void test_case_0() { string[] Arg0 = new string[]{".X",".."}; int Arg1 = 1; int Arg2 = 1; verify_case(0, Arg2, occurrencesNumber(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{".."}; int Arg1 = 1; int Arg2 = 2; verify_case(1, Arg2, occurrencesNumber(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"."}; int Arg1 = 2; int Arg2 = 65; verify_case(2, Arg2, occurrencesNumber(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"X...X"}; int Arg1 = 2; int Arg2 = 4; verify_case(3, Arg2, occurrencesNumber(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"X"}; int Arg1 = 9; int Arg2 = 262144; verify_case(4, Arg2, occurrencesNumber(Arg0, Arg1)); }

// END CUT HERE

};

// BEGIN CUT HERE
int main() {
CantorDust ___test;
___test.run_test(-1);
}
// END CUT HERE
