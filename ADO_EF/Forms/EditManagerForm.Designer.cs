
namespace ADO_EF.Forms
{
    partial class EditManagerForm
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
            this.labelIdManager = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxManagerSurname = new System.Windows.Forms.TextBox();
            this.textBoxManagerName = new System.Windows.Forms.TextBox();
            this.textBoxManagerSecname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIdMainDept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIdSecDept = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxIdChief = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка менеджера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID менеджера";
            // 
            // labelIdManager
            // 
            this.labelIdManager.AutoSize = true;
            this.labelIdManager.Location = new System.Drawing.Point(216, 107);
            this.labelIdManager.Name = "labelIdManager";
            this.labelIdManager.Size = new System.Drawing.Size(38, 15);
            this.labelIdManager.TabIndex = 2;
            this.labelIdManager.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отчество:";
            // 
            // textBoxManagerSurname
            // 
            this.textBoxManagerSurname.Location = new System.Drawing.Point(216, 147);
            this.textBoxManagerSurname.Name = "textBoxManagerSurname";
            this.textBoxManagerSurname.Size = new System.Drawing.Size(165, 23);
            this.textBoxManagerSurname.TabIndex = 6;
            // 
            // textBoxManagerName
            // 
            this.textBoxManagerName.Location = new System.Drawing.Point(216, 185);
            this.textBoxManagerName.Name = "textBoxManagerName";
            this.textBoxManagerName.Size = new System.Drawing.Size(165, 23);
            this.textBoxManagerName.TabIndex = 7;
            // 
            // textBoxManagerSecname
            // 
            this.textBoxManagerSecname.Location = new System.Drawing.Point(216, 223);
            this.textBoxManagerSecname.Name = "textBoxManagerSecname";
            this.textBoxManagerSecname.Size = new System.Drawing.Size(165, 23);
            this.textBoxManagerSecname.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Основной отдел (ID)";
            // 
            // comboBoxIdMainDept
            // 
            this.comboBoxIdMainDept.FormattingEnabled = true;
            this.comboBoxIdMainDept.Location = new System.Drawing.Point(216, 269);
            this.comboBoxIdMainDept.Name = "comboBoxIdMainDept";
            this.comboBoxIdMainDept.Size = new System.Drawing.Size(165, 23);
            this.comboBoxIdMainDept.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "По совместительству (ID)";
            // 
            // comboBoxIdSecDept
            // 
            this.comboBoxIdSecDept.FormattingEnabled = true;
            this.comboBoxIdSecDept.Location = new System.Drawing.Point(216, 307);
            this.comboBoxIdSecDept.Name = "comboBoxIdSecDept";
            this.comboBoxIdSecDept.Size = new System.Drawing.Size(165, 23);
            this.comboBoxIdSecDept.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Начальник (ID)";
            // 
            // comboBoxIdChief
            // 
            this.comboBoxIdChief.FormattingEnabled = true;
            this.comboBoxIdChief.Location = new System.Drawing.Point(216, 348);
            this.comboBoxIdChief.Name = "comboBoxIdChief";
            this.comboBoxIdChief.Size = new System.Drawing.Size(165, 23);
            this.comboBoxIdChief.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(179, 400);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(353, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // EditManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxIdChief);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxIdSecDept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxIdMainDept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxManagerSecname);
            this.Controls.Add(this.textBoxManagerName);
            this.Controls.Add(this.textBoxManagerSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIdManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditManagerForm";
            this.Text = "EditManagerForm";
            this.Load += new System.EventHandler(this.EditManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxManagerSurname;
        private System.Windows.Forms.TextBox textBoxManagerName;
        private System.Windows.Forms.TextBox textBoxManagerSecname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIdMainDept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIdSecDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxIdChief;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
    }
}