namespace ISAD_User_Story_1
{
    partial class aBITSForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.prospective_Member_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBITSDataSet = new ISAD_User_Story_1.ABITSDataSet();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.yearOfStudyLabel = new System.Windows.Forms.Label();
            this.yearOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.sponsorCheckBox = new System.Windows.Forms.CheckBox();
            this.prospective_Member_InfoTableAdapter = new ISAD_User_Story_1.ABITSDataSetTableAdapters.Prospective_Member_InfoTableAdapter();
            this.tableAdapterManager = new ISAD_User_Story_1.ABITSDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospective_Member_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBITSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ISAD_User_Story_1.Properties.Resources.USB_Card_Front;
            this.pictureBox1.Location = new System.Drawing.Point(153, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(254, 253);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(130, 25);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "First Name:";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(251, 318);
            this.lNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(133, 25);
            this.lNameLabel.TabIndex = 2;
            this.lNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(307, 383);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(77, 25);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(140, 445);
            this.majorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(244, 25);
            this.majorLabel.TabIndex = 4;
            this.majorLabel.Text = "Major (If Applicable):";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prospective_Member_InfoBindingSource, "fName", true));
            this.fNameTextBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTextBox.Location = new System.Drawing.Point(403, 248);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(327, 34);
            this.fNameTextBox.TabIndex = 5;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.fNameTextBox_TextChanged);
            // 
            // prospective_Member_InfoBindingSource
            // 
            this.prospective_Member_InfoBindingSource.DataMember = "Prospective_Member_Info";
            this.prospective_Member_InfoBindingSource.DataSource = this.aBITSDataSet;
            // 
            // aBITSDataSet
            // 
            this.aBITSDataSet.DataSetName = "ABITSDataSet";
            this.aBITSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prospective_Member_InfoBindingSource, "lName", true));
            this.lNameTextBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTextBox.Location = new System.Drawing.Point(403, 313);
            this.lNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(327, 34);
            this.lNameTextBox.TabIndex = 6;
            this.lNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prospective_Member_InfoBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(403, 378);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(327, 34);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // yearOfStudyLabel
            // 
            this.yearOfStudyLabel.AutoSize = true;
            this.yearOfStudyLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfStudyLabel.Location = new System.Drawing.Point(153, 508);
            this.yearOfStudyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearOfStudyLabel.Name = "yearOfStudyLabel";
            this.yearOfStudyLabel.Size = new System.Drawing.Size(231, 25);
            this.yearOfStudyLabel.TabIndex = 9;
            this.yearOfStudyLabel.Text = "Year (If Applicable):";
            // 
            // yearOfStudyComboBox
            // 
            this.yearOfStudyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prospective_Member_InfoBindingSource, "studentStatus", true));
            this.yearOfStudyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearOfStudyComboBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfStudyComboBox.FormattingEnabled = true;
            this.yearOfStudyComboBox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.yearOfStudyComboBox.Location = new System.Drawing.Point(403, 504);
            this.yearOfStudyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearOfStudyComboBox.Name = "yearOfStudyComboBox";
            this.yearOfStudyComboBox.Size = new System.Drawing.Size(327, 32);
            this.yearOfStudyComboBox.TabIndex = 10;
            this.yearOfStudyComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(340, 631);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(191, 68);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // majorComboBox
            // 
            this.majorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prospective_Member_InfoBindingSource, "major", true));
            this.majorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorComboBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "Application Development",
            "Cyber Security",
            "Infrastructure",
            "Other"});
            this.majorComboBox.Location = new System.Drawing.Point(403, 441);
            this.majorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(327, 32);
            this.majorComboBox.TabIndex = 10;
            this.majorComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sponsorCheckBox
            // 
            this.sponsorCheckBox.AutoSize = true;
            this.sponsorCheckBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sponsorCheckBox.Location = new System.Drawing.Point(309, 577);
            this.sponsorCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sponsorCheckBox.Name = "sponsorCheckBox";
            this.sponsorCheckBox.Size = new System.Drawing.Size(390, 28);
            this.sponsorCheckBox.TabIndex = 13;
            this.sponsorCheckBox.Text = " I am interested in sponsoring A-BITS!";
            this.sponsorCheckBox.UseVisualStyleBackColor = true;
            // 
            // prospective_Member_InfoTableAdapter
            // 
            this.prospective_Member_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Prospective_Member_InfoTableAdapter = this.prospective_Member_InfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ISAD_User_Story_1.ABITSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aBITSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 749);
            this.Controls.Add(this.sponsorCheckBox);
            this.Controls.Add(this.majorComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.yearOfStudyComboBox);
            this.Controls.Add(this.yearOfStudyLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "aBITSForm";
            this.Text = "A-BITS Information Request";
            this.Load += new System.EventHandler(this.aBITSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospective_Member_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBITSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label yearOfStudyLabel;
        private System.Windows.Forms.ComboBox yearOfStudyComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.CheckBox sponsorCheckBox;
        private ABITSDataSet aBITSDataSet;
        private System.Windows.Forms.BindingSource prospective_Member_InfoBindingSource;
        private ABITSDataSetTableAdapters.Prospective_Member_InfoTableAdapter prospective_Member_InfoTableAdapter;
        private ABITSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

