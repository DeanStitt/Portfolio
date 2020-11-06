
public class Student {
	private String name;//declare variables
	private int[] grade;
	private int minimum;
	private int avgGrade;
	private int invalidNum;
	private boolean invalid;

	Student() {
		this("",new int[0]);
	}

	Student(String studentName, int[] grade) {//set variables
		this.name = studentName;
		this.minimum = 60;
		this.avgGrade = 0;
		invalidNum = 0;
		invalid = false;
		setGrade(grade);
	}
	
	

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int[] getGrade() {
		return grade;
		
	}

	public void setGrade(int[] grade) {//calc grade
		this.grade = grade;
		int sum = 0;
		for(int i = 0; i < grade.length; i++) {
			if(grade[i] < 0 || grade[i] >100) {
				invalidNum = grade[i];
				invalid = true;
				break;
			}
			sum += grade[i];
		}
		//if(invalid == false)
		
			avgGrade = sum / grade.length;

	}

	public int getMinimum() {
		return minimum;
	}

	public void setMinimum(int minimum) {
		this.minimum = minimum;
	}

	public int getAvgGrade() {
		return avgGrade;
	}

	public int getInvalidNum() {
		return invalidNum;
	}

	public boolean isInvalid() {
		return invalid;
	}

	public String toString() //set strings based on grades
	{
		if (invalid == true) {
			return "Invalid score of " + invalidNum + " for " + name;
		}
		else if (minimum > avgGrade ) {
			return name + " has a course average of " + avgGrade + " - FAIL";
		}
		else
		{
			return name + " has a course average of " + avgGrade + " - PASS";
		}

	}
}