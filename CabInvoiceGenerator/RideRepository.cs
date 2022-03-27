namespace CabInvoiceGenerator;

public class RideRepository
{
	private readonly Dictionary<string, List<Ride>> userRides;

	public RideRepository()
	{
		userRides = new Dictionary<string, List<Ride>>();
	}

	/// <summary>
	/// Adds a list rides to the repository for the given userID
	/// </summary>
	/// <exception cref="InvoiceException"></exception>
	public void Add(string userID, Ride[] rides)
	{
		if (rides == null)
			throw new InvoiceException(InvoiceException.ExceptionType.NULL_RIDES, "Rides list is empty");
		if (userRides.ContainsKey(userID))
			foreach (var ride in rides)
				userRides[userID].Add(ride);
		else
			userRides.Add(userID, rides.ToList());
	}

	/// <summary>
	/// Gets the list of rides for the given userID as Array
	/// </summary>
	/// <returns>An array of rides</returns>
	/// <exception cref="InvoiceException"></exception>
	public Ride[] GetRides(string userID)
	{
		if (!userRides.ContainsKey(userID))
			throw new InvoiceException(InvoiceException.ExceptionType.INVALID_USER_ID, $"{userID} does not exist");
		return userRides[userID].ToArray();
	}
}