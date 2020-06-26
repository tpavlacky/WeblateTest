using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Main.Properties;

namespace Main
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      cbGender.DataSource = new List<Gender> {new Gender(Resources.Male, 0), new Gender(Resources.Female, 1), new Gender(Resources.WhoKnows, 2)};
      cbGender.DisplayMember = nameof(Gender.Caption);
      lblHeader.Text = Resources.WeblateTestTool;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      peopleDgv.DataSource = new BindingList<Person>()
      {
        new Person() {Name = "Karel", LastName = "Novak", Gender = Resources.Male, Description = Resources.FunnyGuy},
        new Person() {Name = "Anna", LastName = "Novakova", Gender = Resources.Female, Description = Resources.NotSoFunnyWoman}
      };
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var people = (BindingList<Person>)peopleDgv.DataSource;
      var person = new Person(){Name = tbName.Text, LastName = tbLastName.Text, Gender = ((Gender)cbGender.SelectedItem).Caption, Description = tbDescription.Text};
      people.Add(person);
    }
  }
}
