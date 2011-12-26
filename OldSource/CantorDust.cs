using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CantorDust {

    public string getstring(int T) {
        //最初は"X"の１文字
		if (T==0) return "X";
        //１つ前の１辺を生成する
        string c = getstring(T - 1);
        //１つ前の１辺から、新しい１辺を生成する
        return c + new string(' ', c.Length) + c;
	}

    public int occurrencesNumber(string[] pattern, int time)
    {
        int M = pattern.Length, N = pattern[0].Length;  //縦、横の長さ
        bool[] a = new bool[M], b = new bool[N];    //各列・行にXを含むか否かのflag
        string C = getstring(time);    //上記getstring関数からフラクタルの１列を生成する
        int L = C.Length;   //フラクタルの１辺の長さ
        int x, y, k;
        int p = 0, q = 0;   //pが横のパターンの一致数、qが縦のパターンの一致数
        bool flag = false;
        //各列・行に'X'を含んでいるかを調べる
        for (x = 0; x < M; ++x) for (y = 0; y < N; ++y) if (pattern[x][y] == 'X') a[x] = b[y] = flag = true;
        //矛盾を含んでいたら存在しないので、0を返す
        for (x = 0; x < M; ++x) for (y = 0; y < N; ++y) if ((pattern[x][y] == 'X') != (a[x] && b[y])) return 0;

        //横について一致数を調べる　C#ならIndexOf、C++ならfind等を使っても可
        for (k = 0; k + M <= L; ++k)
        {
            for (x = 0; x < M; ++x) if ((C[k + x] == 'X') != a[x]) break;
            if (x == M) ++p;
        }
        //縦についても同様に
        for (k = 0; k + N <= L; ++k)
        {
            for (y = 0; y < N; ++y) if ((C[k + y] == 'X') != b[y]) break;
            if (y == N) ++q;
        }

        if (flag) return (p * q);   //'X'を含む場合
        else return (p * (L - N + 1) + (L - M + 1) * q - p * q);    //'X'を含まない場合
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
