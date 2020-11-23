namespace Bill_Generater_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PrintingButton = new System.Windows.Forms.Button();
            this.PrintPrevButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.TotalTextBox = new iTalk.iTalk_TextBox_Big();
            this.PriceTextBox = new iTalk.iTalk_TextBox_Big();
            this.ClientNameTextBox = new iTalk.iTalk_TextBox_Big();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century751 SeBd BT", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ali Cafe pvt LTD.";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1014, 94);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderWidth = 10;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 221;
            this.lineShape1.X2 = 801;
            this.lineShape1.Y1 = 74;
            this.lineShape1.Y2 = 74;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name:";
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Items.AddRange(new object[] {
            "",
            "Spicy Cheesy Burger",
            "Mango Ice Cream",
            "Cheese Sandwich Combo",
            "Cheese Ragda",
            "Pani Puri",
            "White Pasta",
            "Cold Cofee",
            "Extra Cheese Pizza"});
            this.ItemNameComboBox.Location = new System.Drawing.Point(187, 217);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(297, 33);
            this.ItemNameComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityComboBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.QuantityComboBox.Location = new System.Drawing.Point(187, 276);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(101, 33);
            this.QuantityComboBox.TabIndex = 2;
            this.QuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.QuantityComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total:-";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ExitButton.FlatAppearance.BorderSize = 10;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::Bill_Generater_System.Properties.Resources.application_exit_4;
            this.ExitButton.Location = new System.Drawing.Point(697, 462);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(232, 71);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "&Exit Application";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // PrintingButton
            // 
            this.PrintingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.PrintingButton.FlatAppearance.BorderSize = 10;
            this.PrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingButton.ForeColor = System.Drawing.Color.White;
            this.PrintingButton.Image = global::Bill_Generater_System.Properties.Resources.document_print_4;
            this.PrintingButton.Location = new System.Drawing.Point(697, 328);
            this.PrintingButton.Name = "PrintingButton";
            this.PrintingButton.Size = new System.Drawing.Size(232, 71);
            this.PrintingButton.TabIndex = 6;
            this.PrintingButton.Text = "  Print";
            this.PrintingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintingButton.UseVisualStyleBackColor = false;
            this.PrintingButton.Click += new System.EventHandler(this.PrintingButton_Click);
            this.PrintingButton.MouseLeave += new System.EventHandler(this.PrintingButton_MouseLeave);
            this.PrintingButton.MouseHover += new System.EventHandler(this.PrintingButton_MouseHover);
            // 
            // PrintPrevButton
            // 
            this.PrintPrevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.PrintPrevButton.FlatAppearance.BorderSize = 10;
            this.PrintPrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPrevButton.ForeColor = System.Drawing.Color.White;
            this.PrintPrevButton.Image = global::Bill_Generater_System.Properties.Resources.document_print_preview_3;
            this.PrintPrevButton.Location = new System.Drawing.Point(697, 233);
            this.PrintPrevButton.Name = "PrintPrevButton";
            this.PrintPrevButton.Size = new System.Drawing.Size(232, 71);
            this.PrintPrevButton.TabIndex = 5;
            this.PrintPrevButton.Text = "   Print Privew";
            this.PrintPrevButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPrevButton.UseVisualStyleBackColor = false;
            this.PrintPrevButton.Click += new System.EventHandler(this.PrintPrevButton_Click);
            this.PrintPrevButton.MouseLeave += new System.EventHandler(this.PrintPrevButton_MouseLeave);
            this.PrintPrevButton.MouseHover += new System.EventHandler(this.PrintPrevButton_MouseHover);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.AddOrderButton.FlatAppearance.BorderSize = 10;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.Image = global::Bill_Generater_System.Properties.Resources.list_add;
            this.AddOrderButton.Location = new System.Drawing.Point(697, 145);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(232, 71);
            this.AddOrderButton.TabIndex = 4;
            this.AddOrderButton.Text = "Add New Order";
            this.AddOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            this.AddOrderButton.MouseLeave += new System.EventHandler(this.AddOrderButton_MouseLeave);
            this.AddOrderButton.MouseHover += new System.EventHandler(this.AddOrderButton_MouseHover);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TotalTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.TotalTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.TotalTextBox.Image = null;
            this.TotalTextBox.Location = new System.Drawing.Point(98, 455);
            this.TotalTextBox.MaxLength = 32767;
            this.TotalTextBox.Multiline = false;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(297, 41);
            this.TotalTextBox.TabIndex = 10;
            this.TotalTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TotalTextBox.UseSystemPasswordChar = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.PriceTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PriceTextBox.Image = null;
            this.PriceTextBox.Location = new System.Drawing.Point(187, 334);
            this.PriceTextBox.MaxLength = 32767;
            this.PriceTextBox.Multiline = false;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = false;
            this.PriceTextBox.Size = new System.Drawing.Size(184, 41);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceTextBox.UseSystemPasswordChar = false;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ClientNameTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ClientNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ClientNameTextBox.Image = null;
            this.ClientNameTextBox.Location = new System.Drawing.Point(187, 145);
            this.ClientNameTextBox.MaxLength = 32767;
            this.ClientNameTextBox.Multiline = false;
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = false;
            this.ClientNameTextBox.Size = new System.Drawing.Size(297, 41);
            this.ClientNameTextBox.TabIndex = 0;
            this.ClientNameTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientNameTextBox.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1014, 568);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrintingButton);
            this.Controls.Add(this.PrintPrevButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Timer timer1;
        private iTalk.iTalk_TextBox_Big ClientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private iTalk.iTalk_TextBox_Big PriceTextBox;
        private System.Windows.Forms.Label label5;
        private iTalk.iTalk_TextBox_Big TotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button PrintPrevButton;
        private System.Windows.Forms.Button PrintingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}