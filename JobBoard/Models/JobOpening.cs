using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public static Dictionary<string, int> contactInfo = new Dictionary<string, int>();
    public int Id { get; }
    private static List<JobOpening> _openings = new List<JobOpening>{};

    public JobOpening(string title, string description, string name, int phoneNumber)
    {
      Title = title;
      Description = description;
      contactInfo.Add(name, phoneNumber);
      _openings.Add(this);
      Id = _openings.Count;
    }
  }
}