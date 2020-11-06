public class FormattedOutput 
{
	
	public static void main (String[] args)
	{
		double pi = 3.14159265359;
		double G = 6.67408e-11;
		String foo = "Hello World!!";
		
		System.out.printf("my data is %4.2f -- %.6s", pi, foo);//%-4.2 left aligned, %+4.2 right aligned, use printf to get the alignment 
	}

}
