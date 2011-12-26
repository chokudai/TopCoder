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

class NotTwo {
public:
int maxStones(int width, int height) {
    //Ç±Ç±Ç…ÉvÉçÉOÉâÉÄÇì¸óÕÅI
}

// BEGIN CUT HERE
    void run_test(int Case) { test_case_0(); test_case_1(); test_case_2(); test_case_3(); test_case_4(); test_case_5(); test_case_6(); test_case_7(); test_case_8(); test_case_9(); }
private:
    void verify_case(int Case, int Expected, int Received)
    {
        printf("Test Case #%d...",Case);
        if (Expected == Received)
            printf("PASSED\n");
        else
        {
            printf("FAILED\n");
            printf("\tExpected: \"%d\"\n",Expected);
            printf("\tReceived: \"%d\"\n",Received);
        }
    }
    void test_case_0() { int Arg0 = 3; int Arg1 = 2; int Arg2 = 4; verify_case(0, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_1() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 5; verify_case(1, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_2() { int Arg0 = 8; int Arg1 = 5; int Arg2 = 20; verify_case(2, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_3() { int Arg0 = 1000; int Arg1 = 1000; int Arg2 = 500000; verify_case(3, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_4() { int Arg0 = 1000; int Arg1 = 999; int Arg2 = 499500; verify_case(4, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_5() { int Arg0 = 999; int Arg1 = 1000; int Arg2 = 499500; verify_case(5, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_6() { int Arg0 = 999; int Arg1 = 999; int Arg2 = 499001; verify_case(6, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_7() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 4; verify_case(7, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_8() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; verify_case(8, Arg2, maxStones(Arg0, Arg1)); }
    void test_case_9() { int Arg0 = 1; int Arg1 = 997; int Arg2 = 499; verify_case(9, Arg2, maxStones(Arg0, Arg1)); }

// END CUT HERE

};

// BEGIN CUT HERE
int main() {
	NotTwo ___test;
	___test.run_test(-1);
}
// END CUT HERE
