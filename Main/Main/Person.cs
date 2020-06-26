using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Properties;
using System.ComponentModel.DataAnnotations;

namespace Main
{
  internal class Person
  {
    [Display(Name = nameof(Resources.Name), ResourceType = typeof(Resources))]
    public string Name { get; set; }

    [Display(Name = nameof(Resources.LastName), ResourceType = typeof(Resources))]
    public string LastName { get; set; }

    [Display(Name = nameof(Resources.Gender), ResourceType = typeof(Resources))]
    public string Gender { get; set; }

    [Display(Name = nameof(Resources.Description), ResourceType = typeof(Resources))]
    public string Description { get; set; }
  }

  internal class Gender
  {
    public string Caption { get; set; }

    public int Value { get; set; }

    public Gender(string caption, int value)
    {
      Caption = caption;
      Value = value;
    }
  }
}
