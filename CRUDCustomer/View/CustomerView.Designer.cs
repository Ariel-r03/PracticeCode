namespace CRUDCustomer.View
{
    partial class CustomerView
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
            dataGridView1 = new DataGridView();
            btnAddCustomer = new Button();
            BtnDeleteCustomer = new Button();
            btnModifyCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(59, 83);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 23);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Agregar cliente";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // BtnDeleteCustomer
            // 
            BtnDeleteCustomer.Location = new Point(169, 83);
            BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            BtnDeleteCustomer.Size = new Size(75, 23);
            BtnDeleteCustomer.TabIndex = 2;
            BtnDeleteCustomer.Text = "Eliminar cliente";
            BtnDeleteCustomer.UseVisualStyleBackColor = true;
            BtnDeleteCustomer.Click += BtnDeleteCustomer_Click;
            // 
            // btnModifyCustomer
            // 
            btnModifyCustomer.Location = new Point(280, 83);
            btnModifyCustomer.Name = "btnModifyCustomer";
            btnModifyCustomer.Size = new Size(75, 23);
            btnModifyCustomer.TabIndex = 3;
            btnModifyCustomer.Text = "Modificar Cliente";
            btnModifyCustomer.UseVisualStyleBackColor = true;
            btnModifyCustomer.Click += btnModifyCustomer_Click;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModifyCustomer);
            Controls.Add(BtnDeleteCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridView1);
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddCustomer;
        private Button BtnDeleteCustomer;
        private Button btnModifyCustomer;
    }
}