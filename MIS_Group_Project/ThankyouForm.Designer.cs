namespace MIS_Group_Project
{
    partial class ThankyouForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThankyouForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new MaterialSkin.Controls.MaterialButton();
            this.btn_back = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 761);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_exit.Depth = 0;
            this.btn_exit.HighEmphasis = true;
            this.btn_exit.Icon = null;
            this.btn_exit.Location = new System.Drawing.Point(800, 570);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_exit.Size = new System.Drawing.Size(64, 36);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_exit.UseAccentColor = false;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back.Depth = 0;
            this.btn_back.HighEmphasis = true;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(787, 511);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back.Size = new System.Drawing.Size(83, 36);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Go Back";
            this.btn_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back.UseAccentColor = false;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(745, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "You have been registered in the event! The\r\n details has been sent to your regist" +
    "ered email address. \r\nPlease check the details accordingly.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(768, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for registering!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThankyouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 759);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThankyouForm";
            this.Text = "Success";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_exit;
        private MaterialSkin.Controls.MaterialButton btn_back;
    }
}