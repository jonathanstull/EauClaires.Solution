namespace Salon.Models
{
  public class Client
  {
    public int Id { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string StartDate { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}