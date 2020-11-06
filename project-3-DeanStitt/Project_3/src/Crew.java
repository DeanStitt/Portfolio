
public class Crew extends Traveler {
	private String position;
	private int flightHours;
	private Location location;
	private int id;
	private String name;
	Crew(String position, int flightHours){
		this.setPosition(null);
		this.flightHours = 0;
		this.location = null;
		this.setId(0);
		this.setName(null);
	}
	
	Crew(Location location, int id, String name, int flightHours, String position){
		
		this.location = location;
		this.setId(id);
		this.setName(name);
	}
	
	public String toString() 
	{
		return "[name="+this.name+", id="+this.id+", current="+this.location+", position ="+this.position+", flight hours = "+this.flightHours+"]";
	}
	
	public int addFlightToHistory(int flightHours) {
		return this.flightHours = this.flightHours + flightHours;
	}

	public String getPosition() {
		return position;
	}

	public void setPosition(String position) {
		this.position = position;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
}
