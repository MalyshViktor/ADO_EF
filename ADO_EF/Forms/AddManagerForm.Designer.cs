
namespace ADO_EF.Forms
{
    partial class AddManagerForm
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecname = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIDmain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIDsec = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIdchief = new System.Windows.Forms.ComboBox();
            this.labelMainDept = new System.Windows.Forms.Label();
            this.labelIdSecDept = new System.Windows.Forms.Label();
            this.labelChief = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(144, 20);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(138, 23);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSecname
            // 
            this.textBoxSecname.Location = new System.Drawing.Point(144, 78);
            this.textBoxSecname.Name = "textBoxSecname";
            this.textBoxSecname.Size = new System.Drawing.Size(138, 23);
            this.textBoxSecname.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(46, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(232, 266);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID менеджера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id_manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID main_dep";
            // 
            // comboBoxIDmain
            // 
            this.comboBoxIDmain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDmain.FormattingEnabled = true;
            this.comboBoxIDmain.Location = new System.Drawing.Point(144, 157);
            this.comboBoxIDmain.Name = "comboBoxIDmain";
            this.comboBoxIDmain.Size = new System.Drawing.Size(178, 23);
            this.comboBoxIDmain.TabIndex = 11;
            this.comboBoxIDmain.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDmain_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID sec_dep";
            // 
            // comboBoxIDsec
            // 
            this.comboBoxIDsec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDsec.FormattingEnabled = true;
            this.comboBoxIDsec.Location = new System.Drawing.Point(144, 192);
            this.comboBoxIDsec.Name = "comboBoxIDsec";
            this.comboBoxIDsec.Size = new System.Drawing.Size(178, 23);
            this.comboBoxIDsec.TabIndex = 13;
            this.comboBoxIDsec.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDsec_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID chief";
            // 
            // comboBoxIdchief
            // 
            this.comboBoxIdchief.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdchief.FormattingEnabled = true;
            this.comboBoxIdchief.Location = new System.Drawing.Point(144, 227);
            this.comboBoxIdchief.Name = "comboBoxIdchief";
            this.comboBoxIdchief.Size = new System.Drawing.Size(178, 23);
            this.comboBoxIdchief.TabIndex = 15;
            this.comboBoxIdchief.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdchief_SelectedIndexChanged);
            // 
            // labelMainDept
            // 
            this.labelMainDept.AutoSize = true;
            this.labelMainDept.Location = new System.Drawing.Point(364, 160);
            this.labelMainDept.Name = "labelMainDept";
            this.labelMainDept.Size = new System.Drawing.Size(99, 15);
            this.labelMainDept.TabIndex = 16;
            this.labelMainDept.Text = "Main department";
            // 
            // labelIdSecDept
            // 
            this.labelIdSecDept.AutoSize = true;
            this.labelIdSecDept.Location = new System.Drawing.Point(364, 195);
            this.labelIdSecDept.Name = "labelIdSecDept";
            this.labelIdSecDept.Size = new System.Drawing.Size(127, 15);
            this.labelIdSecDept.TabIndex = 17;
            this.labelIdSecDept.Text = "Secondary department";
            // 
            // labelChief
            // 
            this.labelChief.AutoSize = true;
            this.labelChief.Location = new System.Drawing.Point(364, 230);
            this.labelChief.Name = "labelChief";
            this.labelChief.Size = new System.Drawing.Size(35, 15);
            this.labelChief.TabIndex = 18;
            this.labelChief.Text = "Chief";
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 328);
            this.Controls.Add(this.labelChief);
            this.Controls.Add(this.labelIdSecDept);
            this.Controls.Add(this.labelMainDept);
            this.Controls.Add(this.comboBoxIdchief);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxIDsec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxIDmain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSecname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddManagerForm";
            this.Text = "AddManagerForm";
            this.Load += new System.EventHandler(this.AddManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecname;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxIDmain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIDsec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIdchief;
        private System.Windows.Forms.Label labelMainDept;
        private System.Windows.Forms.Label labelIdSecDept;
        private System.Windows.Forms.Label labelChief;
    }
}