
import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input1 = scanner.nextLine().replaceAll(" ", "");
        String input2 = scanner.nextLine().replaceAll(" ", "");


        char[] arr1 = input1.toCharArray();
        char[] arr2 = input2.toCharArray();

        int counter = 0;
        int shortest = Math.min(arr1.length, arr2.length);

        for (int i = 0; i < shortest; i++) {

            if (arr1[i] < arr2[i]) {
                System.out.println(input1);
                System.out.println(input2);
                return;
            }
            if (arr1[i] > arr2[i]) {
                System.out.println(input2);
                System.out.println(input1);
                return;
            }
            if (arr1[i] == arr2[i]){
                counter++;
            }
            if (counter == shortest){

                if (input1.length() > input2.length()){
                    System.out.println(input2);
                    System.out.println(input1);
                    return;
                }
                else{
                    System.out.println(input1);
                    System.out.println(input2);
                    return;
                }


            }

        }


    }
}
