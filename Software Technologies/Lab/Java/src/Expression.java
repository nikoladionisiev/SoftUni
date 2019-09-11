public class Expression {

    public static void main(String[] args) {

        double n = (30 + 21) * 1 / 2.0 * (35 - 12 - 1 / 2.0);
        double val = Math.pow(n, 2);

        System.out.format("%.4f", val);
    }
}
