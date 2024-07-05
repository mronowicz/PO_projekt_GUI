namespace PO_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnShowGarage;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnShowEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstClients = new System.Windows.Forms.ListBox();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnShowGarage = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(12, 12);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(776, 340);
            this.lstClients.TabIndex = 0;
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(12, 370);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(100, 23);
            this.btnShowClients.TabIndex = 1;
            this.btnShowClients.Text = "Pokaż klienta";
            this.btnShowClients.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(118, 370);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 23);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Dodaj klienta";
            this.btnAddClient.UseVisualStyleBackColor = true;

            this.btnEditClient.Location = new System.Drawing.Point(224, 370);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(100, 23);
            this.btnEditClient.TabIndex = 3;
            this.btnEditClient.Text = "Edytuj klienta";
            this.btnEditClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(330, 370);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "Usuń klienta";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnShowGarage
            // 
            this.btnShowGarage.Location = new System.Drawing.Point(436, 370);
            this.btnShowGarage.Name = "btnShowGarage";
            this.btnShowGarage.Size = new System.Drawing.Size(100, 23);
            this.btnShowGarage.TabIndex = 5;
            this.btnShowGarage.Text = "Garaż";
            this.btnShowGarage.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.btnAddEmployee.Location = new System.Drawing.Point(542, 370);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 23);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Dodaj pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.btnShowEmployees.Location = new System.Drawing.Point(668, 370);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(120, 23);
            this.btnShowEmployees.TabIndex = 7;
            this.btnShowEmployees.Text = "Pokaż pracownika";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnShowGarage);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.lstClients);
            this.Name = "Form1";
            this.Text = "mechanik v1.0";
            this.ResumeLayout(false);

        }
    }
}
