
namespace COMP123Final
{
    partial class formPeople
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.rbApple = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblVisiblePeople = new System.Windows.Forms.Label();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.dgvDisplayResult = new System.Windows.Forms.DataGridView();
            this.rbShowAndroidUsers = new System.Windows.Forms.RadioButton();
            this.rbShowAppleUsers = new System.Windows.Forms.RadioButton();
            this.rbShowAllUsers = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.gbPerson.SuspendLayout();
            this.gbPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 90);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(9, 125);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(44, 15);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(89, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(89, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(336, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // numAge
            // 
            this.numAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAge.Location = new System.Drawing.Point(89, 88);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(336, 23);
            this.numAge.TabIndex = 3;
            // 
            // rbApple
            // 
            this.rbApple.AutoSize = true;
            this.rbApple.Location = new System.Drawing.Point(89, 121);
            this.rbApple.Name = "rbApple";
            this.rbApple.Size = new System.Drawing.Size(56, 19);
            this.rbApple.TabIndex = 4;
            this.rbApple.TabStop = true;
            this.rbApple.Text = "Apple";
            this.rbApple.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(255, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(343, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbPerson
            // 
            this.gbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPerson.Controls.Add(this.rbAndroid);
            this.gbPerson.Controls.Add(this.lblMobile);
            this.gbPerson.Controls.Add(this.btnClear);
            this.gbPerson.Controls.Add(this.btnAdd);
            this.gbPerson.Controls.Add(this.lblAge);
            this.gbPerson.Controls.Add(this.numAge);
            this.gbPerson.Controls.Add(this.rbApple);
            this.gbPerson.Controls.Add(this.lblLastName);
            this.gbPerson.Controls.Add(this.txtFirstName);
            this.gbPerson.Controls.Add(this.txtLastName);
            this.gbPerson.Controls.Add(this.lblFirstName);
            this.gbPerson.Location = new System.Drawing.Point(12, 12);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(446, 202);
            this.gbPerson.TabIndex = 11;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person";
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(160, 121);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(68, 19);
            this.rbAndroid.TabIndex = 5;
            this.rbAndroid.TabStop = true;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // gbPeople
            // 
            this.gbPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPeople.Controls.Add(this.btnDelete);
            this.gbPeople.Controls.Add(this.lblVisiblePeople);
            this.gbPeople.Controls.Add(this.lblTotalPeople);
            this.gbPeople.Controls.Add(this.dgvDisplayResult);
            this.gbPeople.Controls.Add(this.rbShowAndroidUsers);
            this.gbPeople.Controls.Add(this.rbShowAppleUsers);
            this.gbPeople.Controls.Add(this.rbShowAllUsers);
            this.gbPeople.Location = new System.Drawing.Point(12, 229);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(447, 332);
            this.gbPeople.TabIndex = 12;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "People";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(344, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblVisiblePeople
            // 
            this.lblVisiblePeople.AutoSize = true;
            this.lblVisiblePeople.Location = new System.Drawing.Point(116, 297);
            this.lblVisiblePeople.Name = "lblVisiblePeople";
            this.lblVisiblePeople.Size = new System.Drawing.Size(91, 15);
            this.lblVisiblePeople.TabIndex = 5;
            this.lblVisiblePeople.Text = "Visible People: ?";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.AutoSize = true;
            this.lblTotalPeople.Location = new System.Drawing.Point(9, 297);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(82, 15);
            this.lblTotalPeople.TabIndex = 4;
            this.lblTotalPeople.Text = "Total People: ?";
            // 
            // dgvDisplayResult
            // 
            this.dgvDisplayResult.AllowUserToAddRows = false;
            this.dgvDisplayResult.AllowUserToDeleteRows = false;
            this.dgvDisplayResult.AllowUserToResizeColumns = false;
            this.dgvDisplayResult.AllowUserToResizeRows = false;
            this.dgvDisplayResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayResult.Location = new System.Drawing.Point(9, 58);
            this.dgvDisplayResult.Name = "dgvDisplayResult";
            this.dgvDisplayResult.ReadOnly = true;
            this.dgvDisplayResult.RowHeadersVisible = false;
            this.dgvDisplayResult.RowTemplate.Height = 25;
            this.dgvDisplayResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplayResult.Size = new System.Drawing.Size(432, 225);
            this.dgvDisplayResult.TabIndex = 11;
            // 
            // rbShowAndroidUsers
            // 
            this.rbShowAndroidUsers.AutoSize = true;
            this.rbShowAndroidUsers.Location = new System.Drawing.Point(267, 23);
            this.rbShowAndroidUsers.Name = "rbShowAndroidUsers";
            this.rbShowAndroidUsers.Size = new System.Drawing.Size(157, 19);
            this.rbShowAndroidUsers.TabIndex = 10;
            this.rbShowAndroidUsers.TabStop = true;
            this.rbShowAndroidUsers.Text = "Only show Android users";
            this.rbShowAndroidUsers.UseVisualStyleBackColor = true;
            this.rbShowAndroidUsers.CheckedChanged += new System.EventHandler(this.rbShowAndroidUsers_CheckedChanged);
            // 
            // rbShowAppleUsers
            // 
            this.rbShowAppleUsers.AutoSize = true;
            this.rbShowAppleUsers.Location = new System.Drawing.Point(116, 23);
            this.rbShowAppleUsers.Name = "rbShowAppleUsers";
            this.rbShowAppleUsers.Size = new System.Drawing.Size(145, 19);
            this.rbShowAppleUsers.TabIndex = 9;
            this.rbShowAppleUsers.TabStop = true;
            this.rbShowAppleUsers.Text = "Only show Apple users";
            this.rbShowAppleUsers.UseVisualStyleBackColor = true;
            this.rbShowAppleUsers.CheckedChanged += new System.EventHandler(this.rbShowAppleUsers_CheckedChanged);
            // 
            // rbShowAllUsers
            // 
            this.rbShowAllUsers.AutoSize = true;
            this.rbShowAllUsers.Location = new System.Drawing.Point(9, 23);
            this.rbShowAllUsers.Name = "rbShowAllUsers";
            this.rbShowAllUsers.Size = new System.Drawing.Size(99, 19);
            this.rbShowAllUsers.TabIndex = 8;
            this.rbShowAllUsers.TabStop = true;
            this.rbShowAllUsers.Text = "Show all users";
            this.rbShowAllUsers.UseVisualStyleBackColor = true;
            this.rbShowAllUsers.CheckedChanged += new System.EventHandler(this.rbShowAllUsers_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(356, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 24);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(470, 613);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPeople);
            this.Controls.Add(this.gbPerson);
            this.Name = "formPeople";
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.gbPeople.ResumeLayout(false);
            this.gbPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.RadioButton rbApple;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.RadioButton rbShowAndroidUsers;
        private System.Windows.Forms.RadioButton rbShowAppleUsers;
        private System.Windows.Forms.RadioButton rbShowAllUsers;
        private System.Windows.Forms.DataGridView dgvDisplayResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblVisiblePeople;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbAndroid;
    }
}

