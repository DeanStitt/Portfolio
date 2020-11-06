import java.text.DecimalFormat;
import java.util.Scanner;

public class Name implements Printable {

	Name() {
	}

	@Override
	public String print() {
		String employeeName;
		String employeeLastName;
		Scanner in = new Scanner(System.in); // Reading from System.in
		System.out.println("Enter your first name: ");
		employeeName = in.nextLine();
		System.out.println("Enter your last name: ");
		employeeLastName = in.nextLine();
		Name.Employee salary = new Name.Employee(employeeName, employeeLastName);
		salary.print();
		return employeeName;
	}

	class Employee implements Printable {

		public Employee(String employeeName, String employeeLastName) {
			Scanner input = new Scanner(System.in);
			System.out.println("Enter your salary: ");
			double salary = input.nextDouble();
			DecimalFormat f = new DecimalFormat("##.00");
			System.out.println("Employee " + employeeName + " " + employeeLastName + " has a salary of $" + f.format(salary));
			input.close();
		}

		@Override
		public String print() {
			String name = null;
			return name;

		}
	}
}