using System.ComponentModel.DataAnnotations;

namespace LoginExample.Data.Models {
public class Pet {
    public int Id { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
}