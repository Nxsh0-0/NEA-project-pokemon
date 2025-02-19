namespace NEA_project_pokemon
{
    partial class Form2
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
            this.fight_button = new System.Windows.Forms.Button();
            this.catch_button = new System.Windows.Forms.Button();
            this.run_button = new System.Windows.Forms.Button();
            this.Foepokemon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Foename = new System.Windows.Forms.TextBox();
            this.Foehealth = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Foepokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fight_button
            // 
            this.fight_button.Location = new System.Drawing.Point(856, 343);
            this.fight_button.Margin = new System.Windows.Forms.Padding(2);
            this.fight_button.Name = "fight_button";
            this.fight_button.Size = new System.Drawing.Size(119, 58);
            this.fight_button.TabIndex = 0;
            this.fight_button.Text = "Fight";
            this.fight_button.UseVisualStyleBackColor = true;
            // 
            // catch_button
            // 
            this.catch_button.Location = new System.Drawing.Point(988, 307);
            this.catch_button.Margin = new System.Windows.Forms.Padding(2);
            this.catch_button.Name = "catch_button";
            this.catch_button.Size = new System.Drawing.Size(119, 58);
            this.catch_button.TabIndex = 1;
            this.catch_button.Text = "Catch";
            this.catch_button.UseVisualStyleBackColor = true;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(990, 390);
            this.run_button.Margin = new System.Windows.Forms.Padding(2);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(119, 58);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // Foepokemon
            // 
            this.Foepokemon.BackColor = System.Drawing.Color.Transparent;
            this.Foepokemon.Location = new System.Drawing.Point(654, 110);
            this.Foepokemon.Name = "Foepokemon";
            this.Foepokemon.Size = new System.Drawing.Size(308, 171);
            this.Foepokemon.TabIndex = 3;
            this.Foepokemon.TabStop = false;
            this.Foepokemon.Paint += new System.Windows.Forms.PaintEventHandler(this.Foepokemon_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(242, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Foename
            // 
            this.Foename.Location = new System.Drawing.Point(242, 62);
            this.Foename.Multiline = true;
            this.Foename.Name = "Foename";
            this.Foename.ReadOnly = true;
            this.Foename.Size = new System.Drawing.Size(265, 42);
            this.Foename.TabIndex = 5;
            // 
            // Foehealth
            // 
            this.Foehealth.BackColor = System.Drawing.Color.Gray;
            this.Foehealth.ForeColor = System.Drawing.Color.RosyBrown;
            this.Foehealth.Location = new System.Drawing.Point(242, 110);
            this.Foehealth.Name = "Foehealth";
            this.Foehealth.Size = new System.Drawing.Size(245, 37);
            this.Foehealth.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_project_pokemon.Properties.Resources.battlebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 457);
            this.Controls.Add(this.Foehealth);
            this.Controls.Add(this.Foename);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Foepokemon);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.catch_button);
            this.Controls.Add(this.fight_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Foepokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fight_button;
        private System.Windows.Forms.Button catch_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.PictureBox Foepokemon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Foename;
        private System.Windows.Forms.ProgressBar Foehealth;
    }
}