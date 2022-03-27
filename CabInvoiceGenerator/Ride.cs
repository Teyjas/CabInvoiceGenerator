namespace CabInvoiceGenerator;

public class Ride
{
	private double distance;
	private double time;
	public double Distance { get { return distance; } }
	public double Time { get { return time; } }

	public Ride(double distance, double time)
	{
		this.distance = distance;
		this.time = time;
	}
}