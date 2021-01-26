namespace CatAndDogs
{
    partial class catPicture
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.getADog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(652, 37);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(301, 308);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            // 
            // getADog
            // 
            this.getADog.Location = new System.Drawing.Point(719, 400);
            this.getADog.Name = "getADog";
            this.getADog.Size = new System.Drawing.Size(146, 23);
            this.getADog.TabIndex = 1;
            this.getADog.Text = "Get Dog Image";
            this.getADog.UseVisualStyleBackColor = true;
            this.getADog.Click += new System.EventHandler(this.getADog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 308);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // catButton
            // 
            this.catButton.Location = new System.Drawing.Point(169, 400);
            this.catButton.Name = "catButton";
            this.catButton.Size = new System.Drawing.Size(117, 23);
            this.catButton.TabIndex = 3;
            this.catButton.Text = "Get Cat Image";
            this.catButton.UseVisualStyleBackColor = true;
            this.catButton.Click += new System.EventHandler(this.catButton_Click);
            // 
            // catPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 530);
            this.Controls.Add(this.catButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getADog);
            this.Controls.Add(this.dogPicture);
            this.Name = "catPicture";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button getADog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button catButton;
    }
}

