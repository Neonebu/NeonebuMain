
namespace NeonebuMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBgImage = new NeonebuMain.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.btnBgImage);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 0;
            // 
            // btnBgImage
            // 
            this.btnBgImage.BackColor = System.Drawing.Color.White;
            this.btnBgImage.BorderColor = System.Drawing.Color.Black;
            this.btnBgImage.ButtonColor = System.Drawing.Color.Black;
            this.btnBgImage.FlatAppearance.BorderSize = 0;
            this.btnBgImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgImage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBgImage.ForeColor = System.Drawing.Color.Gold;
            this.btnBgImage.Location = new System.Drawing.Point(0, 0);
            this.btnBgImage.Name = "btnBgImage";
            this.btnBgImage.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.btnBgImage.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.btnBgImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBgImage.Size = new System.Drawing.Size(140, 55);
            this.btnBgImage.TabIndex = 0;
            this.btnBgImage.Text = "Bg Image";
            this.btnBgImage.TextColor = System.Drawing.Color.Gold;
            this.btnBgImage.UseVisualStyleBackColor = false;
            this.btnBgImage.Click += new System.EventHandler(this.btnBgImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeonebuMain";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private NeonebuMain.Button_WOC btnBgImage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

