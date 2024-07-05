using System.Windows.Forms;

namespace PO_project
{
    partial class EmployeesForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxEmployees;

        private void InitializeComponent()
        {
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(43, 12);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(194, 212);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // EmployeesForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.listBoxEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.ResumeLayout(false);

        }
    }
}
