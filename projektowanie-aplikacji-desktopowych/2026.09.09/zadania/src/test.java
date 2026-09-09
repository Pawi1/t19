import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class test {
    void main()
    {
        var scr = new Scanner(System.in);
        var list = new ArrayList<Integer>();
        var rand = new Random();

        System.out.print("Podaj n: ");
        var n = scr.nextInt();

        for (int i = 0; i < n/2; i++) {
            list.add(rand.nextInt());
        }

        System.out.println(list);
    }
}
