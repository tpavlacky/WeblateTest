using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Properties;

namespace Main
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      cbGender.DataSource = Enum.GetValues(typeof(Gender));
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      peopleDgv.DataSource = new BindingList<Person>()
      {
        new Person() {Name = "Karel", LastName = "Novak", Gender = Gender.Male, Description = Resources.FunnyGuy},
        new Person() {Name = "Anna", LastName = "Novakova", Gender = Gender.Female, Description = Resources.NotSoFunnyWoman}
      };
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var people = (BindingList<Person>)peopleDgv.DataSource;
      var person = new Person(){Name = tbName.Text, LastName = tbLastName.Text, Gender = (Gender)cbGender.SelectedItem, Description = tbDescription.Text};
      people.Add(person);
    }
  }
}
