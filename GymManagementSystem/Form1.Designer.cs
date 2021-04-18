namespace GymManagementSystem
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.pic_cancel = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_searchMember = new System.Windows.Forms.Button();
            this.btn_deleteMember = new System.Windows.Forms.Button();
            this.btn_newStaff = new System.Windows.Forms.Button();
            this.btn_newMember = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cancel
            // 
            this.pic_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pic_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_cancel.BackgroundImage")));
            this.pic_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_cancel.Location = new System.Drawing.Point(1040, 17);
            this.pic_cancel.Name = "pic_cancel";
            this.pic_cancel.Size = new System.Drawing.Size(57, 54);
            this.pic_cancel.TabIndex = 0;
            this.pic_cancel.TabStop = false;
            this.pic_cancel.Click += new System.EventHandler(this.pic_cancel_Click);
            // 
            // pic_min
            // 
            this.pic_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_min.BackColor = System.Drawing.Color.Transparent;
            this.pic_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_min.BackgroundImage")));
            this.pic_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_min.Location = new System.Drawing.Point(968, 17);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(57, 54);
            this.pic_min.TabIndex = 1;
            this.pic_min.TabStop = false;
            this.pic_min.Click += new System.EventHandler(this.pic_min_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_searchMember);
            this.panel1.Controls.Add(this.btn_deleteMember);
            this.panel1.Controls.Add(this.btn_newStaff);
            this.panel1.Controls.Add(this.btn_newMember);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 556);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Black;
            this.btn_logout.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(3, 487);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(289, 73);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_searchMember
            // 
            this.btn_searchMember.BackColor = System.Drawing.Color.Black;
            this.btn_searchMember.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchMember.ForeColor = System.Drawing.Color.White;
            this.btn_searchMember.Location = new System.Drawing.Point(3, 329);
            this.btn_searchMember.Name = "btn_searchMember";
            this.btn_searchMember.Size = new System.Drawing.Size(289, 73);
            this.btn_searchMember.TabIndex = 4;
            this.btn_searchMember.Text = "Search Member";
            this.btn_searchMember.UseVisualStyleBackColor = false;
            this.btn_searchMember.Click += new System.EventHandler(this.btn_searchMember_Click);
            // 
            // btn_deleteMember
            // 
            this.btn_deleteMember.BackColor = System.Drawing.Color.Black;
            this.btn_deleteMember.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteMember.ForeColor = System.Drawing.Color.White;
            this.btn_deleteMember.Location = new System.Drawing.Point(3, 408);
            this.btn_deleteMember.Name = "btn_deleteMember";
            this.btn_deleteMember.Size = new System.Drawing.Size(289, 73);
            this.btn_deleteMember.TabIndex = 3;
            this.btn_deleteMember.Text = "Delete Member";
            this.btn_deleteMember.UseVisualStyleBackColor = false;
            this.btn_deleteMember.Click += new System.EventHandler(this.btn_deleteMember_Click);
            // 
            // btn_newStaff
            // 
            this.btn_newStaff.BackColor = System.Drawing.Color.Black;
            this.btn_newStaff.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newStaff.ForeColor = System.Drawing.Color.White;
            this.btn_newStaff.Location = new System.Drawing.Point(3, 242);
            this.btn_newStaff.Name = "btn_newStaff";
            this.btn_newStaff.Size = new System.Drawing.Size(289, 73);
            this.btn_newStaff.TabIndex = 2;
            this.btn_newStaff.Text = "Add New Staff";
            this.btn_newStaff.UseVisualStyleBackColor = false;
            this.btn_newStaff.Click += new System.EventHandler(this.btn_newStaff_Click);
            // 
            // btn_newMember
            // 
            this.btn_newMember.BackColor = System.Drawing.Color.Black;
            this.btn_newMember.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newMember.ForeColor = System.Drawing.Color.White;
            this.btn_newMember.Location = new System.Drawing.Point(3, 163);
            this.btn_newMember.Name = "btn_newMember";
            this.btn_newMember.Size = new System.Drawing.Size(289, 73);
            this.btn_newMember.TabIndex = 1;
            this.btn_newMember.Text = "Add New Member";
            this.btn_newMember.UseVisualStyleBackColor = false;
            this.btn_newMember.Click += new System.EventHandler(this.btn_newMember_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_logo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(89, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 103);
            this.panel2.TabIndex = 0;
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
            this.lbl_logo.Click += new System.EventHandler(this.lbl_logo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(47)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 552);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_min);
            this.Controls.Add(this.pic_cancel);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_cancel;
        private System.Windows.Forms.PictureBox pic_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newMember;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_searchMember;
        private System.Windows.Forms.Button btn_deleteMember;
        private System.Windows.Forms.Button btn_newStaff;
    }
}

