using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client 
  {
    public int ClientId { get; set; }
    public string Name { get; set; }

    //Foreign key
    public int StylistId { get; set; }
    // Reference navigation property 
    public Stylist Stylist { get; set; }
  }
}

