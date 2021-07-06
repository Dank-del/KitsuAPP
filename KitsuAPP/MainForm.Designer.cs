
namespace KitsuAPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bottompanel = new System.Windows.Forms.Panel();
            this.OKbtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.kitsulogo = new System.Windows.Forms.PictureBox();
            this.coverIMGBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitsulogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverIMGBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.bottompanel.Controls.Add(this.OKbtn);
            this.bottompanel.Controls.Add(this.inputBox);
            this.bottompanel.Controls.Add(this.kitsulogo);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 378);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(800, 72);
            this.bottompanel.TabIndex = 0;
            this.bottompanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(713, 39);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 2;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.SystemColors.Info;
            this.inputBox.Location = new System.Drawing.Point(489, 13);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(299, 22);
            this.inputBox.TabIndex = 1;
            // 
            // kitsulogo
            // 
            this.kitsulogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kitsulogo.Image = global::KitsuAPP.Properties.Resources._1_xCVYNKzZSVWQmCsiC2Znxw;
            this.kitsulogo.Location = new System.Drawing.Point(0, 0);
            this.kitsulogo.Name = "kitsulogo";
            this.kitsulogo.Size = new System.Drawing.Size(193, 72);
            this.kitsulogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kitsulogo.TabIndex = 0;
            this.kitsulogo.TabStop = false;
            // 
            // coverIMGBox
            // 
            this.coverIMGBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coverIMGBox.Location = new System.Drawing.Point(0, 0);
            this.coverIMGBox.Name = "coverIMGBox";
            this.coverIMGBox.Size = new System.Drawing.Size(265, 378);
            this.coverIMGBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverIMGBox.TabIndex = 1;
            this.coverIMGBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(278, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 21);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(282, 51);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(506, 114);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 16);
            this.descriptionLabel.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(282, 185);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 16);
            this.dateLabel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coverIMGBox);
            this.Controls.Add(this.bottompanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Kitsu";
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitsulogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverIMGBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.PictureBox kitsulogo;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.PictureBox coverIMGBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

