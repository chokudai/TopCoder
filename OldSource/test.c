#include<stdio.h>

int board[10][10];
int dp[1<<24][24];
int vx[4]={1,0,-1,0};
int vy[4]={0,1,0,-1};
int n,m;
int count;

int ok(int a, int b){
   return a>=0 && b>=0 && a<n && b<m;
}

int saiki(int now, int nowi, int nowj){
    int i;
    int ni,nj;
    if(now==(1<<(count-1))-1) return 1;
    if(now&1) return 0;
    if(dp[now][board[nowi][nowj]-1]!=0) return dp[now][board[nowi][nowj]-1]-1;
    int res = 0;
    for(i=0;i<4;i++){
        ni = nowi; nj = nowj;
        for(;;){
            ni += vx[i]; nj += vy[i];;
            if(ok(ni,nj)==0) break;
            if(board[ni][nj]!=0){
                if((now>>(board[ni][nj]-1))&1) break;
                else res += saiki(now+(1<<(board[ni][nj]-1)),ni,nj);
            }
        }
    }
    dp[now][board[nowi][nowj]-1] = res + 1;
    return res;
}

int main(){
    int i,j;
    int starti,startj;
    count = 2;
    scanf("%d %d",&m,&n);
    for(i=0;i<n;i++){
        for(j=0;j<m;j++){
            scanf("%d",&board[i][j]);
            if(board[i][j]==1) board[i][j] = count++;
            else if(board[i][j]==2){
                board[i][j] = 1;
                starti = i;
                startj = j;
            }
        }
    }
    printf("%d\n",saiki(0,starti,startj));
    return 0;
}
