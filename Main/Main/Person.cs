﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
  internal class Person
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public string Description { get; set; }
  }

  internal enum Gender
  {
    Male,
    Female,
    WhoKnows
  }
}
