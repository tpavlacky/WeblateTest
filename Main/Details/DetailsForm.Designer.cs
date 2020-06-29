namespace Details
{
  partial class DetailsForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblDetails = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbName = new System.Windows.Forms.TextBox();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblDetails
      // 
      this.lblDetails.AutoSize = true;
      this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblDetails.ForeColor = System.Drawing.Color.Fuchsia;
      this.lblDetails.Location = new System.Drawing.Point(198, 23);
      this.lblDetails.Name = "lblDetails";
      this.lblDetails.Size = new System.Drawing.Size(98, 31);
      this.lblDetails.TabIndex = 0;
      this.lblDetails.Text = "Details";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 101);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 132);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Last name";
      // 
      // tbName
      // 
      this.tbName.Enabled = false;
      this.tbName.Location = new System.Drawing.Point(143, 98);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(203, 20);
      this.tbName.TabIndex = 3;
      // 
      // tbLastName
      // 
      this.tbLastName.Enabled = false;
      this.tbLastName.Location = new System.Drawing.Point(143, 129);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.Size = new System.Drawing.Size(203, 20);
      this.tbLastName.TabIndex = 4;
      // 
      // DetailsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 324);
      this.Controls.Add(this.tbLastName);
      this.Controls.Add(this.tbName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblDetails);
      this.Name = "DetailsForm";
      this.Text = "DetailsForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDetails;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.TextBox tbLastName;
  }
}