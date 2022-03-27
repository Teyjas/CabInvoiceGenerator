namespace CabInvoiceGenerator;

public class InvoiceGenerator
{
	private double minFare;
	private double costPerDistance;
	private double costPerMinute;

	/// <summary>
	/// Calculates Fare of a ride using given distance and time
	/// </summary>
	/// <param name="distance">The distance traveled in the ride in KM</param>
	/// <param name="time">The time traveled in minutes</param>
	/// <returns>returns fare of the ride</returns>
	public double CalculateFare(double distance, double time, bool isPremium = false)
	{
		if (isPremium)
		{
			minFare = 20;
			costPerDistance = 15;
			costPerMinute = 2;
		}
		else
		{
			minFare = 5;
			costPerDistance = 10;
			costPerMinute = 1;
		}
		double totalFare = (distance * costPerDistance) + (time * costPerMinute);
		return Math.Max(totalFare, minFare);
	}

	/// <summary>
	/// Calculates Aggregate and Average Fare of multiple ride using given set of rides
	/// </summary>
	/// <param name="rides"></param>
	/// <returns>returns a tuple (int, double, double)</returns>
	/// <exception cref="InvoiceException"></exception>
	public Invoice CalculateFare(Ride[] rides)
	{
		try
		{
			if (rides == null)
				throw new ArgumentNullException(nameof(rides));
			double totalFare = 0;
			foreach (Ride ride in rides)
				totalFare += CalculateFare(ride.Distance, ride.Time, ride.IsPremium);
			return new Invoice(rides.Length, totalFare);
		}
		catch (ArgumentNullException)
		{
			throw new InvoiceException(InvoiceException.ExceptionType.NULL_RIDES, "No Rides was passed in argument");
		}
	}
}