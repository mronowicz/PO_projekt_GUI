using System.Windows.Forms;

namespace PO_project
{
    partial class GarageForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxGarage;

        private void InitializeComponent()
        {
            this.listBoxGarage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxGarage
            // 
            this.listBoxGarage.ItemHeight = 16;
            this.listBoxGarage.Location = new System.Drawing.Point(0, 0);
            this.listBoxGarage.Name = "listBoxGarage";
            this.listBoxGarage.Size = new System.Drawing.Size(657, 388);
            this.listBoxGarage.TabIndex = 0;
            // 
            // GarageForm
            // 
            this.ClientSize = new System.Drawing.Size(657, 391);
            this.Controls.Add(this.listBoxGarage);
            this.Name = "GarageForm";
            this.Text = "Garage";
            this.ResumeLayout(false);

        }
    }
}
