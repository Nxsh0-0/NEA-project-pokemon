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
            this.FoeName = new System.Windows.Forms.TextBox();
            this.Foehealth = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BattlingName = new System.Windows.Forms.TextBox();
            this.BattlingHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foepokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.fight_button.Click += new System.EventHandler(this.fight_button_Click);
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
            this.catch_button.Click += new System.EventHandler(this.catch_button_Click);
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
            this.Foepokemon.Location = new System.Drawing.Point(642, 101);
            this.Foepokemon.Name = "Foepokemon";
            this.Foepokemon.Size = new System.Drawing.Size(308, 171);
            this.Foepokemon.TabIndex = 3;
            this.Foepokemon.TabStop = false;
            this.Foepokemon.Paint += new System.Windows.Forms.PaintEventHandler(this.Foepokemon_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(242, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FoeName
            // 
            this.FoeName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FoeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FoeName.Location = new System.Drawing.Point(242, 62);
            this.FoeName.Multiline = true;
            this.FoeName.Name = "FoeName";
            this.FoeName.ReadOnly = true;
            this.FoeName.Size = new System.Drawing.Size(265, 44);
            this.FoeName.TabIndex = 5;
            this.FoeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Foehealth
            // 
            this.Foehealth.BackColor = System.Drawing.Color.Gray;
            this.Foehealth.ForeColor = System.Drawing.Color.RosyBrown;
            this.Foehealth.Location = new System.Drawing.Point(242, 101);
            this.Foehealth.Name = "Foehealth";
            this.Foehealth.Size = new System.Drawing.Size(265, 39);
            this.Foehealth.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(171, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 210);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 100);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // BattlingName
            // 
            this.BattlingName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BattlingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BattlingName.Location = new System.Drawing.Point(-1, 252);
            this.BattlingName.Multiline = true;
            this.BattlingName.Name = "BattlingName";
            this.BattlingName.ReadOnly = true;
            this.BattlingName.Size = new System.Drawing.Size(265, 44);
            this.BattlingName.TabIndex = 9;
            this.BattlingName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BattlingHealth
            // 
            this.BattlingHealth.BackColor = System.Drawing.Color.Gray;
            this.BattlingHealth.ForeColor = System.Drawing.Color.RosyBrown;
            this.BattlingHealth.Location = new System.Drawing.Point(-1, 302);
            this.BattlingHealth.Name = "BattlingHealth";
            this.BattlingHealth.Size = new System.Drawing.Size(265, 39);
            this.BattlingHealth.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(771, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 200);
            this.label1.TabIndex = 11;
            this.label1.Text = "What will your pokemon do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_project_pokemon.Properties.Resources.battlebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BattlingHealth);
            this.Controls.Add(this.BattlingName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Foehealth);
            this.Controls.Add(this.FoeName);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fight_button;
        private System.Windows.Forms.Button catch_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.PictureBox Foepokemon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FoeName;
        private System.Windows.Forms.ProgressBar Foehealth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox BattlingName;
        private System.Windows.Forms.ProgressBar BattlingHealth;
        private System.Windows.Forms.Label label1;
    }
}