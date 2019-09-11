import java.util.Scanner;

public class Symmetric_Numbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        for (int i = 1; i <=n ; i++) {

            StringBuilder reversedStr = new StringBuilder();
            reversedStr.append(i);
            reversedStr.reverse();

            if (reversedStr.toString().equals(String.valueOf(i))){
                System.out.println(i);
            }

        }

    }
}
