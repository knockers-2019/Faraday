public interface ICar {
  
  /// <summary>
  /// Returns a list of available cars.
  /// </summary>
  /// <returns>Returns a list of available cars.</returns>
  public List<Car> ShowAvailableCars(string place, DateTime time) {}
  
  /// <summary>
  /// Returns all the details of a specific car.
  /// </summary>
  /// <returns>Returns a car object.</returns>
  public Car getCarDetails(string carId) {}
}
