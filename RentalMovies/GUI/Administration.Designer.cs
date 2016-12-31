namespace RentalMovies
{
    partial class Administration
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
            this.TimeLimitTextBox = new System.Windows.Forms.TextBox();
            this.OverduePriceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ChangeLimitsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLimitTextBox
            // 
            this.TimeLimitTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TimeLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeLimitTextBox.Location = new System.Drawing.Point(372, 111);
            this.TimeLimitTextBox.Name = "TimeLimitTextBox";
            this.TimeLimitTextBox.Size = new System.Drawing.Size(60, 26);
            this.TimeLimitTextBox.TabIndex = 141;
            // 
            // OverduePriceTextBox
            // 
            this.OverduePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OverduePriceTextBox.Location = new System.Drawing.Point(372, 42);
            this.OverduePriceTextBox.Name = "OverduePriceTextBox";
            this.OverduePriceTextBox.Size = new System.Drawing.Size(60, 26);
            this.OverduePriceTextBox.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(49, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 20);
            this.label14.TabIndex = 139;
            this.label14.Text = "Dozwolony termin wypożyczenia (w dniach)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(49, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(288, 20);
            this.label15.TabIndex = 138;
            this.label15.Text = "Dzienna kara za przekroczenie terminu:";
            // 
            // ChangeLimitsButton
            // 
            this.ChangeLimitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChangeLimitsButton.Location = new System.Drawing.Point(168, 166);
            this.ChangeLimitsButton.Name = "ChangeLimitsButton";
            this.ChangeLimitsButton.Size = new System.Drawing.Size(124, 50);
            this.ChangeLimitsButton.TabIndex = 151;
            this.ChangeLimitsButton.Text = "Zatwierdź";
            this.ChangeLimitsButton.UseVisualStyleBackColor = true;
            this.ChangeLimitsButton.Click += new System.EventHandler(this.ChangeLimitsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(438, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 192;
            this.label4.Text = "gr";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeLimitsButton);
            this.Controls.Add(this.TimeLimitTextBox);
            this.Controls.Add(this.OverduePriceTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "Administration";
            this.Text = "Administracja";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TimeLimitTextBox;
        public System.Windows.Forms.TextBox OverduePriceTextBox;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button ChangeLimitsButton;
        public System.Windows.Forms.Label label4;
    }
}