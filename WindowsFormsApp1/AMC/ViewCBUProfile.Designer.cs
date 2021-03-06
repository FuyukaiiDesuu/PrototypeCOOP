﻿namespace AMC
{
    partial class ViewCBUProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdWithdrawal = new System.Windows.Forms.RadioButton();
            this.rdDeposit = new System.Windows.Forms.RadioButton();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblics = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblipuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblicsn = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblpartial = new System.Windows.Forms.Label();
            this.lblcompl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnDeactivate.FlatAppearance.BorderSize = 0;
            this.btnDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(45)))), ((int)(((byte)(27)))));
            this.btnDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(45)))), ((int)(((byte)(27)))));
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeactivate.Location = new System.Drawing.Point(221, 539);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(151, 30);
            this.btnDeactivate.TabIndex = 23;
            this.btnDeactivate.Text = "Terminate Account";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(378, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(6, 56);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(129, 17);
            this.lblClose.TabIndex = 30;
            this.lblClose.Text = "Open since 9/2/2017";
            this.lblClose.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 17);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "Open since 9/2/2017";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdAll);
            this.panel2.Controls.Add(this.rdWithdrawal);
            this.panel2.Controls.Add(this.rdDeposit);
            this.panel2.Location = new System.Drawing.Point(106, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 28);
            this.panel2.TabIndex = 26;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(7, 5);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(39, 19);
            this.rdAll.TabIndex = 2;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.Click += new System.EventHandler(this.rdAll_Click);
            // 
            // rdWithdrawal
            // 
            this.rdWithdrawal.AutoSize = true;
            this.rdWithdrawal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWithdrawal.Location = new System.Drawing.Point(128, 5);
            this.rdWithdrawal.Name = "rdWithdrawal";
            this.rdWithdrawal.Size = new System.Drawing.Size(85, 19);
            this.rdWithdrawal.TabIndex = 1;
            this.rdWithdrawal.Text = "Withdrawal";
            this.rdWithdrawal.UseVisualStyleBackColor = true;
            this.rdWithdrawal.Click += new System.EventHandler(this.rdWithdrawal_Click);
            // 
            // rdDeposit
            // 
            this.rdDeposit.AutoSize = true;
            this.rdDeposit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDeposit.Location = new System.Drawing.Point(55, 5);
            this.rdDeposit.Name = "rdDeposit";
            this.rdDeposit.Size = new System.Drawing.Size(65, 19);
            this.rdDeposit.TabIndex = 0;
            this.rdDeposit.Text = "Deposit";
            this.rdDeposit.UseVisualStyleBackColor = true;
            this.rdDeposit.Click += new System.EventHandler(this.rdDeposit_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAccounts.Location = new System.Drawing.Point(5, 199);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(428, 275);
            this.dgvAccounts.TabIndex = 28;
            this.dgvAccounts.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblcompl);
            this.panel1.Controls.Add(this.lblpartial);
            this.panel1.Controls.Add(this.lblics);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblipuc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAccounts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblicsn);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(20, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 480);
            this.panel1.TabIndex = 21;
            // 
            // lblics
            // 
            this.lblics.AutoSize = true;
            this.lblics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblics.Location = new System.Drawing.Point(326, 56);
            this.lblics.Name = "lblics";
            this.lblics.Size = new System.Drawing.Size(40, 17);
            this.lblics.TabIndex = 36;
            this.lblics.Text = "XXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Initial Capital Subsc.: ₱";
            // 
            // lblipuc
            // 
            this.lblipuc.AutoSize = true;
            this.lblipuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblipuc.Location = new System.Drawing.Point(327, 74);
            this.lblipuc.Name = "lblipuc";
            this.lblipuc.Size = new System.Drawing.Size(40, 17);
            this.lblipuc.TabIndex = 34;
            this.lblipuc.Text = "XXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Initial Paid-Up Capital: ₱";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(327, 110);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(40, 17);
            this.lblBalance.TabIndex = 32;
            this.lblBalance.Text = "XXXX";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(213, 110);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(114, 17);
            this.lblX.TabIndex = 31;
            this.lblX.Text = "Current Balance: ₱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Transactions";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-6, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(450, 4);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblicsn
            // 
            this.lblicsn.AutoSize = true;
            this.lblicsn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicsn.Location = new System.Drawing.Point(326, 37);
            this.lblicsn.Name = "lblicsn";
            this.lblicsn.Size = new System.Drawing.Size(40, 17);
            this.lblicsn.TabIndex = 16;
            this.lblicsn.Text = "XXXX";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(168, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 17);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Initial Capital Subsc. No.:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 4);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(283, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Account No. 1 - Last Name, First Name";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(17, 13);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(254, 30);
            this.lblTop.TabIndex = 20;
            this.lblTop.Text = "Capital Build-Up Account";
            // 
            // lblpartial
            // 
            this.lblpartial.AutoSize = true;
            this.lblpartial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartial.Location = new System.Drawing.Point(327, 92);
            this.lblpartial.Name = "lblpartial";
            this.lblpartial.Size = new System.Drawing.Size(26, 17);
            this.lblpartial.TabIndex = 37;
            this.lblpartial.Text = "5%";
            // 
            // lblcompl
            // 
            this.lblcompl.AutoSize = true;
            this.lblcompl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompl.Location = new System.Drawing.Point(327, 127);
            this.lblcompl.Name = "lblcompl";
            this.lblcompl.Size = new System.Drawing.Size(26, 17);
            this.lblcompl.TabIndex = 38;
            this.lblcompl.Text = "5%";
            // 
            // ViewCBUProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(478, 587);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewCBUProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCBUProfile";
            this.Load += new System.EventHandler(this.ViewCBUProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdWithdrawal;
        private System.Windows.Forms.RadioButton rdDeposit;
        public System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblicsn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblipuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblcompl;
        private System.Windows.Forms.Label lblpartial;
    }
}