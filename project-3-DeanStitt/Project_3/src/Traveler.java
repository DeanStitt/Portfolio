
public abstract class Traveler {
	private String name;
	private static int paxCreated = 0;
	private int id;
	private Location location;
	
	Traveler ()
	{
		this("Bubba");
		System.out.println("Name is required. Calling this traveler Bubba");
	}
	Traveler (String name)
	{
		this(name, Location.EARTH);
		System.out.println("Location is required. Calling this location EARTH");
	}
	Traveler (String name, Location location)
	{
		this.name = name;
		this.location = location;
		this.id = ++Traveler.paxCreated;
	}

	public abstract String toString();

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
	public abstract int addFlightToHistory(int flightHours);
}


