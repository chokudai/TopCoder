using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Cafeteria
{
    public string latestTime(int[] offset, int[] walkingTime, int[] drivingTime)
    {
        int best = 0;
        int nokori;
        int i;
        for (i = offset.Length - 1; i >= 0; i--)
        {
            nokori = 150;
            nokori += 60 * 12 * 100;
            nokori -= drivingTime[i];
            nokori -= (nokori - offset[i]) % 10;
            nokori -= walkingTime[i];
            best = Math.Max(nokori, best);
        }
        nokori = best;
        nokori %= 720;
        if (nokori < 60) nokori += 720;
        string s = string.Concat(nokori / 60);
        while (s.Length != 2) s = "0" + s;
        string ss = string.Concat(nokori % 60);
        while (ss.Length != 2) ss = "0" + ss;
        return string.Concat(s, ":", ss);
    }
}
