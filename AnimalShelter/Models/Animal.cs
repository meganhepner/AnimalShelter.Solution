namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string DateOfAdmittance { get; set; }
    public string Type { get; set; }

    public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime>  
    {  
     // Contains methods and properties  
    }
  }
}