using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BikeRace {

    public string[] eliminated(int track, string[] name, int[] start, int[] speed) {
        int len = name.Length;
        double[] nukareru = new double[len];
        bool[] notstart = new bool[len];
        int i,j;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (start[i] > start[j])
                {
                    int tempstart = start[i];
                    int tempspeed = speed[i];
                    string tempname = name[i];
                    start[i] = start[j];
                    speed[i] = speed[j];
                    name[i] = name[j];
                    start[j] = tempstart;
                    speed[j] = tempspeed;
                    name[j] = tempname;
                }
            }
        }

        for (i = 0; i < len; i++) nukareru[i] = double.MaxValue;
        for (i = 0; i < len; i++) notstart[i] = false;
        for (i = 0; i < len; i++)
        {
            if (notstart[i]) continue;
            for (j = 0; j < len; j++)
            {
                //if (notstart[j]) continue;
                if (i == j) continue;
                if (start[j] > start[i])
                {
                    double t = (double)track / speed[i] + start[i];
                    if (t <= start[j])
                    {
                        nukareru[j] = Math.Min(nukareru[j], t);
                        notstart[j] = true;
                    }
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            if (notstart[i]) continue;
            for (j = 0; j < len; j++)
            {
                if (notstart[j]) continue;
                if (speed[j] < speed[i])
                {
                    double t = (double)track / speed[i] + start[i];
                    if (t > start[j])
                    {
                        double tt = (double)(track - speed[i] * start[i] + speed[j] * start[j]);
                        tt = tt / (speed[i] - speed[j]);
                        nukareru[j] = Math.Min(nukareru[j], t);
                    }
                }
            }
        }
        int[] ar = new int[len];
        for (i = 0; i < len; i++) ar[i] = i;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (nukareru[ar[i]] - nukareru[ar[j]] <= -(1e-9) || (Math.Abs(nukareru[ar[i]] - nukareru[ar[j]]) < 1e-9) && (speed[i]< speed[j] || (speed[i]==speed[j] && checkstring(name[ar[j]],name[ar[i]]))))
                {
                    int temp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = temp;
                }
            }
        }
        List<int> li = new List<int>();
        for (i = 0; i < len; i++)
        {
            
            if (nukareru[ar[i]] != double.MaxValue) li.Add(ar[i]);
        }
        int count = li.Count;
        string[] res = new string[count];
        for (i = 0; i < count; i++)
        {
            res[i] = name[li[i]];
        }
        return res;
    }

    bool checkstring(string a,string b){
        string[] ss = new string[2];
        ss[0] = a; ss[1] = b;
        Array.Sort(ss);
        if (ss[0] == a) return false;
        else return true;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
