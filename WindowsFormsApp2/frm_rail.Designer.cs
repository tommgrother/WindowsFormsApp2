﻿namespace WindowsFormsApp2
{
    partial class frm_rail
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
            this.txt_numbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_string = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.c_view_repaint_listTableAdapter1 = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter();
            this.btn_add_txtbox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Flight Bar Numbers";
            // 
            // txt_numbers
            // 
            this.txt_numbers.Location = new System.Drawing.Point(286, 110);
            this.txt_numbers.Name = "txt_numbers";
            this.txt_numbers.Size = new System.Drawing.Size(161, 20);
            this.txt_numbers.TabIndex = 1;
            this.txt_numbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numbers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "OR";
            // 
            // txt_string
            // 
            this.txt_string.Location = new System.Drawing.Point(153, 269);
            this.txt_string.Name = "txt_string";
            this.txt_string.Size = new System.Drawing.Size(166, 20);
            this.txt_string.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected Flight Bars";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(36, 35);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(120, 154);
            this.listbox.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(58, 195);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add numbers";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // c_view_repaint_listTableAdapter1
            // 
            this.c_view_repaint_listTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_add_txtbox
            // 
            this.btn_add_txtbox.Location = new System.Drawing.Point(333, 136);
            this.btn_add_txtbox.Name = "btn_add_txtbox";
            this.btn_add_txtbox.Size = new System.Drawing.Size(75, 23);
            this.btn_add_txtbox.TabIndex = 8;
            this.btn_add_txtbox.Text = "Add numbers";
            this.btn_add_txtbox.UseVisualStyleBackColor = true;
            this.btn_add_txtbox.Click += new System.EventHandler(this.Btn_add_txtbox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seperate numbers with \' , \'";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(358, 266);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // frm_rail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 326);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_txtbox);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_string);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numbers);
            this.Controls.Add(this.label1);
            this.Name = "frm_rail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_rail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_string;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox listbox;
        private System.Windows.Forms.Button btn_add;
        private order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter c_view_repaint_listTableAdapter1;
        private System.Windows.Forms.Button btn_add_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
    }
}