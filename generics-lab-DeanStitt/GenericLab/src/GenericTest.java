import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

public class GenericTest extends Generic {
	public static void main(String[] args) {
		HashMap<Double, String> strings = new HashMap<Double, String>();
		Scanner keyboard = new Scanner(System.in);
		double input;
		try {
			do {
				System.out.print("Enter the price of the house: ");
				input = keyboard.nextDouble();
				input.add(new Double(input));
			} while (true);
		} catch (Exception e) {
			Generic.getMin(input);
	}
}
