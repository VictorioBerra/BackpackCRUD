namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.VolumeLbl = new System.Windows.Forms.Label();
            this.VolumeTxt = new System.Windows.Forms.TextBox();
            this.CostLbl = new System.Windows.Forms.Label();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.SearchByNameTxt = new System.Windows.Forms.TextBox();
            this.SearchBynameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new Backpack Item";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1091, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(896, 101);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(335, 22);
            this.NameTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(828, 104);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name:";
            // 
            // VolumeLbl
            // 
            this.VolumeLbl.AutoSize = true;
            this.VolumeLbl.Location = new System.Drawing.Point(828, 149);
            this.VolumeLbl.Name = "VolumeLbl";
            this.VolumeLbl.Size = new System.Drawing.Size(59, 17);
            this.VolumeLbl.TabIndex = 6;
            this.VolumeLbl.Text = "Volume:";
            // 
            // VolumeTxt
            // 
            this.VolumeTxt.Location = new System.Drawing.Point(896, 146);
            this.VolumeTxt.Name = "VolumeTxt";
            this.VolumeTxt.Size = new System.Drawing.Size(335, 22);
            this.VolumeTxt.TabIndex = 5;
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(828, 201);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(40, 17);
            this.CostLbl.TabIndex = 8;
            this.CostLbl.Text = "Cost:";
            // 
            // CostTxt
            // 
            this.CostTxt.Location = new System.Drawing.Point(896, 198);
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(335, 22);
            this.CostTxt.TabIndex = 7;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(827, 61);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(58, 17);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "ERROR";
            this.ErrorLabel.Visible = false;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(12, 12);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(117, 17);
            this.SearchLbl.TabIndex = 10;
            this.SearchLbl.Text = "Search by Name:";
            // 
            // SearchByNameTxt
            // 
            this.SearchByNameTxt.Location = new System.Drawing.Point(135, 9);
            this.SearchByNameTxt.Name = "SearchByNameTxt";
            this.SearchByNameTxt.Size = new System.Drawing.Size(217, 22);
            this.SearchByNameTxt.TabIndex = 11;
            // 
            // SearchBynameBtn
            // 
            this.SearchBynameBtn.Location = new System.Drawing.Point(703, 9);
            this.SearchBynameBtn.Name = "SearchBynameBtn";
            this.SearchBynameBtn.Size = new System.Drawing.Size(85, 31);
            this.SearchBynameBtn.TabIndex = 12;
            this.SearchBynameBtn.Text = "Search";
            this.SearchBynameBtn.UseVisualStyleBackColor = true;
            this.SearchBynameBtn.Click += new System.EventHandler(this.SearchBynameBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 457);
            this.Controls.Add(this.SearchBynameBtn);
            this.Controls.Add(this.SearchByNameTxt);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.VolumeLbl);
            this.Controls.Add(this.VolumeTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Backpack CRUD Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label VolumeLbl;
        private System.Windows.Forms.TextBox VolumeTxt;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox SearchByNameTxt;
        private System.Windows.Forms.Button SearchBynameBtn;
    }
}

