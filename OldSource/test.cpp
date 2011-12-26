#include <queue>
#include<iostream>
#include<algorithm>
#include<cmath>
#include <vector>
using namespace std;

int H,W;
int dp[1 << 20][2];
int nextdp[1 << 20][2];

int MOD = 100000;

bool check(int a){
    int res = 0;
    int i;
    for(i=1;i<a;i++){
        if(a%i==0) res += i;
    }
    if(res>a) return true;
    else return false;
}

int main(){
    int i,j;
    double dM = 0.001;
    for(i=0;i<40;i++){
        double dY = (i*1000+1)*dM;
        double dDif = (double)i - dY;
        if(dDif<-0.001 || dDif>0.001){cout << dDif << endl;}
        else cout << "error! " << dDif << " " << i << endl;
    }
    cin >> i;
    return 0;
}
