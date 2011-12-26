import java.util.*;

public class CantorDust {
    public int occurrencesNumber(String[] pattern, int time) {
	int res;
	//Ç±Ç±Ç…ãLèqÇÇµÇƒÇ≠ÇæÇ≥Ç¢ÅI
        return res;
    }

// BEGIN CUT HERE
    public static void main(String[] args) {
        try {
            eq(0,(new CantorDust()).occurrencesNumber(new String[] {".X",".."}, 1),1);
            eq(1,(new CantorDust()).occurrencesNumber(new String[] {".."}, 1),2);
            eq(2,(new CantorDust()).occurrencesNumber(new String[] {"."}, 2),65);
            eq(3,(new CantorDust()).occurrencesNumber(new String[] {"X...X"}, 2),4);
            eq(4,(new CantorDust()).occurrencesNumber(new String[] {"X"}, 9),262144);
        } catch( Exception exx) {
            System.err.println(exx);
            exx.printStackTrace(System.err);
        }
    }
    private static void eq( int n, int a, int b ) {
        if ( a==b )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected "+b+", received "+a+".");
    }
// END CUT HERE
}
