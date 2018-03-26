namespace RLStats
{
    partial class Form1
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
            this.txtReplayPath = new System.Windows.Forms.TextBox();
            this.lblPAth = new System.Windows.Forms.Label();
            this.btnCreateJson = new System.Windows.Forms.Button();
            this.lblReplayFile = new System.Windows.Forms.Label();
            this.txtReplayFile = new System.Windows.Forms.TextBox();
            this.btnParseJson = new System.Windows.Forms.Button();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtReplayPath
            // 
            this.txtReplayPath.Location = new System.Drawing.Point(131, 12);
            this.txtReplayPath.Name = "txtReplayPath";
            this.txtReplayPath.Size = new System.Drawing.Size(523, 20);
            this.txtReplayPath.TabIndex = 0;
            this.txtReplayPath.Text = "C:\\Users\\Nicolas\\Documents\\My Games\\Rocket League\\TAGame\\Demos";
            // 
            // lblPAth
            // 
            this.lblPAth.AutoSize = true;
            this.lblPAth.Location = new System.Drawing.Point(51, 15);
            this.lblPAth.Name = "lblPAth";
            this.lblPAth.Size = new System.Drawing.Size(79, 13);
            this.lblPAth.TabIndex = 1;
            this.lblPAth.Text = "path des replay";
            // 
            // btnCreateJson
            // 
            this.btnCreateJson.Location = new System.Drawing.Point(131, 64);
            this.btnCreateJson.Name = "btnCreateJson";
            this.btnCreateJson.Size = new System.Drawing.Size(136, 23);
            this.btnCreateJson.TabIndex = 2;
            this.btnCreateJson.Text = "Create Json File";
            this.btnCreateJson.UseVisualStyleBackColor = true;
            this.btnCreateJson.Click += new System.EventHandler(this.btnCreateJson_Click);
            // 
            // lblReplayFile
            // 
            this.lblReplayFile.AutoSize = true;
            this.lblReplayFile.Location = new System.Drawing.Point(6, 41);
            this.lblReplayFile.Name = "lblReplayFile";
            this.lblReplayFile.Size = new System.Drawing.Size(119, 13);
            this.lblReplayFile.TabIndex = 4;
            this.lblReplayFile.Text = "nom du fichier de replay";
            // 
            // txtReplayFile
            // 
            this.txtReplayFile.Location = new System.Drawing.Point(131, 38);
            this.txtReplayFile.Name = "txtReplayFile";
            this.txtReplayFile.Size = new System.Drawing.Size(523, 20);
            this.txtReplayFile.TabIndex = 3;
            this.txtReplayFile.Text = "6C697A004DB92BF2792946952C2E4E46.replay";
            // 
            // btnParseJson
            // 
            this.btnParseJson.Location = new System.Drawing.Point(273, 64);
            this.btnParseJson.Name = "btnParseJson";
            this.btnParseJson.Size = new System.Drawing.Size(136, 23);
            this.btnParseJson.TabIndex = 5;
            this.btnParseJson.Text = "Create Objets from Json";
            this.btnParseJson.UseVisualStyleBackColor = true;
            this.btnParseJson.Click += new System.EventHandler(this.btnParseJson_Click);
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 10;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 771);
            this.Controls.Add(this.btnParseJson);
            this.Controls.Add(this.lblReplayFile);
            this.Controls.Add(this.txtReplayFile);
            this.Controls.Add(this.btnCreateJson);
            this.Controls.Add(this.lblPAth);
            this.Controls.Add(this.txtReplayPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReplayPath;
        private System.Windows.Forms.Label lblPAth;
        private System.Windows.Forms.Button btnCreateJson;
        private System.Windows.Forms.Label lblReplayFile;
        private System.Windows.Forms.TextBox txtReplayFile;
        private System.Windows.Forms.Button btnParseJson;
        private System.Windows.Forms.Timer tmrDraw;
    }
}

