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
            ((System.ComponentModel.ISupportInitialize)(this.Foepokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // fight_button
            // 
            this.fight_button.Location = new System.Drawing.Point(842, 307);
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
            this.run_button.Location = new System.Drawing.Point(920, 388);
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
            this.Foepokemon.Location = new System.Drawing.Point(665, 72);
            this.Foepokemon.Name = "Foepokemon";
            this.Foepokemon.Size = new System.Drawing.Size(308, 170);
            this.Foepokemon.TabIndex = 3;
            this.Foepokemon.TabStop = false;
            this.Foepokemon.Paint += new System.Windows.Forms.PaintEventHandler(this.Foepokemon_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_project_pokemon.Properties.Resources.battlebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 457);
            this.Controls.Add(this.Foepokemon);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.catch_button);
            this.Controls.Add(this.fight_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foepokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fight_button;
        private System.Windows.Forms.Button catch_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.PictureBox Foepokemon;
    }
}