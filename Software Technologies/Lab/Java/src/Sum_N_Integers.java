import java.util.Scanner;

public class Sum_N_Integers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int sum = 0;


        for (int i = 0; i < n; i++) {
            int input = scanner.nextInt();
            sum += input;
        }
        System.out.printf("Sum = %d ", sum);
    }
}
