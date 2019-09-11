import java.util.Scanner;

public class Sum_Two_Numbers {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double num1 = Double.parseDouble(scan.nextLine());
        double num2 = Double.parseDouble(scan.nextLine());

        double result = num1 + num2;

        System.out.format("%.2f", result);
    }
}
