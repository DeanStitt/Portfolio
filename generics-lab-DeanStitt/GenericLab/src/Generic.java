import java.util.ArrayList;
import java.util.HashMap;

public class Generic{
		HashMap<Integer, String> strings = new HashMap<Integer, String>();
		
		return userInput;
	}
	public <GEN extends Comparable<GEN>> GEN getAdd(int input){
		if(HashMap.size() < 21) {
			   HashMap.add(input);
			} else {
			   // do nothing
			}
		
		return userInput;
	}
	public static <GEN extends Comparable<GEN>> GEN getMin(int input)
	{
		GEN min = input.get(0);
		
		for(GEN item : input) 
		{
		
			if(item.compareTo(min)< 0)
			{
				min = item;
			}
		}
		System.out.println("Lowest home cost "+ min);
		return min;
	}
	
	public static void main(String[] args) {
	
	}

}
//create double bloat then create arraylist