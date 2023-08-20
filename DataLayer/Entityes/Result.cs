using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entityes;
[Table("Results")]
public class Result
{
  [Key]
  public string url { get; set; }
  public string description { get; set; }
}