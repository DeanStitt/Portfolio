
public class Passenger extends Traveler {
	private double cost;
	private SeatClass seat;
	private int rewardsPoints;
	private Location location;
	private int id;
	private String name;
	private int flightHours;
	Passenger(String name, Location location, int id) { 
		super(name, location); 
		this.cost = 0;
		this.rewardsPoints = 0;
		this.seat = null;
		this.location = null;
		this.id = 0;
	}
	
	Passenger(double cost, SeatClass seat, int rewardsPoints, Location location, int id, String name){
	
		this.cost = cost;
		this.seat = seat;
		this.rewardsPoints = rewardsPoints;
		this.location = location;
		this.id = id;
		this.name = name;
		
		private double rewardUpgrade(double cost, SeatClass seat, int rewardsPoints) {
			double firstClass = 1499.99;
			double businessClass = 998.00;
			double coach = 449.00;
			if(rewardsPoints >= 10000 && seat == businessClass || seat == coach) {
				rewardsPoints = rewardsPoints - 10000;
				cost = firstClass;
			}
			else if (rewardsPoints >= 10000 && seat != firstClass) {
				double discount = cost * .20;
				cost = cost - discount;
				rewardsPoints = rewardsPoints - 10000;
			}
			
			return cost;
	}
	
	public String toString() 
	{
		return "[name="+this.name+", id="+this.id+", current="+this.location+", seat = "+this.seat+", cost = "+this.cost+", rewardsPoints = "+this.rewardsPoints+"]";
		int flightHours = 0;
		rewardsPoints = 10 * flightHours;
	}
	public int addFlightToHistory(int flightHours) {
		return this.flightHours = this.flightHours + flightHours;
	}		

	public double getCost() {
		return cost;
	}

	public void setCost(double cost) {
		this.cost = cost;
	}

	public int getSeat() {
		return seat;
	}

	public void setSeat(int seat) {
		this.seat = seat;
	}

	public int getRewardsPoints() {
		return rewardsPoints;
	}

	public void setRewardsPoints(int rewardsPoints) {
		this.rewardsPoints = rewardsPoints;
	}
	
}
