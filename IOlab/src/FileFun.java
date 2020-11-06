import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;
import java.util.Scanner;
public class FileFun {
	
	public static void main (String[] args)
	{
		try
		{
		FileInputStream inFile = new FileInputStream("src/input.txt");
		Scanner inFileScanner = new Scanner(inFile);
		String firstLine = inFileScanner.nextLine();
		
		//System.out.println(firstLine);
		
		FileOutputStream outFile = new FileOutputStream("output.txt");
		PrintWriter outPrinter = new PrintWriter(outFile);
		
		outPrinter.println(firstLine);
		inFile.close();
		outPrinter.flush();
		outFile.close();
		}
		catch(Exception e)
		{
			System.out.println(e.getClass()+ " " +e.getMessage());
		}
	}
}
