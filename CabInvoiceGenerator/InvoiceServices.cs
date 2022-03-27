namespace CabInvoiceGenerator;

public static class InvoiceService
{
	private static RideRepository rideRepository;

	static InvoiceService()
	{
		rideRepository = new RideRepository();
	}

	public static Invoice GetInvoice(string userID)
	{
		InvoiceGenerator invoiceGenerator = new();
		return invoiceGenerator.CalculateFare(rideRepository.GetRides(userID));
	}

	public static void AddRides(string userID, Ride[] rides)
	{
		rideRepository.Add(userID, rides);
	}
}