
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        int maxCount = 0;
        int maxElementIndex = 0;
        int currentCount = 1;

        for (int i = 0; i < input.length - 1; i++) {
            int currentNumber = Integer.parseInt(input[i]);
            int nextNumber = Integer.parseInt((input[i + 1]));

            if (currentNumber < nextNumber){
                currentCount++;
                if (currentCount > maxCount){
                    maxCount = currentCount;
                    maxElementIndex = i - currentCount + 2;
                }
            }
            else{
                currentCount = 1;
            }
        }
        for (int i = maxElementIndex; i < maxElementIndex + maxCount; i++) {
            System.out.print(input[i] + " ");
        }
    }
}
