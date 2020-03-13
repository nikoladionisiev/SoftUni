import java.util.Scanner;

public class FitStringInTwentyChars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        String input = scanner.nextLine();
        
        char[] arr = input.toCharArray();

        for (int i = 0; i < 20; i++) {

            try {
                System.out.print(arr[i]);
            }
            catch (Exception e){
                System.out.print("*");
            }

        }
    }
}
