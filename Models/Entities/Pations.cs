using System.ComponentModel.DataAnnotations;

public class Pations
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string Nationalcode { get; set; }
}