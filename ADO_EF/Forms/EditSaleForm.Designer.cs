
namespace ADO_EF.Forms
{
    partial class EditSaleForm
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
            this.comboBoxProduct1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxManager1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товарный чек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Товар:";
            // 
            // comboBoxProduct1
            // 
            this.comboBoxProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct1.FormattingEnabled = true;
            this.comboBoxProduct1.Location = new System.Drawing.Point(198, 116);
            this.comboBoxProduct1.Name = "comboBoxProduct1";
            this.comboBoxProduct1.Size = new System.Drawing.Size(298, 23);
            this.comboBoxProduct1.TabIndex = 2;
            this.comboBoxProduct1.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во:";
            // 
            // textBoxCountSale
            // 
            this.textBoxCountSale.Location = new System.Drawing.Point(198, 178);
            this.textBoxCountSale.Name = "textBoxCountSale";
            this.textBoxCountSale.Size = new System.Drawing.Size(139, 23);
            this.textBoxCountSale.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Менеджер";
            // 
            // comboBoxManager1
            // 
            this.comboBoxManager1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager1.FormattingEnabled = true;
            this.comboBoxManager1.Location = new System.Drawing.Point(198, 240);
            this.comboBoxManager1.Name = "comboBoxManager1";
            this.comboBoxManager1.Size = new System.Drawing.Size(298, 23);
            this.comboBoxManager1.TabIndex = 6;
            this.comboBoxManager1.SelectedIndexChanged += new System.EventHandler(this.comboBoxManager1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время продажи:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 377);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(354, 377);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // EditSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxManager1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCountSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProduct1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSaleForm";
            this.Text = "EditSaleForm";
            this.Load += new System.EventHandler(this.EditSaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProduct1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
    }
}