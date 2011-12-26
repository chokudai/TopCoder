using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CutSticks
{
    public void ShortestPath()
    {
        int i;
        string st;
        while (true)
        {
            st = Console.ReadLine();
            string[] input = st.Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int S = int.Parse(input[2]) - 1;
            int T = int.Parse(input[3]) - 1;
            List<int>[] e = new List<int>[N];
            int[] dp = new int[N];
            bool[] check = new bool[N];
            Dictionary<int, int>[] dic = new Dictionary<int, int>[N];

            for (i = 0; i < N; i++)
            {
                dp[i] = -1;
                dic[i] = new Dictionary<int, int>();
                check[i] = false;
                e[i] = new List<int>();
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(S);
            dp[S] = 0;
            check[S] = true;
            for (i = 0; i < M; i++)
            {
                string[] inputa = Console.ReadLine().Split(' ');
                int A = int.Parse(inputa[0]) - 1;
                int B = int.Parse(inputa[1]) - 1;
                int C = int.Parse(inputa[2]);
                dic[A][B] = C;
                dic[B][A] = C;
                e[A].Add(B);
                e[B].Add(A);
            }
            while (q.Count != 0)
            {
                int now = q.Dequeue();
                if (!check[now]) continue;
                check[now] = false;
                foreach (int next in e[now])
                {
                    if (dp[next] == -1 || dp[next] > dp[now] + dic[now][next])
                    {
                        q.Enqueue(next);
                        check[next] = true;
                        dp[next] = dp[now] + dic[now][next];
                    }
                }
            }
            Console.WriteLine(dp[T]);
        }
    }


    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            CutSticks ___test = new CutSticks();
            ___test.ShortestPath();
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.ToString());
        }
    }
    // END CUT HERE
}
