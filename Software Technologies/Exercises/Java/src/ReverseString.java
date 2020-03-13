import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        StringBuilder reversed = new StringBuilder(input);
        reversed.reverse();
        System.out.println(reversed);
    }
}
