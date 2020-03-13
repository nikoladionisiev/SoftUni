import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int counter = 0;//1; 0; 1; 0; 1; 2;
        int temp = 0;//1; 2;
        int numberToFill = 0;


        //2 1 1 2 3 3 2 2 2 1
        for (int i = 1; i < input.length; i++) {
            if (input[i] == input[i - 1]){
                counter++;
                if (counter > temp){
                    temp = counter;
                    numberToFill = input[i];
                }

            }
            else if(input[i] != input[i -1]){

                if (counter > temp){
                    temp = counter;
                }
                counter = 0;

            }
        }

        List<Integer> result = new ArrayList<>();

        for (int i = 0; i < temp + 1; i++) {
            System.out.print(numberToFill + " ");
        }
    }
}
