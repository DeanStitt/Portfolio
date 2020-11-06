
public class ExampleTraveler {
	private String name;
	private static int paxCreated = 0;
	private int id;
	private Location location;
	
	ExampleTraveler ()
	{
		this("Bubba");
		System.out.println("Name is required. Calling this traveler Bubba");
	}
	ExampleTraveler (String name)
	{
		this(name, Location.EARTH);
		System.out.println("Location is required. Calling this location EARTH");
	}
	ExampleTraveler (String name, Location location)
	{
		this.name = name;
		this.location = location;
		this.id = ++ExampleTraveler.paxCreated;
	}

	public String toString ()
	{
		return "[name="+this.name+", id="+this.id+", current="+this.location+"]";
	}

	public Location getLocation ()
	{
		return this.location;
	}

	public String getName ()
	{
		return this.name;
	}

	public int getId ()
	{
		return this.id;
	}

	public void setLocation (Location l)
	{
		this.location = l;
	}
}
