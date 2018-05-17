namespace ADGroupsCreator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelGrpA = new System.Windows.Forms.Panel();
            this.txtBoxRITM = new System.Windows.Forms.TextBox();
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.lblRITM = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.chkboxPopulate = new System.Windows.Forms.CheckBox();
            this.cmbBoxGrography = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelGrpB = new System.Windows.Forms.Panel();
            this.cmbBoxPermissionLevel = new System.Windows.Forms.ComboBox();
            this.lblPermissionLevel = new System.Windows.Forms.Label();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtBoxSuggestion = new System.Windows.Forms.TextBox();
            this.txtBoxShare = new System.Windows.Forms.TextBox();
            this.btnUpdateAD = new System.Windows.Forms.Button();
            this.lblCurrentDC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrpA.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelGrpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrpA
            // 
            this.panelGrpA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelGrpA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrpA.Controls.Add(this.lblCurrentDC);
            this.panelGrpA.Controls.Add(this.txtBoxRITM);
            this.panelGrpA.Controls.Add(this.txtBoxTask);
            this.panelGrpA.Controls.Add(this.lblRITM);
            this.panelGrpA.Controls.Add(this.lblTask);
            this.panelGrpA.Controls.Add(this.chkboxPopulate);
            this.panelGrpA.Controls.Add(this.cmbBoxGrography);
            this.panelGrpA.Controls.Add(this.label3);
            this.panelGrpA.Controls.Add(this.label2);
            this.panelGrpA.Controls.Add(this.txtBoxGroupName);
            this.panelGrpA.Controls.Add(this.label1);
            this.panelGrpA.Location = new System.Drawing.Point(12, 12);
            this.panelGrpA.Name = "panelGrpA";
            this.panelGrpA.Size = new System.Drawing.Size(560, 114);
            this.panelGrpA.TabIndex = 0;
            // 
            // txtBoxRITM
            // 
            this.txtBoxRITM.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRITM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRITM.Location = new System.Drawing.Point(306, 74);
            this.txtBoxRITM.Name = "txtBoxRITM";
            this.txtBoxRITM.Size = new System.Drawing.Size(111, 21);
            this.txtBoxRITM.TabIndex = 3;
            this.txtBoxRITM.TextChanged += new System.EventHandler(this.txtBoxRITM_TextChanged);
            this.txtBoxRITM.Leave += new System.EventHandler(this.txtBoxRITM_Leave);
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTask.Location = new System.Drawing.Point(306, 43);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(111, 21);
            this.txtBoxTask.TabIndex = 2;
            this.txtBoxTask.TextChanged += new System.EventHandler(this.txtBoxTask_TextChanged);
            this.txtBoxTask.Leave += new System.EventHandler(this.txtBoxTask_Leave);
            // 
            // lblRITM
            // 
            this.lblRITM.AutoSize = true;
            this.lblRITM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRITM.Location = new System.Drawing.Point(249, 77);
            this.lblRITM.Name = "lblRITM";
            this.lblRITM.Size = new System.Drawing.Size(54, 15);
            this.lblRITM.TabIndex = 95;
            this.lblRITM.Text = "RITM No";
            this.lblRITM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(249, 47);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(55, 15);
            this.lblTask.TabIndex = 96;
            this.lblTask.Text = "TASK No";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxPopulate
            // 
            this.chkboxPopulate.AutoSize = true;
            this.chkboxPopulate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxPopulate.Location = new System.Drawing.Point(452, 43);
            this.chkboxPopulate.Name = "chkboxPopulate";
            this.chkboxPopulate.Size = new System.Drawing.Size(102, 19);
            this.chkboxPopulate.TabIndex = 4;
            this.chkboxPopulate.Text = "Auto Populate";
            this.chkboxPopulate.UseVisualStyleBackColor = true;
            this.chkboxPopulate.CheckedChanged += new System.EventHandler(this.chkboxPopulate_CheckedChanged);
            // 
            // cmbBoxGrography
            // 
            this.cmbBoxGrography.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBoxGrography.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGrography.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxGrography.FormattingEnabled = true;
            this.cmbBoxGrography.ItemHeight = 13;
            this.cmbBoxGrography.Location = new System.Drawing.Point(107, 73);
            this.cmbBoxGrography.Name = "cmbBoxGrography";
            this.cmbBoxGrography.Size = new System.Drawing.Size(111, 21);
            this.cmbBoxGrography.TabIndex = 5;
            this.cmbBoxGrography.SelectedValueChanged += new System.EventHandler(this.cmbBoxGrography_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Geography";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "Current DC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxGroupName
            // 
            this.txtBoxGroupName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGroupName.Location = new System.Drawing.Point(107, 12);
            this.txtBoxGroupName.Name = "txtBoxGroupName";
            this.txtBoxGroupName.Size = new System.Drawing.Size(441, 21);
            this.txtBoxGroupName.TabIndex = 15;
            this.txtBoxGroupName.TextChanged += new System.EventHandler(this.txtBoxGroupName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "AD Group Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(483, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(402, 298);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelGrpB
            // 
            this.panelGrpB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrpB.Controls.Add(this.cmbBoxPermissionLevel);
            this.panelGrpB.Controls.Add(this.lblPermissionLevel);
            this.panelGrpB.Controls.Add(this.lblValidation);
            this.panelGrpB.Controls.Add(this.txtBoxSuggestion);
            this.panelGrpB.Controls.Add(this.txtBoxShare);
            this.panelGrpB.Location = new System.Drawing.Point(12, 137);
            this.panelGrpB.Name = "panelGrpB";
            this.panelGrpB.Size = new System.Drawing.Size(560, 146);
            this.panelGrpB.TabIndex = 6;
            // 
            // cmbBoxPermissionLevel
            // 
            this.cmbBoxPermissionLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBoxPermissionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPermissionLevel.FormattingEnabled = true;
            this.cmbBoxPermissionLevel.ItemHeight = 13;
            this.cmbBoxPermissionLevel.Location = new System.Drawing.Point(116, 113);
            this.cmbBoxPermissionLevel.Name = "cmbBoxPermissionLevel";
            this.cmbBoxPermissionLevel.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxPermissionLevel.TabIndex = 6;
            this.cmbBoxPermissionLevel.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPermissionLevel_SelectedIndexChanged);
            // 
            // lblPermissionLevel
            // 
            this.lblPermissionLevel.AutoSize = true;
            this.lblPermissionLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionLevel.Location = new System.Drawing.Point(13, 115);
            this.lblPermissionLevel.Name = "lblPermissionLevel";
            this.lblPermissionLevel.Size = new System.Drawing.Size(103, 15);
            this.lblPermissionLevel.TabIndex = 94;
            this.lblPermissionLevel.Text = "Permission Level";
            this.lblPermissionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidation
            // 
            this.lblValidation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblValidation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.Location = new System.Drawing.Point(443, 8);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(102, 25);
            this.lblValidation.TabIndex = 3;
            this.lblValidation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtBoxSuggestion
            // 
            this.txtBoxSuggestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxSuggestion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSuggestion.Location = new System.Drawing.Point(10, 76);
            this.txtBoxSuggestion.Name = "txtBoxSuggestion";
            this.txtBoxSuggestion.ReadOnly = true;
            this.txtBoxSuggestion.Size = new System.Drawing.Size(538, 21);
            this.txtBoxSuggestion.TabIndex = 2;
            // 
            // txtBoxShare
            // 
            this.txtBoxShare.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxShare.Location = new System.Drawing.Point(10, 8);
            this.txtBoxShare.Multiline = true;
            this.txtBoxShare.Name = "txtBoxShare";
            this.txtBoxShare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxShare.Size = new System.Drawing.Size(430, 62);
            this.txtBoxShare.TabIndex = 1;
            this.txtBoxShare.TextChanged += new System.EventHandler(this.txtBoxShare_TextChanged);
            // 
            // btnUpdateAD
            // 
            this.btnUpdateAD.BackColor = System.Drawing.Color.White;
            this.btnUpdateAD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateAD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateAD.Location = new System.Drawing.Point(320, 298);
            this.btnUpdateAD.Name = "btnUpdateAD";
            this.btnUpdateAD.Size = new System.Drawing.Size(76, 23);
            this.btnUpdateAD.TabIndex = 7;
            this.btnUpdateAD.Text = "&Update AD";
            this.btnUpdateAD.UseVisualStyleBackColor = false;
            this.btnUpdateAD.Click += new System.EventHandler(this.btnUpdateAD_Click);
            // 
            // lblCurrentDC
            // 
            this.lblCurrentDC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentDC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCurrentDC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDC.Location = new System.Drawing.Point(107, 43);
            this.lblCurrentDC.Name = "lblCurrentDC";
            this.lblCurrentDC.Size = new System.Drawing.Size(111, 23);
            this.lblCurrentDC.TabIndex = 9;
            this.lblCurrentDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 1);
            this.panel1.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(582, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateAD);
            this.Controls.Add(this.panelGrpB);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelGrpA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "AD Groups Creator Internal Test Release Only";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelGrpA.ResumeLayout(false);
            this.panelGrpA.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelGrpB.ResumeLayout(false);
            this.panelGrpB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelGrpA;
        private System.Windows.Forms.CheckBox chkboxPopulate;
        private System.Windows.Forms.ComboBox cmbBoxGrography;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Panel panelGrpB;
        private System.Windows.Forms.ComboBox cmbBoxPermissionLevel;
        private System.Windows.Forms.Label lblPermissionLevel;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtBoxSuggestion;
        private System.Windows.Forms.TextBox txtBoxShare;
        private System.Windows.Forms.Button btnUpdateAD;
        private System.Windows.Forms.TextBox txtBoxRITM;
        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.Label lblRITM;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblCurrentDC;
        private System.Windows.Forms.Panel panel1;
    }
}

