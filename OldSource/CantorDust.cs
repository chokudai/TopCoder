using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CantorDust {

    public string getstring(int T) {
        //�ŏ���"X"�̂P����
		if (T==0) return "X";
        //�P�O�̂P�ӂ𐶐�����
        string c = getstring(T - 1);
        //�P�O�̂P�ӂ���A�V�����P�ӂ𐶐�����
        return c + new string(' ', c.Length) + c;
	}

    public int occurrencesNumber(string[] pattern, int time)
    {
        int M = pattern.Length, N = pattern[0].Length;  //�c�A���̒���
        bool[] a = new bool[M], b = new bool[N];    //�e��E�s��X���܂ނ��ۂ���flag
        string C = getstring(time);    //��Lgetstring�֐�����t���N�^���̂P��𐶐�����
        int L = C.Length;   //�t���N�^���̂P�ӂ̒���
        int x, y, k;
        int p = 0, q = 0;   //p�����̃p�^�[���̈�v���Aq���c�̃p�^�[���̈�v��
        bool flag = false;
        //�e��E�s��'X'���܂�ł��邩�𒲂ׂ�
        for (x = 0; x < M; ++x) for (y = 0; y < N; ++y) if (pattern[x][y] == 'X') a[x] = b[y] = flag = true;
        //�������܂�ł����瑶�݂��Ȃ��̂ŁA0��Ԃ�
        for (x = 0; x < M; ++x) for (y = 0; y < N; ++y) if ((pattern[x][y] == 'X') != (a[x] && b[y])) return 0;

        //���ɂ��Ĉ�v���𒲂ׂ�@C#�Ȃ�IndexOf�AC++�Ȃ�find�����g���Ă���
        for (k = 0; k + M <= L; ++k)
        {
            for (x = 0; x < M; ++x) if ((C[k + x] == 'X') != a[x]) break;
            if (x == M) ++p;
        }
        //�c�ɂ��Ă����l��
        for (k = 0; k + N <= L; ++k)
        {
            for (y = 0; y < N; ++y) if ((C[k + y] == 'X') != b[y]) break;
            if (y == N) ++q;
        }

        if (flag) return (p * q);   //'X'���܂ޏꍇ
        else return (p * (L - N + 1) + (L - M + 1) * q - p * q);    //'X'���܂܂Ȃ��ꍇ
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
