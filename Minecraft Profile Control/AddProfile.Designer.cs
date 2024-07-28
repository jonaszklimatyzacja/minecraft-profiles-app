namespace Minecraft_Profile_Control
{
    partial class AddProfile
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
            this.profile_name_input = new System.Windows.Forms.TextBox();
            this.icons_comboBox = new System.Windows.Forms.ComboBox();
            this.ram_input = new System.Windows.Forms.NumericUpDown();
            this.versions_comboBox = new System.Windows.Forms.ComboBox();
            this.icon_label = new System.Windows.Forms.Label();
            this.ram_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ram_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profile_name_input
            // 
            this.profile_name_input.BackColor = System.Drawing.SystemColors.Window;
            this.profile_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profile_name_input.Location = new System.Drawing.Point(204, 56);
            this.profile_name_input.Name = "profile_name_input";
            this.profile_name_input.Size = new System.Drawing.Size(476, 62);
            this.profile_name_input.TabIndex = 38;
            // 
            // icons_comboBox
            // 
            this.icons_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.icons_comboBox.FormattingEnabled = true;
            this.icons_comboBox.Location = new System.Drawing.Point(204, 317);
            this.icons_comboBox.Name = "icons_comboBox";
            this.icons_comboBox.Size = new System.Drawing.Size(139, 33);
            this.icons_comboBox.TabIndex = 37;
            this.icons_comboBox.SelectedIndexChanged += new System.EventHandler(this.icons_comboBox_SelectedIndexChanged);
            // 
            // ram_input
            // 
            this.ram_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_input.Location = new System.Drawing.Point(204, 258);
            this.ram_input.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ram_input.Name = "ram_input";
            this.ram_input.Size = new System.Drawing.Size(87, 31);
            this.ram_input.TabIndex = 36;
            this.ram_input.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // versions_comboBox
            // 
            this.versions_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versions_comboBox.FormattingEnabled = true;
            this.versions_comboBox.Location = new System.Drawing.Point(204, 197);
            this.versions_comboBox.Name = "versions_comboBox";
            this.versions_comboBox.Size = new System.Drawing.Size(358, 33);
            this.versions_comboBox.TabIndex = 35;
            this.versions_comboBox.SelectedIndexChanged += new System.EventHandler(this.versions_comboBox_SelectedIndexChanged);
            // 
            // icon_label
            // 
            this.icon_label.AutoSize = true;
            this.icon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.icon_label.Location = new System.Drawing.Point(74, 320);
            this.icon_label.Name = "icon_label";
            this.icon_label.Size = new System.Drawing.Size(52, 25);
            this.icon_label.TabIndex = 34;
            this.icon_label.Text = "Icon";
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_label.Location = new System.Drawing.Point(74, 260);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(115, 25);
            this.ram_label.TabIndex = 33;
            this.ram_label.Text = "RAM (GB):";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version_label.Location = new System.Drawing.Point(74, 200);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(91, 25);
            this.version_label.TabIndex = 32;
            this.version_label.Text = "Version:";
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.create_button.Location = new System.Drawing.Point(510, 368);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(192, 45);
            this.create_button.TabIndex = 39;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(79, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            // 
            // AddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.profile_name_input);
            this.Controls.Add(this.icons_comboBox);
            this.Controls.Add(this.ram_input);
            this.Controls.Add(this.versions_comboBox);
            this.Controls.Add(this.icon_label);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.pictureBox);
            this.Name = "AddProfile";
            this.Text = "AddProfile";
            ((System.ComponentModel.ISupportInitialize)(this.ram_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox profile_name_input;
        private System.Windows.Forms.ComboBox icons_comboBox;
        private System.Windows.Forms.NumericUpDown ram_input;
        private System.Windows.Forms.ComboBox versions_comboBox;
        private System.Windows.Forms.Label icon_label;
        private System.Windows.Forms.Label ram_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button create_button;
    }
}