﻿
namespace YearOneProjectOne
{
    partial class Startup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.BTNLogIn = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.WMPScreensaver = new AxWMPLib.AxWindowsMediaPlayer();
            this.BTNGuestLogin = new System.Windows.Forms.Button();
            this.LBLloggedInUser = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DSDB = new YearOneProjectOne.DSDB();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new YearOneProjectOne.DSDBTableAdapters.userTableTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.teacherDataTableAdapter();
            this.LBLDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNLogIn
            // 
            this.BTNLogIn.BackColor = System.Drawing.Color.LawnGreen;
            this.BTNLogIn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogIn.Location = new System.Drawing.Point(532, 518);
            this.BTNLogIn.Name = "BTNLogIn";
            this.BTNLogIn.Size = new System.Drawing.Size(206, 37);
            this.BTNLogIn.TabIndex = 2;
            this.BTNLogIn.Text = "Log In";
            this.BTNLogIn.UseVisualStyleBackColor = false;
            this.BTNLogIn.Click += new System.EventHandler(this.BTNLogIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.AcceptsReturn = true;
            this.TBPassword.AcceptsTab = true;
            this.TBPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.TBPassword.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(532, 475);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(206, 37);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Text = "Password";
            this.TBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.Click += new System.EventHandler(this.TBPassword_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.AcceptsReturn = true;
            this.TBUsername.AcceptsTab = true;
            this.TBUsername.BackColor = System.Drawing.Color.PowderBlue;
            this.TBUsername.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.Location = new System.Drawing.Point(532, 432);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(206, 37);
            this.TBUsername.TabIndex = 4;
            this.TBUsername.Text = "Username";
            this.TBUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsername.Click += new System.EventHandler(this.TBUsername_Click);
            // 
            // WMPScreensaver
            // 
            this.WMPScreensaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPScreensaver.Enabled = true;
            this.WMPScreensaver.Location = new System.Drawing.Point(0, 0);
            this.WMPScreensaver.Name = "WMPScreensaver";
            this.WMPScreensaver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPScreensaver.OcxState")));
            this.WMPScreensaver.Size = new System.Drawing.Size(1264, 681);
            this.WMPScreensaver.TabIndex = 7;
            // 
            // BTNGuestLogin
            // 
            this.BTNGuestLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.BTNGuestLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuestLogin.Location = new System.Drawing.Point(515, 561);
            this.BTNGuestLogin.Name = "BTNGuestLogin";
            this.BTNGuestLogin.Size = new System.Drawing.Size(235, 52);
            this.BTNGuestLogin.TabIndex = 10;
            this.BTNGuestLogin.Text = "Login As Guest";
            this.BTNGuestLogin.UseVisualStyleBackColor = false;
            this.BTNGuestLogin.Click += new System.EventHandler(this.BTNGuestLogin_Click);
            // 
            // LBLloggedInUser
            // 
            this.LBLloggedInUser.AutoSize = true;
            this.LBLloggedInUser.Location = new System.Drawing.Point(13, 169);
            this.LBLloggedInUser.Name = "LBLloggedInUser";
            this.LBLloggedInUser.Size = new System.Drawing.Size(0, 13);
            this.LBLloggedInUser.TabIndex = 13;
            this.LBLloggedInUser.Visible = false;
            // 
            // DSDB
            // 
            this.DSDB.DataSetName = "DSDB";
            this.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "userTable";
            this.bindingSource1.DataSource = this.DSDB;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "teacherData";
            this.bindingSource2.DataSource = this.DSDB;
            // 
            // teacherDataTableAdapter
            // 
            this.teacherDataTableAdapter.ClearBeforeFill = true;
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(148, 73);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(35, 13);
            this.LBLDebug.TabIndex = 14;
            this.LBLDebug.Text = "label1";
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LBLDebug);
            this.Controls.Add(this.LBLloggedInUser);
            this.Controls.Add(this.BTNGuestLogin);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTNLogIn);
            this.Controls.Add(this.WMPScreensaver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Startup";
            this.Text = "Login To Continue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Startup_FormClosing);
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNLogIn;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private AxWMPLib.AxWindowsMediaPlayer WMPScreensaver;
        private System.Windows.Forms.Button BTNGuestLogin;
        private System.Windows.Forms.Label LBLloggedInUser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.BindingSource bindingSource1;
        internal DSDBTableAdapters.userTableTableAdapter userTableTableAdapter;
        internal System.Windows.Forms.BindingSource bindingSource2;
        internal DSDBTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        internal DSDB DSDB;
        private System.Windows.Forms.Label LBLDebug;
    }
}

