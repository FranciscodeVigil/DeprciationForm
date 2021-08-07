
namespace DeprciationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inventory = new System.Windows.Forms.TabControl();
            this.tabHowTo = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.RDO = new System.Windows.Forms.RadioButton();
            this.RdoDD = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DateOutLbl = new System.Windows.Forms.Label();
            this.DateInLbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LifeLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EndValLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.StartValLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.InvBox = new System.Windows.Forms.ListBox();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Inventory.SuspendLayout();
            this.tabHowTo.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.tabHowTo);
            this.Inventory.Controls.Add(this.tabInventory);
            this.Inventory.Controls.Add(this.tabSummary);
            this.Inventory.Location = new System.Drawing.Point(12, 12);
            this.Inventory.Name = "Inventory";
            this.Inventory.SelectedIndex = 0;
            this.Inventory.Size = new System.Drawing.Size(776, 426);
            this.Inventory.TabIndex = 0;
            this.Inventory.Tag = "";
            // 
            // tabHowTo
            // 
            this.tabHowTo.Controls.Add(this.textBox1);
            this.tabHowTo.Controls.Add(this.label1);
            this.tabHowTo.Location = new System.Drawing.Point(4, 29);
            this.tabHowTo.Name = "tabHowTo";
            this.tabHowTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabHowTo.Size = new System.Drawing.Size(768, 393);
            this.tabHowTo.TabIndex = 0;
            this.tabHowTo.Text = "How to use this application";
            this.tabHowTo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(527, 101);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depreciation Calculator!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.RDO);
            this.tabInventory.Controls.Add(this.RdoDD);
            this.tabInventory.Controls.Add(this.AddBtn);
            this.tabInventory.Controls.Add(this.dateTimePicker2);
            this.tabInventory.Controls.Add(this.dateTimePicker1);
            this.tabInventory.Controls.Add(this.label8);
            this.tabInventory.Controls.Add(this.DateOutLbl);
            this.tabInventory.Controls.Add(this.DateInLbl);
            this.tabInventory.Controls.Add(this.textBox5);
            this.tabInventory.Controls.Add(this.LifeLbl);
            this.tabInventory.Controls.Add(this.textBox4);
            this.tabInventory.Controls.Add(this.EndValLbl);
            this.tabInventory.Controls.Add(this.textBox3);
            this.tabInventory.Controls.Add(this.StartValLbl);
            this.tabInventory.Controls.Add(this.textBox2);
            this.tabInventory.Controls.Add(this.TitleLbl);
            this.tabInventory.Controls.Add(this.RemoveBtn);
            this.tabInventory.Controls.Add(this.InvBox);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(768, 393);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // RDO
            // 
            this.RDO.AutoSize = true;
            this.RDO.Location = new System.Drawing.Point(422, 244);
            this.RDO.Name = "RDO";
            this.RDO.Size = new System.Drawing.Size(113, 24);
            this.RDO.TabIndex = 17;
            this.RDO.TabStop = true;
            this.RDO.Text = "Straight Line";
            this.RDO.UseVisualStyleBackColor = true;
            // 
            // RdoDD
            // 
            this.RdoDD.AutoSize = true;
            this.RdoDD.Location = new System.Drawing.Point(418, 274);
            this.RdoDD.Name = "RdoDD";
            this.RdoDD.Size = new System.Drawing.Size(146, 24);
            this.RdoDD.TabIndex = 16;
            this.RdoDD.TabStop = true;
            this.RdoDD.Text = "Double Declining";
            this.RdoDD.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(342, 304);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(270, 33);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add Form Item To Inventory";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(479, 206);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 12;
            // 
            // DateOutLbl
            // 
            this.DateOutLbl.AutoSize = true;
            this.DateOutLbl.Location = new System.Drawing.Point(316, 213);
            this.DateOutLbl.Name = "DateOutLbl";
            this.DateOutLbl.Size = new System.Drawing.Size(150, 20);
            this.DateOutLbl.TabIndex = 11;
            this.DateOutLbl.Text = "Date out of inventory";
            this.DateOutLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // DateInLbl
            // 
            this.DateInLbl.AutoSize = true;
            this.DateInLbl.Location = new System.Drawing.Point(316, 175);
            this.DateInLbl.Name = "DateInLbl";
            this.DateInLbl.Size = new System.Drawing.Size(122, 20);
            this.DateInLbl.TabIndex = 10;
            this.DateInLbl.Text = "Date in inventory";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(479, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 27);
            this.textBox5.TabIndex = 9;
            // 
            // LifeLbl
            // 
            this.LifeLbl.AutoSize = true;
            this.LifeLbl.Location = new System.Drawing.Point(316, 137);
            this.LifeLbl.Name = "LifeLbl";
            this.LifeLbl.Size = new System.Drawing.Size(111, 20);
            this.LifeLbl.TabIndex = 8;
            this.LifeLbl.Text = "Lifetime (years)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(479, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(244, 27);
            this.textBox4.TabIndex = 7;
            // 
            // EndValLbl
            // 
            this.EndValLbl.AutoSize = true;
            this.EndValLbl.Location = new System.Drawing.Point(316, 104);
            this.EndValLbl.Name = "EndValLbl";
            this.EndValLbl.Size = new System.Drawing.Size(86, 20);
            this.EndValLbl.TabIndex = 6;
            this.EndValLbl.Text = "End Value $";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(479, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 27);
            this.textBox3.TabIndex = 5;
            // 
            // StartValLbl
            // 
            this.StartValLbl.AutoSize = true;
            this.StartValLbl.Location = new System.Drawing.Point(316, 71);
            this.StartValLbl.Name = "StartValLbl";
            this.StartValLbl.Size = new System.Drawing.Size(113, 20);
            this.StartValLbl.TabIndex = 4;
            this.StartValLbl.Text = "Starting Value $";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(479, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 27);
            this.textBox2.TabIndex = 3;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(316, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(38, 20);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Title";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(16, 289);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(270, 62);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove Selected Item From Inventory";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // InvBox
            // 
            this.InvBox.FormattingEnabled = true;
            this.InvBox.HorizontalScrollbar = true;
            this.InvBox.ItemHeight = 20;
            this.InvBox.Location = new System.Drawing.Point(16, 34);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(270, 244);
            this.InvBox.TabIndex = 0;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.textBox6);
            this.tabSummary.Controls.Add(this.button1);
            this.tabSummary.Location = new System.Drawing.Point(4, 29);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(768, 393);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(184, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(340, 27);
            this.textBox6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Inventory Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inventory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Inventory.ResumeLayout(false);
            this.tabHowTo.ResumeLayout(false);
            this.tabHowTo.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Inventory;
        private System.Windows.Forms.TabPage tabHowTo;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DateOutLbl;
        private System.Windows.Forms.Label DateInLbl;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label LifLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label EndValLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label StartValLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.ListBox InvBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LifeLbl;
        private System.Windows.Forms.RadioButton RDO;
        private System.Windows.Forms.RadioButton RdoDD;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}

