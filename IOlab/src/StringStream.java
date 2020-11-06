import java.util.Scanner;
public class StringStream {
	
	public static void main(String [] args)
	{
		Scanner foo = new Scanner ("hello-12-3");
		foo.useDelimiter("-");
		
		String bar = foo.next();
		System.out.println(bar);
		int baz = foo.nextInt();
		System.out.println(baz);
	}

}
