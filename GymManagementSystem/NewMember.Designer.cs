namespace GymManagementSystem
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            this.pic_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.combo_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.textBox_cell = new System.Windows.Forms.TextBox();
            this.lbl_cell = new System.Windows.Forms.Label();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_joinDate = new System.Windows.Forms.Label();
            this.lbl_gymtime = new System.Windows.Forms.Label();
            this.comboBox_gym = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cancel
            // 
            this.pic_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pic_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_cancel.BackgroundImage")));
            this.pic_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_cancel.Location = new System.Drawing.Point(781, 12);
            this.pic_cancel.Name = "pic_cancel";
            this.pic_cancel.Size = new System.Drawing.Size(57, 54);
            this.pic_cancel.TabIndex = 2;
            this.pic_cancel.TabStop = false;
            this.pic_cancel.Click += new System.EventHandler(this.pic_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_logo);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(343, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 103);
            this.panel2.TabIndex = 5;
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Enabled = false;
            this.lbl_logo.Font = new System.Drawing.Font("Montserrat Alternates Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.Black;
            this.lbl_logo.Location = new System.Drawing.Point(49, 52);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(96, 28);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "Ty Gym";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(39, 178);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 23);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(128, 178);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(184, 22);
            this.textBox_Name.TabIndex = 7;
            // 
            // combo_Gender
            // 
            this.combo_Gender.FormattingEnabled = true;
            this.combo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.combo_Gender.Location = new System.Drawing.Point(128, 225);
            this.combo_Gender.Name = "combo_Gender";
            this.combo_Gender.Size = new System.Drawing.Size(184, 24);
            this.combo_Gender.TabIndex = 8;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gender.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(39, 226);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 23);
            this.lbl_Gender.TabIndex = 9;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(611, 178);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(184, 22);
            this.textBox_Email.TabIndex = 11;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(495, 178);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(61, 23);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DOB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(39, 269);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(53, 23);
            this.lbl_DOB.TabIndex = 13;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dateofbirth
            // 
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirth.Location = new System.Drawing.Point(128, 270);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(184, 22);
            this.dateofbirth.TabIndex = 14;
            // 
            // textBox_cell
            // 
            this.textBox_cell.Location = new System.Drawing.Point(611, 225);
            this.textBox_cell.Name = "textBox_cell";
            this.textBox_cell.Size = new System.Drawing.Size(184, 22);
            this.textBox_cell.TabIndex = 16;
            // 
            // lbl_cell
            // 
            this.lbl_cell.AutoSize = true;
            this.lbl_cell.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cell.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cell.Location = new System.Drawing.Point(495, 225);
            this.lbl_cell.Name = "lbl_cell";
            this.lbl_cell.Size = new System.Drawing.Size(56, 23);
            this.lbl_cell.TabIndex = 15;
            this.lbl_cell.Text = "Cell#";
            // 
            // joinDate
            // 
            this.joinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinDate.Location = new System.Drawing.Point(611, 270);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(184, 22);
            this.joinDate.TabIndex = 18;
            // 
            // lbl_joinDate
            // 
            this.lbl_joinDate.AutoSize = true;
            this.lbl_joinDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_joinDate.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_joinDate.Location = new System.Drawing.Point(495, 269);
            this.lbl_joinDate.Name = "lbl_joinDate";
            this.lbl_joinDate.Size = new System.Drawing.Size(96, 23);
            this.lbl_joinDate.TabIndex = 17;
            this.lbl_joinDate.Text = "Join Date";
            // 
            // lbl_gymtime
            // 
            this.lbl_gymtime.AutoSize = true;
            this.lbl_gymtime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gymtime.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gymtime.Location = new System.Drawing.Point(256, 332);
            this.lbl_gymtime.Name = "lbl_gymtime";
            this.lbl_gymtime.Size = new System.Drawing.Size(101, 23);
            this.lbl_gymtime.TabIndex = 20;
            this.lbl_gymtime.Text = "Gym Time";
            // 
            // comboBox_gym
            // 
            this.comboBox_gym.FormattingEnabled = true;
            this.comboBox_gym.Items.AddRange(new object[] {
            "06AM-08AM",
            "08AM-10AM",
            "10AM-12PM",
            "06PM-08PM",
            "08PM-10PM",
            "10PM-12AM"});
            this.comboBox_gym.Location = new System.Drawing.Point(380, 332);
            this.comboBox_gym.Name = "comboBox_gym";
            this.comboBox_gym.Size = new System.Drawing.Size(184, 24);
            this.comboBox_gym.TabIndex = 19;
            this.comboBox_gym.Text = " ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(301, 427);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(476, 427);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 536);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_gymtime);
            this.Controls.Add(this.comboBox_gym);
            this.Controls.Add(this.joinDate);
            this.Controls.Add(this.lbl_joinDate);
            this.Controls.Add(this.textBox_cell);
            this.Controls.Add(this.lbl_cell);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.combo_Gender);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMember";
            this.Load += new System.EventHandler(this.NewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox combo_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox textBox_cell;
        private System.Windows.Forms.Label lbl_cell;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.Label lbl_joinDate;
        private System.Windows.Forms.Label lbl_gymtime;
        private System.Windows.Forms.ComboBox comboBox_gym;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
    }
}