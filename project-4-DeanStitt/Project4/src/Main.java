import java.io.*;
import java.util.*;

public class Main {

	public static void main(String[] args) {

		Scanner in = new Scanner(System.in);
		BufferedReader br = null;
		Student[] students = new Student[0];

		while (true) {
			System.out.println("Enter input file name with type, ex. text.txt: ");//read in file from user
			String fileName = in.nextLine();
			try {
				File file = new File(fileName);//read file
				FileReader fr = new FileReader(file);
				br = new BufferedReader(fr);

				String line;
				br.readLine();
				while ((line = br.readLine()) != null) {//loop  through file for specified data
					Student student;
					String[] studentArray = line.split(",");
					int[] grade = new int[studentArray.length - 2];
					int scholarship = 0;
					String name = studentArray[0];//student name

					if (!studentArray[1].equals("")) {
						scholarship = Integer.parseInt(studentArray[1]);//scholarship data
					} else {
						scholarship = -1;
					}
					for (int i = 2; i < studentArray.length; i++) {
						grade[i - 2] = Integer.parseInt(studentArray[i]);//grades
					}
					if (scholarship != -1) {
						student = new StudentScholarship(name, grade, scholarship);//call method for outfile structure
					} else {
						student = new Student(name, grade);
					}

					Student[] tempArr = new Student[students.length + 1];//create student array
					for (int i = 0; i < students.length; i++) {
						tempArr[i] = students[i];
					}
					tempArr[students.length] = student;
					students = tempArr;

				}
				br.close();
				break;
			} catch (FileNotFoundException e) {
				System.out.println("File not found: " + fileName);//catch exceptions
			} catch (IOException e) {
				System.out.println("Unable to read file: " + fileName);

			}
		}
		String outputFile;
		while (true) {
			System.out.println("Enter output file name with type, ex. text.txt: ");//get output file to print to 
			outputFile = in.nextLine();

			try {
				PrintWriter pw = new PrintWriter(new File(outputFile));//print to output file
				for (int i = 0; i < students.length; i++) {
					pw.println(students[i].toString());
				}
				pw.close();
				break;
			} catch (FileNotFoundException e) {
				System.out.println("File not found: " + outputFile);//catch exceptions

			} catch (IOException e) {
				System.out.println("Unable to read file: " + outputFile);
			}

		}
		System.out.println("Histogram size: ");//get histogram size
		int histogram = in.nextInt();
		while(histogram <1) {
			System.out.println("Enter size > 0: ");//catch invalid input
			histogram = in.nextInt();
		}
		int[] histArr = new int [histogram];//create histogram
		int largest = 0;
		try {
			PrintWriter pw = new PrintWriter(new FileOutputStream(outputFile, true));
			for(int i = 0; i < histArr.length; i++)
			{
				for(int j = 0; j < students.length; j++)
				{
					if((100/histogram)*i <= students[j].getAvgGrade() && (100/histogram)*(i+1)>students[j].getAvgGrade())
					{
						histArr[i]++;
					}
				}
				if(histArr[i] > largest) {
					largest = histArr[i];
				}
			}
			for(int i = largest; i > 0; i--)
			{
				for(int j = 0; j < histArr.length; j++)//create histogram structure 
				{
					if(histArr[j] >= i) {
						pw.print("  *\t");
					}
					else {
						pw.print("  \t");
					}		
				}
				pw.println("");
			}
			pw.print("0\t");
			for(int i = 1; i <= histogram; i++)
			{
				pw.print((100/histogram)*i+"\t");//print histogram 
			}
			pw.close();
			
		} catch (FileNotFoundException e) {
			System.out.println("File not found: " + outputFile);//catch exceptions

		} catch (IOException e) {
			System.out.println("Unable to read file: " + outputFile);
		}

	}

}