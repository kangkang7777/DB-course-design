using System.ComponentModel.DataAnnotations;

public class Contact
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string ClientLocation { get; set; }
    [Required]
    public int Distance { get; set; }
    [Required]
    public bool HomePick { get; set; }
    [Required]
    public string DistributionCentreName { get; set; }
    [Required]
    public string DistributionCentreAddress { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string DistributionCentreTel { get; set; }
    [Required]
    public string Departure { get; set; }
    [Required]
    public string Destination { get; set; }
    [Required]
    public string CargoType { get; set; }
    [Required]
    public int Weight { get; set; }
    [Required]
    public bool Fragile { get; set; }
}