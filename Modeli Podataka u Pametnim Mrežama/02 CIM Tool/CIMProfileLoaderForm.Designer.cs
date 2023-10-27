﻿namespace FTN.ESI.SIMES.CIM.CIMProfileLoader
{
    partial class CIMProfileLoaderForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCIMProfile = new System.Windows.Forms.Label();
            this.textBoxCIMProfile = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.richTextBoxProfile = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.toolTipService = new System.Windows.Forms.ToolTip(this.components);
            this.brojKlasaTb = new System.Windows.Forms.TextBox();
            this.brojAtributaTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBrowse, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 3, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelCIMProfile, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCIMProfile, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonLoad, 3, 2);
            this.tableLayoutPanelMain.Controls.Add(this.richTextBoxProfile, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 3, 3);
            this.tableLayoutPanelMain.Controls.Add(this.brojKlasaTb, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.brojAtributaTb, 0, 4);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 6;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(812, 693);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelTitle, 4);
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(7, 12);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(7, 12, 4, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(328, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Select CIM Profile definition in RDFS format:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(692, 53);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(7, 12, 20, 18);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 28);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse..";
            this.toolTipService.SetToolTip(this.buttonBrowse, "browse for RDFS document..");
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(692, 647);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(7, 4, 20, 18);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.toolTipService.SetToolTip(this.buttonExit, "exit application..");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCIMProfile
            // 
            this.labelCIMProfile.AutoSize = true;
            this.labelCIMProfile.Location = new System.Drawing.Point(27, 53);
            this.labelCIMProfile.Margin = new System.Windows.Forms.Padding(27, 12, 4, 12);
            this.labelCIMProfile.Name = "labelCIMProfile";
            this.labelCIMProfile.Size = new System.Drawing.Size(74, 16);
            this.labelCIMProfile.TabIndex = 2;
            this.labelCIMProfile.Text = "CIM Profile:";
            this.labelCIMProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCIMProfile
            // 
            this.textBoxCIMProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCIMProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxCIMProfile, 2);
            this.textBoxCIMProfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCIMProfile.Location = new System.Drawing.Point(122, 53);
            this.textBoxCIMProfile.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.textBoxCIMProfile.Name = "textBoxCIMProfile";
            this.textBoxCIMProfile.ReadOnly = true;
            this.textBoxCIMProfile.Size = new System.Drawing.Size(558, 22);
            this.textBoxCIMProfile.TabIndex = 0;
            this.textBoxCIMProfile.WordWrap = false;
            this.textBoxCIMProfile.DoubleClick += new System.EventHandler(this.textBoxCIMProfile_DoubleClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(692, 103);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(7, 4, 20, 18);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.toolTipService.SetToolTip(this.buttonLoad, "load CIM profile..");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // richTextBoxProfile
            // 
            this.richTextBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelMain.SetColumnSpan(this.richTextBoxProfile, 2);
            this.richTextBoxProfile.Location = new System.Drawing.Point(122, 103);
            this.richTextBoxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxProfile.Name = "richTextBoxProfile";
            this.richTextBoxProfile.ReadOnly = true;
            this.tableLayoutPanelMain.SetRowSpan(this.richTextBoxProfile, 3);
            this.richTextBoxProfile.Size = new System.Drawing.Size(558, 536);
            this.richTextBoxProfile.TabIndex = 4;
            this.richTextBoxProfile.Text = "";
            this.richTextBoxProfile.WordWrap = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(692, 153);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(7, 4, 20, 18);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save As..";
            this.toolTipService.SetToolTip(this.buttonSave, "save report to file..");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // brojKlasaTb
            // 
            this.brojKlasaTb.Location = new System.Drawing.Point(3, 152);
            this.brojKlasaTb.Name = "brojKlasaTb";
            this.brojKlasaTb.ReadOnly = true;
            this.brojKlasaTb.Size = new System.Drawing.Size(112, 22);
            this.brojKlasaTb.TabIndex = 6;
            // 
            // brojAtributaTb
            // 
            this.brojAtributaTb.Location = new System.Drawing.Point(3, 202);
            this.brojAtributaTb.Name = "brojAtributaTb";
            this.brojAtributaTb.ReadOnly = true;
            this.brojAtributaTb.Size = new System.Drawing.Size(112, 22);
            this.brojAtributaTb.TabIndex = 7;
            // 
            // CIMProfileLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 692);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(694, 605);
            this.Name = "CIMProfileLoaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIM Profile Loader";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCIMProfile;
        private System.Windows.Forms.TextBox textBoxCIMProfile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ToolTip toolTipService;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox richTextBoxProfile;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox brojKlasaTb;
        private System.Windows.Forms.TextBox brojAtributaTb;
    }
}

