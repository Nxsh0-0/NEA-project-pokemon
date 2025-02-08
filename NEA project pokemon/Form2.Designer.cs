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
            this.SuspendLayout();
            // 
            // fight_button
            // 
            this.fight_button.Location = new System.Drawing.Point(1122, 378);
            this.fight_button.Name = "fight_button";
            this.fight_button.Size = new System.Drawing.Size(159, 72);
            this.fight_button.TabIndex = 0;
            this.fight_button.Text = "Fight";
            this.fight_button.UseVisualStyleBackColor = true;
            // 
            // catch_button
            // 
            this.catch_button.Location = new System.Drawing.Point(1317, 378);
            this.catch_button.Name = "catch_button";
            this.catch_button.Size = new System.Drawing.Size(159, 72);
            this.catch_button.TabIndex = 1;
            this.catch_button.Text = "Catch";
            this.catch_button.UseVisualStyleBackColor = true;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(1317, 477);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(159, 72);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 563);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.catch_button);
            this.Controls.Add(this.fight_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fight_button;
        private System.Windows.Forms.Button catch_button;
        private System.Windows.Forms.Button run_button;
    }
}