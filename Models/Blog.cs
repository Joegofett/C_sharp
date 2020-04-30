using System;
using System.ComponentModel.DataAnnotations;

namespace Joegofett.Models
{
  public class Blog
  {
    public int Id { get; set;}
    public string Title { get; set;}
    public string Author { get; set;}



    [DataType(DataType.Date)]
    public DateTime FirstPost{ get: set:}
    public DateTime Lastedit{ get: set:}
    public MultilineText Blog{ get; set;}
    public Text Comment{ get; set;}
  }
}
