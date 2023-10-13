namespace CRUDCustomer.View
{
    partial class FrmNewCustomer
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
            label1 = new Label();
            txtCompanyName = new TextBox();
            BtnSaveCustomer = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtContactName = new TextBox();
            TxtContactTitle = new TextBox();
            TxtAddress = new TextBox();
            TxtCity = new TextBox();
            TxtRegion = new TextBox();
            TxtPostalCode = new TextBox();
            TxtCountry = new TextBox();
            TxtPhone = new TextBox();
            label10 = new Label();
            txtFax = new TextBox();
            label11 = new Label();
            txtIdCustomer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 92);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la empresa";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(177, 84);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 1;
            // 
            // BtnSaveCustomer
            // 
            BtnSaveCustomer.Location = new Point(355, 268);
            BtnSaveCustomer.Name = "BtnSaveCustomer";
            BtnSaveCustomer.Size = new Size(225, 29);
            BtnSaveCustomer.TabIndex = 2;
            BtnSaveCustomer.Text = "Guardar";
            BtnSaveCustomer.UseVisualStyleBackColor = true;
            BtnSaveCustomer.Click += BtnSaveCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 141);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre del contacto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 182);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Cargo del contacto";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 225);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 276);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 100);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 7;
            label6.Text = "Código postal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 141);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 8;
            label7.Text = "País";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 184);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 9;
            label8.Text = "Número de teléfono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 51);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 10;
            label9.Text = "Región";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(177, 133);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(100, 23);
            txtContactName.TabIndex = 11;
            // 
            // TxtContactTitle
            // 
            TxtContactTitle.Location = new Point(177, 177);
            TxtContactTitle.Name = "TxtContactTitle";
            TxtContactTitle.Size = new Size(100, 23);
            TxtContactTitle.TabIndex = 12;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(177, 220);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(100, 23);
            TxtAddress.TabIndex = 13;
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(177, 268);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(100, 23);
            TxtCity.TabIndex = 14;
            // 
            // TxtRegion
            // 
            TxtRegion.Location = new Point(480, 48);
            TxtRegion.Name = "TxtRegion";
            TxtRegion.Size = new Size(100, 23);
            TxtRegion.TabIndex = 15;
            // 
            // TxtPostalCode
            // 
            TxtPostalCode.Location = new Point(480, 97);
            TxtPostalCode.Name = "TxtPostalCode";
            TxtPostalCode.Size = new Size(100, 23);
            TxtPostalCode.TabIndex = 16;
            // 
            // TxtCountry
            // 
            TxtCountry.Location = new Point(480, 138);
            TxtCountry.Name = "TxtCountry";
            TxtCountry.Size = new Size(100, 23);
            TxtCountry.TabIndex = 17;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(480, 184);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(100, 23);
            TxtPhone.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 235);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 19;
            label10.Text = "Fax";
            label10.Click += label10_Click;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(480, 232);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(100, 23);
            txtFax.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 48);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 21;
            label11.Text = "Id del cliente";
            // 
            // txtIdCustomer
            // 
            txtIdCustomer.Location = new Point(177, 45);
            txtIdCustomer.Name = "txtIdCustomer";
            txtIdCustomer.Size = new Size(100, 23);
            txtIdCustomer.TabIndex = 22;
            // 
            // FrmNewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 394);
            Controls.Add(txtIdCustomer);
            Controls.Add(label11);
            Controls.Add(txtFax);
            Controls.Add(label10);
            Controls.Add(TxtPhone);
            Controls.Add(TxtCountry);
            Controls.Add(TxtPostalCode);
            Controls.Add(TxtRegion);
            Controls.Add(TxtCity);
            Controls.Add(TxtAddress);
            Controls.Add(TxtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSaveCustomer);
            Controls.Add(txtCompanyName);
            Controls.Add(label1);
            Name = "FrmNewCustomer";
            Text = "FrmNewCustomer";
            Load += FrmNewCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCompanyName;
        private Button BtnSaveCustomer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtContactName;
        private TextBox TxtContactTitle;
        private TextBox TxtAddress;
        private TextBox TxtCity;
        private TextBox TxtRegion;
        private TextBox TxtPostalCode;
        private TextBox TxtCountry;
        private TextBox TxtPhone;
        private Label label10;
        private TextBox txtFax;
        private Label label11;
        private TextBox txtIdCustomer;
    }
}