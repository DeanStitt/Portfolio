
public class StudentScholarship extends Student{
	
	public StudentScholarship(){
		super();
	}
	public StudentScholarship(String studentName, int[] grade, int scholarship) {
		super(studentName, grade);
		setMinimum(scholarship);
	}
	public String toString() {
		
		if(getMinimum() > getAvgGrade()) {
			return super.toString()+ " due to not meeting scholarship minimum of "+ getMinimum();//set string for not passing scholarship student
		}
		
		return super.toString();
		
	}

}
