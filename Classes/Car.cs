class Car
{

  /// <summary>
  /// The mode class of a car
  /// </summary>
  /// <param name="carId">The Id of the car, makes the car unique, and mainly used for convience.</param>
  /// <param name="licensePlate">A unique identifier, which is used for references in the system.</param>
  
  private string carId;
  private string licensePlate;

  public Car(string carId, string licensePlate) {
    this.carId = carId;
    this.licensePlate = licensePlate;
  }

  ///Empty constructor
  public Car(){

  }

  ///Getters and setters
  public string carId {get; set;}
  public string licensePlate {get; set;}

}


