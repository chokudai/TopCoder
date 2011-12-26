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

class BinaryFlips{
	public:
int minimalMoves(int A, int B, int K) {
	int result = 0;
	int length = A + B;

	if(A == 0){return 0;}
	if(A%K == 0){return (A/K);}
	if((K>=length) || ((A%2)!=0 && (K%2)==0)){return -1;}
	while(A>=2*K){A -= K; B += K; result++;}
	if((A%2)==0 && A <= (2*(length-K))){return (result + 2);}
	while(1){
		result++;
		if(A%2==0 && K%2!=0){
			A = A+(2*B)-K; B = length - A;
			if((2*(length-K))>=(abs(K-A))){break;}
		}
		else if(A%2!=0 && K%2!=0){
			A = abs(K-A);
			B = length - A;
			if((2*(length-K))>=A){return (result+2);}
		}
		else{break;}
	}
	return (result + 3);
}
};
