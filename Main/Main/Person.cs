using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Properties;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Main
{
  internal class Person
  {
    [LocalizedDisplayName(nameof(Resources.Name))]
    public string Name { get; set; }

    [LocalizedDisplayName(nameof(Resources.LastName))]
    public string LastName { get; set; }

    [LocalizedDisplayName(nameof(Resources.Gender))]
    public string Gender { get; set; }

    [LocalizedDisplayName(nameof(Resources.Description))]
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
  public class LocalizedDisplayNameAttribute : DisplayNameAttribute
  {
    public LocalizedDisplayNameAttribute(string resourceId)
      : base(GetMessageFromResource(resourceId))
    { }

    private static string GetMessageFromResource(string resourceId)
    {
      return Resources.ResourceManager.GetString(resourceId);
    }
  }
}
