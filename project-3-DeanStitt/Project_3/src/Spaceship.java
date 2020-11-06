
public class Spaceship {
	private String name;
	private Location currentLocation;
	private Location destination;
	private int capacity;
	private int numberOfCrew ;
	private Traveler[] crew;
	private int tripLength ;

	final private static int DEFAULT_CAPACITY = 10;

	
	Spaceship ()
	{
		this.name = null;
		this.location = null;
		this.destination = null;
		this.capacitiy = 0;
		this.numberOfCrew = 0;
		this.Traveler[] crew = 0;
		this.tripLength = 0;
	}
	Spaceship (String name, Location currentLocation, Location destination, int capacity, int tripLength)
	{
		this.name = name;
		this.currentLocation = currentLocation;
		this.destination = destination;
		this.capacity = capacity;
		this.crew = new Traveler[capacity];
		this.tripLength = tripLength;
	}

	public boolean board (Traveler t)
	{
		if (this.canBoard(t))
		{
			this.crew[numberOfCrew++] = t;
			return true;
		}
		return false;
	}

	public boolean goAshore (Traveler t)
	{
		if (this.isOnBoard(t))
		{
			this.remove(t);
			return true;
		}

		return false;
	}

	private void remove (Traveler t)
	{
		for (int i = 0; i < this.numberOfCrew; i++)
		{
			if (crew[i].getId() == t.getId())
			{
				for (int j = i; j < numberOfCrew-1; j++)
				{
					crew[j] = crew[j+1];
				}
				crew[--numberOfCrew] = null;
				break;
			}
		}
	}

	public boolean move ()
	{
		Location temp = this.currentLocation;
		this.currentLocation = this.destination;
		this.moveCrew();
		this.removeCrew();
		this.destination = temp;
		private boolean canMove() 
		{
			this.canBoard(t);
			this.isOnBoard(t);
			if (canBoard = true && isOnBoard = true)
			{
				return true;
			}
		}
		
		return;
	}

	private void moveCrew ()
	{
		for (int i = 0; i < this.numberOfCrew; ++i)
		{
			this.crew[i].setLocation(this.destination);
		}
	}

	private void removeCrew ()
	{
		this.crew = new Traveler[capacity];
		this.numberOfCrew = 0;
	}

	private boolean canBoard (Traveler t)
	{
		return numberOfCrew < capacity
			&& t.getLocation() == this.currentLocation
			&& !this.isOnBoard(t);
	}

	public boolean isOnBoard (Traveler t)
	{
		boolean travelerFound = false;
		for (int i = 0; i < this.numberOfCrew; ++i)
		{
			if (this.crew[i].getId() == t.getId())
			{
				this.toString();
				public int addFlightToHistory(int flightHours) {
					return this.flightHours = this.flightHours + flightHours;
				}
				travelerFound = true;
				break;
			}
		}
		return travelerFound;
	}

	public boolean searchByName (String name)
	{
		boolean travelerFound = false;
		for (int i = 0; i < this.numberOfCrew; ++i)
		{
			if (this.crew[i].getName().equals(name))
			{
				travelerFound = true;
				break;
			}
		}
		return travelerFound;
	}

	public String getName ()
	{
		return this.name;
	}

	public String toString ()
	{
		return "Spaceship [name="+this.name+", current="+this.currentLocation+", destination="+this.getDestination()+", capacity="+this.capacity+", crew="+this.numberOfCrew+", tripLength = "+ this.tripLength+"]";
		this.
	}

	public String getDestination ()
	{
		if (this.destination != null)
		{
			return ""+this.destination;
		}
		return "NULL";
	}
}
