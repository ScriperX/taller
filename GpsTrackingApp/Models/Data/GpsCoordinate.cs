public class GpsCoordinate
{
    public int Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime Timestamp { get; set; }
    public int DeviceId { get; set; }
    public Device Device { get; set; }
}
