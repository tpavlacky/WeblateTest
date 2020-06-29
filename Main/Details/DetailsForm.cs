using System.Windows.Forms;

namespace Details
{
  public partial class DetailsForm : Form
  {
    public DetailsForm() : this(string.Empty, string.Empty)
    {
    }

    public DetailsForm(string name, string lastName)
    {
      InitializeComponent();
      tbName.Text = name;
      tbLastName.Text = lastName;
    }
  }
}
