namespace Minecraft_Profile_Control
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_dir_button = new System.Windows.Forms.Button();
            this.version_label = new System.Windows.Forms.Label();
            this.ram_label = new System.Windows.Forms.Label();
            this.launch_button = new System.Windows.Forms.Button();
            this.profiles_box = new System.Windows.Forms.ListBox();
            this.manage_profile_button = new System.Windows.Forms.Button();
            this.version_quantity_label = new System.Windows.Forms.Label();
            this.ram_quantity_label = new System.Windows.Forms.Label();
            this.chosen_profile_name = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.chosen_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chosen_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // open_dir_button
            // 
            this.open_dir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.open_dir_button.Location = new System.Drawing.Point(782, 221);
            this.open_dir_button.Name = "open_dir_button";
            this.open_dir_button.Size = new System.Drawing.Size(180, 38);
            this.open_dir_button.TabIndex = 2;
            this.open_dir_button.Text = "Open profile directory";
            this.open_dir_button.UseVisualStyleBackColor = true;
            this.open_dir_button.Click += new System.EventHandler(this.open_dir_button_Click);
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version_label.Location = new System.Drawing.Point(300, 180);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(91, 25);
            this.version_label.TabIndex = 5;
            this.version_label.Text = "Version:";
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_label.Location = new System.Drawing.Point(300, 226);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(115, 25);
            this.ram_label.TabIndex = 6;
            this.ram_label.Text = "RAM (GB):";
            // 
            // launch_button
            // 
            this.launch_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(69)))));
            this.launch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.launch_button.Location = new System.Drawing.Point(480, 360);
            this.launch_button.Name = "launch_button";
            this.launch_button.Size = new System.Drawing.Size(280, 60);
            this.launch_button.TabIndex = 7;
            this.launch_button.Text = "Launch Minecraft";
            this.launch_button.UseVisualStyleBackColor = false;
            this.launch_button.Click += new System.EventHandler(this.launch_button_Click);
            // 
            // profiles_box
            // 
            this.profiles_box.BackColor = System.Drawing.SystemColors.Control;
            this.profiles_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profiles_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profiles_box.FormattingEnabled = true;
            this.profiles_box.ItemHeight = 20;
            this.profiles_box.Location = new System.Drawing.Point(0, 0);
            this.profiles_box.Margin = new System.Windows.Forms.Padding(30, 3, 3, 10);
            this.profiles_box.Name = "profiles_box";
            this.profiles_box.Size = new System.Drawing.Size(250, 460);
            this.profiles_box.TabIndex = 9;
            this.profiles_box.SelectedIndexChanged += new System.EventHandler(this.profiles_box_SelectedIndexChanged);
            // 
            // manage_profile_button
            // 
            this.manage_profile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manage_profile_button.Location = new System.Drawing.Point(782, 175);
            this.manage_profile_button.Name = "manage_profile_button";
            this.manage_profile_button.Size = new System.Drawing.Size(180, 38);
            this.manage_profile_button.TabIndex = 10;
            this.manage_profile_button.Text = "Manage profile";
            this.manage_profile_button.UseVisualStyleBackColor = true;
            this.manage_profile_button.Click += new System.EventHandler(this.manage_profile_button_Click);
            // 
            // version_quantity_label
            // 
            this.version_quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version_quantity_label.Location = new System.Drawing.Point(425, 180);
            this.version_quantity_label.Name = "version_quantity_label";
            this.version_quantity_label.Size = new System.Drawing.Size(320, 25);
            this.version_quantity_label.TabIndex = 11;
            this.version_quantity_label.Text = "exemplary version";
            // 
            // ram_quantity_label
            // 
            this.ram_quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_quantity_label.Location = new System.Drawing.Point(425, 226);
            this.ram_quantity_label.Name = "ram_quantity_label";
            this.ram_quantity_label.Size = new System.Drawing.Size(320, 25);
            this.ram_quantity_label.TabIndex = 12;
            this.ram_quantity_label.Text = "exemplary ram";
            // 
            // chosen_profile_name
            // 
            this.chosen_profile_name.AutoSize = true;
            this.chosen_profile_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chosen_profile_name.Location = new System.Drawing.Point(420, 42);
            this.chosen_profile_name.Name = "chosen_profile_name";
            this.chosen_profile_name.Size = new System.Drawing.Size(476, 55);
            this.chosen_profile_name.TabIndex = 13;
            this.chosen_profile_name.Text = "chosen profile name";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Control;
            this.add_button.BackgroundImage = global::Minecraft_Profile_Control.Properties.Resources.plus;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.Location = new System.Drawing.Point(256, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(30, 30);
            this.add_button.TabIndex = 14;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // chosen_pictureBox
            // 
            this.chosen_pictureBox.Location = new System.Drawing.Point(305, 42);
            this.chosen_pictureBox.Name = "chosen_pictureBox";
            this.chosen_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.chosen_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chosen_pictureBox.TabIndex = 0;
            this.chosen_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 451);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.chosen_profile_name);
            this.Controls.Add(this.ram_quantity_label);
            this.Controls.Add(this.version_quantity_label);
            this.Controls.Add(this.manage_profile_button);
            this.Controls.Add(this.profiles_box);
            this.Controls.Add(this.launch_button);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.open_dir_button);
            this.Controls.Add(this.chosen_pictureBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Profile Control App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chosen_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chosen_pictureBox;
        private System.Windows.Forms.Button open_dir_button;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label ram_label;
        private System.Windows.Forms.Button launch_button;
        private System.Windows.Forms.ListBox profiles_box;
        private System.Windows.Forms.Button manage_profile_button;
        private System.Windows.Forms.Label version_quantity_label;
        private System.Windows.Forms.Label ram_quantity_label;
        private System.Windows.Forms.Label chosen_profile_name;
        private System.Windows.Forms.Button add_button;
    }
}

