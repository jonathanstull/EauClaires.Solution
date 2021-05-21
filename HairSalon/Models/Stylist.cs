using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string StartDate { get; set; }
    public int LeaseRate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}