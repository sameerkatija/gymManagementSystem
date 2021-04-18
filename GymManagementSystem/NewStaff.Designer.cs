namespace GymManagementSystem
{
    partial class NewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStaff));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_gymtime = new System.Windows.Forms.Label();
            this.comboBox_gym = new System.Windows.Forms.ComboBox();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_joinDate = new System.Windows.Forms.Label();
            this.textBox_cell = new System.Windows.Forms.TextBox();
            this.lbl_cell = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.combo_Gender = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_cancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(467, 440);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(292, 440);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_gymtime
            // 
            this.lbl_gymtime.AutoSize = true;
            this.lbl_gymtime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gymtime.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gymtime.Location = new System.Drawing.Point(247, 345);
            this.lbl_gymtime.Name = "lbl_gymtime";
            this.lbl_gymtime.Size = new System.Drawing.Size(101, 23);
            this.lbl_gymtime.TabIndex = 39;
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
            this.comboBox_gym.Location = new System.Drawing.Point(371, 345);
            this.comboBox_gym.Name = "comboBox_gym";
            this.comboBox_gym.Size = new System.Drawing.Size(184, 24);
            this.comboBox_gym.TabIndex = 38;
            this.comboBox_gym.Text = " ";
            // 
            // joinDate
            // 
            this.joinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinDate.Location = new System.Drawing.Point(602, 283);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(184, 22);
            this.joinDate.TabIndex = 37;
            // 
            // lbl_joinDate
            // 
            this.lbl_joinDate.AutoSize = true;
            this.lbl_joinDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_joinDate.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_joinDate.Location = new System.Drawing.Point(486, 282);
            this.lbl_joinDate.Name = "lbl_joinDate";
            this.lbl_joinDate.Size = new System.Drawing.Size(96, 23);
            this.lbl_joinDate.TabIndex = 36;
            this.lbl_joinDate.Text = "Join Date";
            // 
            // textBox_cell
            // 
            this.textBox_cell.Location = new System.Drawing.Point(602, 238);
            this.textBox_cell.Name = "textBox_cell";
            this.textBox_cell.Size = new System.Drawing.Size(184, 22);
            this.textBox_cell.TabIndex = 35;
            // 
            // lbl_cell
            // 
            this.lbl_cell.AutoSize = true;
            this.lbl_cell.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cell.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cell.Location = new System.Drawing.Point(486, 238);
            this.lbl_cell.Name = "lbl_cell";
            this.lbl_cell.Size = new System.Drawing.Size(56, 23);
            this.lbl_cell.TabIndex = 34;
            this.lbl_cell.Text = "Cell#";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirth.Location = new System.Drawing.Point(119, 283);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(184, 22);
            this.dateofbirth.TabIndex = 33;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DOB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(30, 282);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(53, 23);
            this.lbl_DOB.TabIndex = 32;
            this.lbl_DOB.Text = "DOB";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(602, 191);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(184, 22);
            this.textBox_Email.TabIndex = 31;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(486, 191);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(61, 23);
            this.lbl_Email.TabIndex = 30;
            this.lbl_Email.Text = "Email";
            // 
            // combo_Gender
            // 
            this.combo_Gender.FormattingEnabled = true;
            this.combo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.combo_Gender.Location = new System.Drawing.Point(119, 238);
            this.combo_Gender.Name = "combo_Gender";
            this.combo_Gender.Size = new System.Drawing.Size(184, 24);
            this.combo_Gender.TabIndex = 28;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(119, 191);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(184, 22);
            this.textBox_Name.TabIndex = 27;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(30, 191);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 23);
            this.lbl_name.TabIndex = 26;
            this.lbl_name.Text = "Name";
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
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gender.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(30, 239);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 23);
            this.lbl_Gender.TabIndex = 29;
            this.lbl_Gender.Text = "Gender";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_logo);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(334, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 103);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pic_cancel
            // 
            this.pic_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pic_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_cancel.BackgroundImage")));
            this.pic_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_cancel.Location = new System.Drawing.Point(772, 25);
            this.pic_cancel.Name = "pic_cancel";
            this.pic_cancel.Size = new System.Drawing.Size(57, 54);
            this.pic_cancel.TabIndex = 23;
            this.pic_cancel.TabStop = false;
            this.pic_cancel.Click += new System.EventHandler(this.pic_cancel_Click);
            // 
            // NewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 489);
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
            this.Controls.Add(this.combo_Gender);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewStaff";
            this.Load += new System.EventHandler(this.NewStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_gymtime;
        private System.Windows.Forms.ComboBox comboBox_gym;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.Label lbl_joinDate;
        private System.Windows.Forms.TextBox textBox_cell;
        private System.Windows.Forms.Label lbl_cell;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.ComboBox combo_Gender;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_cancel;
    }
}