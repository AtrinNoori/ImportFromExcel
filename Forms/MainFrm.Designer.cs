
namespace ImportFromExcel
{
    partial class MainFrm
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
            this.TopTitle_PNL = new System.Windows.Forms.Panel();
            this.CloseBtn_PICBX = new System.Windows.Forms.PictureBox();
            this.title_LBL = new System.Windows.Forms.Label();
            this.Grid_PNL = new System.Windows.Forms.Panel();
            this.Data_GRD = new System.Windows.Forms.DataGridView();
            this.FileSelect_BTN = new System.Windows.Forms.Button();
            this.Toolbar_PNL = new System.Windows.Forms.Panel();
            this.FileName_LBL = new System.Windows.Forms.Label();
            this.info_LBL = new System.Windows.Forms.Label();
            this.Import_BTN = new System.Windows.Forms.Button();
            this.TopTitle_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn_PICBX)).BeginInit();
            this.Grid_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_GRD)).BeginInit();
            this.Toolbar_PNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopTitle_PNL
            // 
            this.TopTitle_PNL.BackColor = System.Drawing.Color.DodgerBlue;
            this.TopTitle_PNL.Controls.Add(this.CloseBtn_PICBX);
            this.TopTitle_PNL.Controls.Add(this.title_LBL);
            this.TopTitle_PNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTitle_PNL.ForeColor = System.Drawing.Color.Sienna;
            this.TopTitle_PNL.Location = new System.Drawing.Point(0, 0);
            this.TopTitle_PNL.Name = "TopTitle_PNL";
            this.TopTitle_PNL.Size = new System.Drawing.Size(889, 32);
            this.TopTitle_PNL.TabIndex = 0;
            // 
            // CloseBtn_PICBX
            // 
            this.CloseBtn_PICBX.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn_PICBX.Location = new System.Drawing.Point(848, 0);
            this.CloseBtn_PICBX.Name = "CloseBtn_PICBX";
            this.CloseBtn_PICBX.Size = new System.Drawing.Size(41, 32);
            this.CloseBtn_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBtn_PICBX.TabIndex = 1;
            this.CloseBtn_PICBX.TabStop = false;
            this.CloseBtn_PICBX.Click += new System.EventHandler(this.CloseBtn_PICBX_Click);
            // 
            // title_LBL
            // 
            this.title_LBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.title_LBL.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.title_LBL.Location = new System.Drawing.Point(0, 0);
            this.title_LBL.Name = "title_LBL";
            this.title_LBL.Size = new System.Drawing.Size(161, 32);
            this.title_LBL.TabIndex = 0;
            this.title_LBL.Text = "Import     From      Excel";
            this.title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid_PNL
            // 
            this.Grid_PNL.Controls.Add(this.Data_GRD);
            this.Grid_PNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid_PNL.Location = new System.Drawing.Point(0, 32);
            this.Grid_PNL.Name = "Grid_PNL";
            this.Grid_PNL.Size = new System.Drawing.Size(889, 367);
            this.Grid_PNL.TabIndex = 1;
            // 
            // Data_GRD
            // 
            this.Data_GRD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data_GRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_GRD.Location = new System.Drawing.Point(12, 12);
            this.Data_GRD.Name = "Data_GRD";
            this.Data_GRD.RowTemplate.Height = 25;
            this.Data_GRD.Size = new System.Drawing.Size(865, 343);
            this.Data_GRD.TabIndex = 0;
            // 
            // FileSelect_BTN
            // 
            this.FileSelect_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileSelect_BTN.Location = new System.Drawing.Point(15, 409);
            this.FileSelect_BTN.Name = "FileSelect_BTN";
            this.FileSelect_BTN.Size = new System.Drawing.Size(132, 44);
            this.FileSelect_BTN.TabIndex = 2;
            this.FileSelect_BTN.Text = "Select File";
            this.FileSelect_BTN.UseVisualStyleBackColor = true;
            this.FileSelect_BTN.Click += new System.EventHandler(this.FileSelect_BTN_Click);
            // 
            // Toolbar_PNL
            // 
            this.Toolbar_PNL.BackColor = System.Drawing.Color.Orchid;
            this.Toolbar_PNL.Controls.Add(this.FileName_LBL);
            this.Toolbar_PNL.Controls.Add(this.info_LBL);
            this.Toolbar_PNL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Toolbar_PNL.Location = new System.Drawing.Point(0, 468);
            this.Toolbar_PNL.Name = "Toolbar_PNL";
            this.Toolbar_PNL.Size = new System.Drawing.Size(889, 29);
            this.Toolbar_PNL.TabIndex = 3;
            // 
            // FileName_LBL
            // 
            this.FileName_LBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileName_LBL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileName_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.FileName_LBL.Location = new System.Drawing.Point(110, 0);
            this.FileName_LBL.Name = "FileName_LBL";
            this.FileName_LBL.Size = new System.Drawing.Size(776, 29);
            this.FileName_LBL.TabIndex = 2;
            this.FileName_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_LBL
            // 
            this.info_LBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.info_LBL.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.info_LBL.Location = new System.Drawing.Point(0, 0);
            this.info_LBL.Name = "info_LBL";
            this.info_LBL.Size = new System.Drawing.Size(110, 29);
            this.info_LBL.TabIndex = 1;
            this.info_LBL.Text = "selected     file";
            this.info_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Import_BTN
            // 
            this.Import_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Import_BTN.Location = new System.Drawing.Point(153, 409);
            this.Import_BTN.Name = "Import_BTN";
            this.Import_BTN.Size = new System.Drawing.Size(132, 44);
            this.Import_BTN.TabIndex = 4;
            this.Import_BTN.Text = "Import";
            this.Import_BTN.UseVisualStyleBackColor = true;
            this.Import_BTN.Click += new System.EventHandler(this.Import_BTN_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 497);
            this.Controls.Add(this.Import_BTN);
            this.Controls.Add(this.Toolbar_PNL);
            this.Controls.Add(this.FileSelect_BTN);
            this.Controls.Add(this.Grid_PNL);
            this.Controls.Add(this.TopTitle_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.Text = "Import From Excel";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.TopTitle_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn_PICBX)).EndInit();
            this.Grid_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_GRD)).EndInit();
            this.Toolbar_PNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopTitle_PNL;
        private System.Windows.Forms.PictureBox CloseBtn_PICBX;
        private System.Windows.Forms.Label title_LBL;
        private System.Windows.Forms.Panel Grid_PNL;
        private System.Windows.Forms.DataGridView Data_GRD;
        private System.Windows.Forms.Button FileSelect_BTN;
        private System.Windows.Forms.Panel Toolbar_PNL;
        private System.Windows.Forms.Label FileName_LBL;
        private System.Windows.Forms.Label info_LBL;
        private System.Windows.Forms.Button Import_BTN;
    }
}

