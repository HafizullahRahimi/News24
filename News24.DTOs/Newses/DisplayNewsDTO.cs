using System.ComponentModel.DataAnnotations;

namespace News24.DTOs.Newses;

public class DisplayNewsDTO
{
    public int NewsId { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public string ImageName { get; set; }
    public string CreateDate { get; set; }
}