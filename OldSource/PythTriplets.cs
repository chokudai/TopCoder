using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PythTriplets {

    V[] v;

    public int findMax(string[] stick)
    {
        string st = "";
        foreach (string s in stick) st += s;
        string[] str = st.Split(' ');
        List<int> odd = new List<int>();
        List<int> even = new List<int>();
        foreach (string s in str)
        {
            int num = int.Parse(s);
            if (num % 2 == 1) odd.Add(num);
            else even.Add(num);
        }
        int[] oddar = odd.ToArray();
        int[] evenar = even.ToArray();

        int i, j;

        int len = oddar.Length + evenar.Length + 2;
        v = new V[len];

        for (i = 0; i < len; i++) v[i] = new V(len);

        int os = 1;
        for (i = 0; i < oddar.Length; i++) v[0].E[i + os] = true;
        
        int es = oddar.Length + 1;
        for (i = 0; i < oddar.Length; i++) v[i + es].E[len - 1] = true;

        for (i = 0; i < oddar.Length; i++)
        {
            for (j = 0; j < evenar.Length; j++)
            {
                if (check(oddar[i], evenar[j]))
                {
                    v[i + os].E[j + es] = true;
                    //Console.WriteLine("ok:{0} {1}", oddar[i], evenar[j]);
                }
            }
        }

        for (i = 0; ; i++)
        {
            bool[] flag = new bool[len];
            //Console.WriteLine(flag.Length);
            if (!dfs(flag, 0)) break;
        }
        return i;
    }

    bool dfs(bool[] flag, int now)
    {
        //Console.WriteLine(now);
        int len = flag.Length;
        if (now == len - 1) return true;
        int i;
        flag[now] = true;
        for (i = 0; i < len; i++)
        {
            if (v[now].E[i] && !flag[i])
            {
                v[now].E[i] = false;
                v[i].E[now] = true;
                if (dfs(flag, i)) return true;
                v[now].E[i] = true;
                v[i].E[now] = false;
            }
        }
        flag[now] = false;
        return false;
    }

    bool check(int a, int b)
    {
        return aaa(a,b) & bbb(a,b);
    }

    bool aaa(int a, int b)
    {
        if (a < b) return aaa(b, a);
        if (b == 0)
        {
            if (a == 1) return true;
            else return false;
        }
        return aaa(b, a % b);
    }

    bool bbb(int a, int b)
    {
        long c = (long)a * a + (long)b * b;
        long d = (long)Math.Sqrt(c + 1e-9);
        if (c == d * d) return true;
        return false;
    }

    class V
    {
        public bool[] E;
        
        public V(int len)
        {
            E = new bool[len];
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
