using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BedroomFloor {
    public long numberOfSticks(int x1, int y1, int x2, int y2)
    {
        long tx1 = x1 - (x1 % 5); if (x1 % 5 != 0) tx1 += 5;
        long tx2 = x2 - (x2 % 5);
        long ty1 = y1 - (y1 % 5); if (y1 % 5 != 0) ty1 += 5;
        long ty2 = y2 - (y2 % 5);
        long a, b;
        long fi, se;
        int i;
        Console.WriteLine(tx1 + " " + tx2 + " " + ty1 + " " + ty2);

        
        long res = (tx2 - tx1) * (ty2 - ty1) / 5;
        Console.WriteLine("First get = " + res);

        long[] num = new long[5];

        long sa;

        //tate
        sa = ty1 - y1;

        fi = (tx2 / 5 + 1) / 2;
        se = (tx2 / 5) / 2;
        fi -= (tx1 / 5 + 1) / 2;
        se -= (tx1 / 5) / 2;

        if (tx1 % 10 == 0) { a = fi; b = se; }
        else { a = fi; b = se; }

        res += sa * a;
        num[sa] += 5 * b;

        sa = y2 - ty2;
        if (tx2 % 10 == 5) { a = fi; b = se; }
        else { a = fi; b = se; }

        res += sa * a;
        num[sa] += 5 * b;

        //yoko
        sa = tx1 - x1;

        fi = (ty2 / 5 + 1) / 2;
        se = (ty2 / 5) / 2;
        fi -= (ty1 / 5 + 1) / 2;
        se -= (ty1 / 5) / 2;

        if (ty1 % 10 == 0) { a = fi; b = se; }
        else { a = fi; b = se; }

        res += sa * b;
        num[sa] += 5 * a;

        sa = x2 - tx2;

        if (ty2 % 10 == 5) { a = fi; b = se; }
        else { a = fi; b = se; }

        res += sa * b;
        num[sa] += 5 * a;





        if ((tx1 + ty1) % 10 == 0)
        {
            num[tx1 - x1] += ty1 - y1;
        }
        else
        {
            num[ty1 - y1] += tx1 - x1;
        }

        if ((tx2 + ty2) % 10 == 0)
        {
            num[x2 - tx2] += y2 - ty2;
        }
        else
        {
            num[y2 - ty2] += x2 - tx2;
        }


        if ((tx1 + ty2) % 10 == 5)
        {
            num[tx1 - x1] += y2 - ty2;
        }
        else
        {
            num[y2 - ty2] += tx1 - x1;
        }

        if ((tx2 + ty1) % 10 == 5)
        {
            num[x2 - tx2] += ty1 - y1;
        }
        else
        {
            num[ty1 - y1] += x2 - tx2;
        }


        for (i = 1; i < 5; i++)
        {
            Console.WriteLine("parts[" + i + "] = " + num[i]);
        }

        long ge = 0;
        if (num[4] > 0 && num[1] > 0)
        {
            ge = Math.Min(num[4], num[1]);
            res += ge; num[4] -= ge; num[1] -= ge;
        }
        if (num[4] > 0)
        {
            ge = num[4];
            res += ge; num[4] -= ge;
        }
        if (num[3] > 0 && num[2] > 0)
        {
            ge = Math.Min(num[3], num[2]);
            res += ge; num[3] -= ge; num[2] -= ge;
        }
        if (num[3] > 0 && num[1] > 1)
        {
            ge = Math.Min(num[3], num[1]/2);
            res += ge; num[3] -= ge; num[1] -= ge * 2;
        }
        if (num[3] > 0 && num[1] > 0)
        {
            ge = Math.Min(num[3], num[1]);
            res += ge; num[3] -= ge; num[1] -= ge;
        }
        if (num[3] > 0)
        {
            ge = num[3];
            res += ge; num[3] -= ge;
        }
        if (num[1] > 0 && num[2] > 1)
        {
            ge = Math.Min(num[1], num[2] / 2);
            res += ge; num[1] -= ge; num[2] -= ge * 2;
        }
        if (num[2] > 0 && num[1] > 2)
        {
            ge = Math.Min(num[2], num[1]/3);
            res += ge; num[2] -= ge; num[1] -= ge * 3;
        }
        if (num[2] > 1)
        {
            ge = num[2] / 2;
            res += ge; num[2] -= ge * 2;
        }
        if (num[2] > 0 && num[1] > 1)
        {
            ge = Math.Min(num[2], num[1] / 2);
            res += ge; num[2] -= ge; num[1] -= ge * 2;
        }
        if (num[2] > 0 && num[1] > 0)
        {
            ge = Math.Min(num[2], num[1]);
            res += ge; num[2] -= ge; num[1] -= ge;
        }
        if (num[2] > 0)
        {
            ge = num[2];
            res += ge; num[2] -= ge;
        }
        res += (num[1] + 4) / 5;
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
