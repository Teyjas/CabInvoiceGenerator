namespace CabInvoiceGenerator;

public class Ride
{
	private readonly double distance;
	private readonly double time;
	private readonly bool isPremium;
	public double Distance { get { return distance; } }
	public double Time { get { return time; } }
	public bool IsPremium { get { return isPremium; } }

	public Ride(double distance, double time, bool premium = false)
	{
		this.distance = distance;
		this.time = time;
		this.isPremium = premium;
	}
}