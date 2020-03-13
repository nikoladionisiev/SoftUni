
import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String email = scanner.nextLine();

        String username = email.split("@")[0];

        String replacement = getReplacement(username.length(), '*', email);

        String text = scanner.nextLine();

        text = text.replaceAll(email, replacement);
        System.out.println(text);

    }

    private static String getReplacement(int length, char c, String email) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++) {
            sb.append(c);
        }
        String username = email.split("@")[0];
        return email.replaceFirst(username, sb.toString());
    }
}