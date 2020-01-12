namespace Steam_Stat_Viewer
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
            this.ButtonRequestStats = new System.Windows.Forms.Button();
            this.TextResults = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextAppID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextSteamID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRequestStats
            // 
            this.ButtonRequestStats.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRequestStats.Location = new System.Drawing.Point(175, 265);
            this.ButtonRequestStats.Name = "ButtonRequestStats";
            this.ButtonRequestStats.Size = new System.Drawing.Size(155, 57);
            this.ButtonRequestStats.TabIndex = 4;
            this.ButtonRequestStats.Text = "Request";
            this.ButtonRequestStats.UseVisualStyleBackColor = true;
            this.ButtonRequestStats.Click += new System.EventHandler(this.ButtonRequestStats_Click);
            // 
            // TextResults
            // 
            this.TextResults.Location = new System.Drawing.Point(482, 59);
            this.TextResults.Multiline = true;
            this.TextResults.Name = "TextResults";
            this.TextResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextResults.Size = new System.Drawing.Size(497, 399);
            this.TextResults.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PictureBoxExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 53);
            this.panel1.TabIndex = 6;
            // 
            // PictureBoxExit
            // 
            this.PictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxExit.Image")));
            this.PictureBoxExit.Location = new System.Drawing.Point(948, 7);
            this.PictureBoxExit.Name = "PictureBoxExit";
            this.PictureBoxExit.Size = new System.Drawing.Size(37, 38);
            this.PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxExit.TabIndex = 2;
            this.PictureBoxExit.TabStop = false;
            this.PictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Steam Stat Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextAppID
            // 
            this.TextAppID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextAppID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAppID.ForeColor = System.Drawing.Color.Black;
            this.TextAppID.HintForeColor = System.Drawing.Color.Empty;
            this.TextAppID.HintText = "";
            this.TextAppID.isPassword = false;
            this.TextAppID.LineFocusedColor = System.Drawing.Color.Black;
            this.TextAppID.LineIdleColor = System.Drawing.Color.Black;
            this.TextAppID.LineMouseHoverColor = System.Drawing.Color.Black;
            this.TextAppID.LineThickness = 4;
            this.TextAppID.Location = new System.Drawing.Point(91, 175);
            this.TextAppID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextAppID.Name = "TextAppID";
            this.TextAppID.Size = new System.Drawing.Size(325, 43);
            this.TextAppID.TabIndex = 9;
            this.TextAppID.Text = "AppID";
            this.TextAppID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextSteamID
            // 
            this.TextSteamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSteamID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSteamID.ForeColor = System.Drawing.Color.Black;
            this.TextSteamID.HintForeColor = System.Drawing.Color.Empty;
            this.TextSteamID.HintText = "";
            this.TextSteamID.isPassword = false;
            this.TextSteamID.LineFocusedColor = System.Drawing.Color.Black;
            this.TextSteamID.LineIdleColor = System.Drawing.Color.Black;
            this.TextSteamID.LineMouseHoverColor = System.Drawing.Color.Black;
            this.TextSteamID.LineThickness = 4;
            this.TextSteamID.Location = new System.Drawing.Point(91, 93);
            this.TextSteamID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextSteamID.Name = "TextSteamID";
            this.TextSteamID.Size = new System.Drawing.Size(325, 43);
            this.TextSteamID.TabIndex = 10;
            this.TextSteamID.Text = "SteamID";
            this.TextSteamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(990, 468);
            this.Controls.Add(this.TextSteamID);
            this.Controls.Add(this.TextAppID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextResults);
            this.Controls.Add(this.ButtonRequestStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Statistics Viewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonRequestStats;
        private System.Windows.Forms.TextBox TextResults;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextAppID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextSteamID;
    }
}

