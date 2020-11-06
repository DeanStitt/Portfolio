import java.io.PrintWriter;
import java.io.StringWriter;

public class StringBuffer {

	public static void main(String []args)
	{
		StringWriter chars = new StringWriter();
		//System.out.println("foo");
		
		PrintWriter myBuffer = new PrintWriter(chars);
		
		myBuffer.println("foo");
		System.out.print(chars.toString());
	}
}
