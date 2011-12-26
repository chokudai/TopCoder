import java.math.BigInteger;

public class SuperSum {
    int mod = 1000000007;

    public int calculate(int k, int n)
    {
        int i;
        int start = Math.max(n, k);
        int goal = k + n;
        BigInteger res = new BigInteger("1");
        if(n==1) return 1;
        for (i = start; i <= goal; i++) res = res.multiply(new BigInteger(""+i));
        for (i = 1; i <= goal - start + 1; i++) res = res.divide(new BigInteger(""+i));
        return (res.mod(new BigInteger(""+mod))).intValue();
    }
}
