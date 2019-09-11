import java.util.Arrays;
import java.util.Scanner;

public class Largest_Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Arrays.sort(nums);

        int count = Math.min(3, nums.length);

        for (int i = 0; i < count; i++) {
            System.out.println(nums[nums.length - i - 1] + " ");
        }
    }
}
