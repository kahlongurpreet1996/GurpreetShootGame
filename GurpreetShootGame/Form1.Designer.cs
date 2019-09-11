namespace GurpreetShootGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.starting = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Button();
            this.Firing = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.TryAgain = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunBox
            // 
            this.gunBox.Location = new System.Drawing.Point(240, 94);
            this.gunBox.Name = "gunBox";
            this.gunBox.Size = new System.Drawing.Size(304, 209);
            this.gunBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunBox.TabIndex = 0;
            this.gunBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shoot Game Designed By Gurpreet Kaur";
            // 
            // starting
            // 
            this.starting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starting.Location = new System.Drawing.Point(185, 326);
            this.starting.Name = "starting";
            this.starting.Size = new System.Drawing.Size(90, 40);
            this.starting.TabIndex = 2;
            this.starting.Text = "Start";
            this.starting.UseVisualStyleBackColor = true;
            this.starting.Click += new System.EventHandler(this.starting_Click);
            // 
            // Loading
            // 
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.Location = new System.Drawing.Point(282, 326);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(90, 40);
            this.Loading.TabIndex = 3;
            this.Loading.Text = "Load";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // Firing
            // 
            this.Firing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firing.Location = new System.Drawing.Point(378, 326);
            this.Firing.Name = "Firing";
            this.Firing.Size = new System.Drawing.Size(90, 40);
            this.Firing.TabIndex = 4;
            this.Firing.Text = "Shoot";
            this.Firing.UseVisualStyleBackColor = true;
            this.Firing.Click += new System.EventHandler(this.Firing_Click);
            // 
            // Shoot
            // 
            this.Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.Location = new System.Drawing.Point(474, 326);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(108, 60);
            this.Shoot.TabIndex = 5;
            this.Shoot.Text = "Shoot Away";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // TryAgain
            // 
            this.TryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryAgain.Location = new System.Drawing.Point(321, 372);
            this.TryAgain.Name = "TryAgain";
            this.TryAgain.Size = new System.Drawing.Size(108, 40);
            this.TryAgain.TabIndex = 6;
            this.TryAgain.Text = "Try Again";
            this.TryAgain.UseVisualStyleBackColor = true;
            this.TryAgain.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TryAgain);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Firing);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.starting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gunBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button starting;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Button Firing;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button TryAgain;
        private System.Windows.Forms.Timer timer1;
    }
}

