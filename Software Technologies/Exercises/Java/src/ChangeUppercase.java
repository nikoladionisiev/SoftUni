import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ChangeUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        int openIndex = 0;
        int closeIndex = 0;
        while (true){
            openIndex = text.indexOf("<upcase>",openIndex);
            closeIndex = text.indexOf("</upcase>",closeIndex);
            if(openIndex != -1){
                String sub = text.substring(openIndex+8, closeIndex);
                sub = sub.toUpperCase();

                text = text.substring(0, openIndex) +
                        sub +
                        text.substring(closeIndex+9, text.length());
            }else{
                System.out.println(text);
                return;
            }
        }

    }
}
