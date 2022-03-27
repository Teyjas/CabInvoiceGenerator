namespace CabInvoiceGenerator;

public class Invoice
{
	private readonly int numberOfRides;
	private readonly double totalFare;
	private readonly double averageFare;

	public int NumberOfRides { get { return numberOfRides; } }
	public double TotalFare { get { return totalFare; } }
	public double AverageFare { get { return averageFare; } }

	public Invoice(int numberOfRides, double totalFare)
	{
		this.numberOfRides = numberOfRides;
		this.totalFare = totalFare;
		averageFare = totalFare / numberOfRides;
	}
}