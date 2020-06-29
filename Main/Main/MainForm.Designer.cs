namespace Main
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblHeader = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.peopleDgv = new System.Windows.Forms.DataGridView();
      this.tbName = new System.Windows.Forms.TextBox();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.tbDescription = new System.Windows.Forms.TextBox();
      this.cbGender = new System.Windows.Forms.ComboBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnOpen = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.peopleDgv)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.peopleDgv, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.tbLastName, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbDescription, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.cbGender, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.btnOpen, 0, 6);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // lblHeader
      // 
      resources.ApplyResources(this.lblHeader, "lblHeader");
      this.tableLayoutPanel1.SetColumnSpan(this.lblHeader, 2);
      this.lblHeader.Name = "lblHeader";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // peopleDgv
      // 
      this.peopleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.peopleDgv, "peopleDgv");
      this.peopleDgv.MultiSelect = false;
      this.peopleDgv.Name = "peopleDgv";
      this.peopleDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      // 
      // tbName
      // 
      resources.ApplyResources(this.tbName, "tbName");
      this.tbName.Name = "tbName";
      // 
      // tbLastName
      // 
      resources.ApplyResources(this.tbLastName, "tbLastName");
      this.tbLastName.Name = "tbLastName";
      // 
      // tbDescription
      // 
      resources.ApplyResources(this.tbDescription, "tbDescription");
      this.tbDescription.Name = "tbDescription";
      // 
      // cbGender
      // 
      resources.ApplyResources(this.cbGender, "cbGender");
      this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbGender.FormattingEnabled = true;
      this.cbGender.Name = "cbGender";
      // 
      // btnAdd
      // 
      resources.ApplyResources(this.btnAdd, "btnAdd");
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnOpen
      // 
      resources.ApplyResources(this.btnOpen, "btnOpen");
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.peopleDgv)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView peopleDgv;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnOpen;
    }
}

