using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ObjectFall {
    public int howLong(int x, int y, string[] obstacles)
    {
        int len = obstacles.Length;
        P[] ps = new P[len];
        int i;
        for (i = 0; i < len; i++)
        {
            ps[i] = new P(obstacles[i]);
        }
        Array.Sort(ps);
        int res = y;
        for (i = 0; i < len; i++)
        {
            if (y < ps[i].y) continue;
            if (ps[i].x1 <= x && ps[i].x2 >= x)
            {
                res += 5;
                x = ps[i].x2;
            }
        }
        return res;
    }

    class P : IComparable
    {
        public int y, x1, x2;

        public P(string s)
        {
            string[] st = s.Split(' ');
            y = int.Parse(st[0]);
            x1 = int.Parse(st[1]);
            x2 = int.Parse(st[2]);
        }


        public int CompareTo(object p1)
        {
            return ((P)p1).y - this.y;
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
