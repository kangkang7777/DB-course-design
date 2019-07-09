using System.ComponentModel.DataAnnotations;

public class InfoContact
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string ClientName { get; set; }
    [Required]
    public string sex { get; set; }
    [Required]
    public string age { get; set; }
    [Required]
    public string IDNum { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string ClientTel { get; set; }
    [Required]
    public string ClientAddress { get; set; }
}