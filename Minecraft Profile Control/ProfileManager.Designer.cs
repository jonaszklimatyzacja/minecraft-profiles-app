namespace Minecraft_Profile_Control
{
    partial class ProfileManager
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
            this.ram_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.icon_label = new System.Windows.Forms.Label();
            this.versions_comboBox = new System.Windows.Forms.ComboBox();
            this.ram_input = new System.Windows.Forms.NumericUpDown();
            this.icons_comboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.profile_name_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_input)).BeginInit();
            this.SuspendLayout();
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_label.Location = new System.Drawing.Point(83, 233);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(115, 25);
            this.ram_label.TabIndex = 17;
            this.ram_label.Text = "RAM (GB):";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version_label.Location = new System.Drawing.Point(83, 173);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(91, 25);
            this.version_label.TabIndex = 16;
            this.version_label.Text = "Version:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(88, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // icon_label
            // 
            this.icon_label.AutoSize = true;
            this.icon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.icon_label.Location = new System.Drawing.Point(83, 293);
            this.icon_label.Name = "icon_label";
            this.icon_label.Size = new System.Drawing.Size(52, 25);
            this.icon_label.TabIndex = 22;
            this.icon_label.Text = "Icon";
            // 
            // versions_comboBox
            // 
            this.versions_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versions_comboBox.FormattingEnabled = true;
            this.versions_comboBox.Location = new System.Drawing.Point(213, 170);
            this.versions_comboBox.Name = "versions_comboBox";
            this.versions_comboBox.Size = new System.Drawing.Size(358, 33);
            this.versions_comboBox.TabIndex = 24;
            // 
            // ram_input
            // 
            this.ram_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_input.Location = new System.Drawing.Point(213, 231);
            this.ram_input.Name = "ram_input";
            this.ram_input.Size = new System.Drawing.Size(87, 31);
            this.ram_input.TabIndex = 25;
            // 
            // icons_comboBox
            // 
            this.icons_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.icons_comboBox.FormattingEnabled = true;
            this.icons_comboBox.Location = new System.Drawing.Point(213, 290);
            this.icons_comboBox.Name = "icons_comboBox";
            this.icons_comboBox.Size = new System.Drawing.Size(139, 33);
            this.icons_comboBox.TabIndex = 26;
            this.icons_comboBox.SelectedIndexChanged += new System.EventHandler(this.icons_comboBox_SelectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_button.Location = new System.Drawing.Point(138, 376);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(192, 45);
            this.save_button.TabIndex = 27;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_button.Location = new System.Drawing.Point(426, 376);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(192, 45);
            this.delete_button.TabIndex = 29;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // profile_name_input
            // 
            this.profile_name_input.BackColor = System.Drawing.SystemColors.Control;
            this.profile_name_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profile_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profile_name_input.Location = new System.Drawing.Point(213, 29);
            this.profile_name_input.Name = "profile_name_input";
            this.profile_name_input.Size = new System.Drawing.Size(476, 55);
            this.profile_name_input.TabIndex = 30;
            // 
            // ProfileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.profile_name_input);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.icons_comboBox);
            this.Controls.Add(this.ram_input);
            this.Controls.Add(this.versions_comboBox);
            this.Controls.Add(this.icon_label);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProfileManager";
            this.Text = "ProfileManager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ram_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label icon_label;
        private System.Windows.Forms.ComboBox versions_comboBox;
        private System.Windows.Forms.NumericUpDown ram_input;
        private System.Windows.Forms.ComboBox icons_comboBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox profile_name_input;
    }
}