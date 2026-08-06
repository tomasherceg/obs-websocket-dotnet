namespace VmixMouseTracker
{
    partial class ConfigurationForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.AreaTextBox = new System.Windows.Forms.TextBox();
			this.ComboInputNameTextBox = new System.Windows.Forms.TextBox();
			this.ScreenOnlyInputNameTextBox = new System.Windows.Forms.TextBox();
			this.VmixApiBaseUrlTextBox = new System.Windows.Forms.TextBox();
			this.SelectButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tracked area:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Combo input number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Screen only input number:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "vMix API base URL:";
			// 
			// AreaTextBox
			// 
			this.AreaTextBox.Location = new System.Drawing.Point(223, 29);
			this.AreaTextBox.Name = "AreaTextBox";
			this.AreaTextBox.ReadOnly = true;
			this.AreaTextBox.Size = new System.Drawing.Size(178, 20);
			this.AreaTextBox.TabIndex = 2;
			// 
			// ComboInputNameTextBox
			// 
			this.ComboInputNameTextBox.Location = new System.Drawing.Point(223, 73);
			this.ComboInputNameTextBox.Name = "ComboInputNameTextBox";
			this.ComboInputNameTextBox.Size = new System.Drawing.Size(178, 20);
			this.ComboInputNameTextBox.TabIndex = 2;
			// 
			// ScreenOnlyInputNameTextBox
			// 
			this.ScreenOnlyInputNameTextBox.Location = new System.Drawing.Point(223, 117);
			this.ScreenOnlyInputNameTextBox.Name = "ScreenOnlyInputNameTextBox";
			this.ScreenOnlyInputNameTextBox.Size = new System.Drawing.Size(178, 20);
			this.ScreenOnlyInputNameTextBox.TabIndex = 2;
			// 
			// VmixApiBaseUrlTextBox
			// 
			this.VmixApiBaseUrlTextBox.Location = new System.Drawing.Point(223, 161);
			this.VmixApiBaseUrlTextBox.Name = "VmixApiBaseUrlTextBox";
			this.VmixApiBaseUrlTextBox.Size = new System.Drawing.Size(215, 20);
			this.VmixApiBaseUrlTextBox.TabIndex = 2;
			// 
			// SelectButton
			// 
			this.SelectButton.Location = new System.Drawing.Point(407, 27);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(31, 23);
			this.SelectButton.TabIndex = 3;
			this.SelectButton.Text = "...";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(341, 215);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(97, 30);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ConfigurationForm
			// 
			this.AcceptButton = this.SaveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 268);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.SelectButton);
			this.Controls.Add(this.VmixApiBaseUrlTextBox);
			this.Controls.Add(this.ScreenOnlyInputNameTextBox);
			this.Controls.Add(this.ComboInputNameTextBox);
			this.Controls.Add(this.AreaTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(483, 307);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(483, 307);
			this.Name = "ConfigurationForm";
			this.Text = "vMix Mouse Tracker Settings";
			this.Load += new System.EventHandler(this.ConfigurationForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox ComboInputNameTextBox;
        private System.Windows.Forms.TextBox ScreenOnlyInputNameTextBox;
        private System.Windows.Forms.TextBox VmixApiBaseUrlTextBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
