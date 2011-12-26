using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RoadReconstruction {
    public string selectReconstruction(string[] roads)
    {
        Dictionary<string, int> roaddic = new Dictionary<string, int>();
        Dictionary<string, int> citydic = new Dictionary<string, int>();
        int i, j;
        List<string> roadlist = new List<string>();
        int citycount = 0;
        for (i = 0; i < roads.Length; i++)
        {
            string[] st = roads[i].Split(' ');
            if (!roaddic.ContainsKey(st[0]))
            {
                roadlist.Add(st[0]);
                roaddic[st[0]] = 0;
            }
            for (j = 1; j <= 2; j++)
            {
                if (!citydic.ContainsKey(st[j]))
                {
                    citydic[st[j]] = citycount++;
                }
            }
        }
        string[] road = roadlist.ToArray();
        Array.Sort(road, String.CompareOrdinal);
        for (i = 0; i < road.Length; i++)
        {
            roaddic[road[i]] = i;
        }
        string[] name = new string[roads.Length];
        int[] from = new int[roads.Length];
        int[] to = new int[roads.Length];
        int[] ar = new int[roads.Length];
        for (i = 0; i < roads.Length; i++)
        {
            string[] st = roads[i].Split(' ');
            name[i] = st[0];
            int cost = 0;
            if (st.Length == 4) cost = int.Parse(st[3]);
            ar[i] = roaddic[st[0]] * 100 + 10000 * cost + i;
            from[i] = citydic[st[1]];
            to[i] = citydic[st[2]];
        }
        dp = new int[citycount];
        for (i = 0; i < citycount; i++) dp[i] = -1;
        List<string> res = new List<string>();
        Array.Sort(ar);
        for (i = 0; i < roads.Length; i++)
        {
            int num = ar[i] % 100;
            if (connect(from[num], to[num]))
            {
                if (ar[i] >= 10000) res.Add(name[num]);
            }
        }
        int count = 0;
        for (i = 0; i < citycount; i++) if (dp[i] == -1) count++;
        if (count != 1) return "IMPOSSIBLE";
        string ret = "";
        string[] resar = res.ToArray();
        Array.Sort(resar);
        for (i = 0; i < resar.Length; i++)
        {
            ret += resar[i];
            if (i != resar.Length - 1) ret += " ";
        }
        return ret;

    }

    int[] dp;

    int find(int a)
    {
        if (dp[a] == -1) return a;
        else return dp[a] = find(dp[a]);
    }

    bool connect(int a, int b)
    {
        a = find(a);
        b = find(b);
        if (a != b)
        {
            dp[b] = a;
            return true;
        }
        return false;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
