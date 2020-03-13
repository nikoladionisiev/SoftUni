import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        char[] arr = input.toCharArray();

        for (int i = 0; i < arr.length; i++) {
            System.out.printf("%c -> %d%n", arr[i], (int)arr[i] - 97);
        }

    }
}
