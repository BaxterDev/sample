namespace csharp
{
    partial class Form2
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btn_cancel = new Button();
            btn_stud_delete = new Button();
            btn_stud_update = new Button();
            btn_stud_add = new Button();
            cmb_scourse = new ComboBox();
            lbl_scourse = new Label();
            txtb_sname = new TextBox();
            lbl_sname = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 174);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(735, 174);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(btn_cancel);
            panel2.Controls.Add(btn_stud_delete);
            panel2.Controls.Add(btn_stud_update);
            panel2.Controls.Add(btn_stud_add);
            panel2.Controls.Add(cmb_scourse);
            panel2.Controls.Add(lbl_scourse);
            panel2.Controls.Add(txtb_sname);
            panel2.Controls.Add(lbl_sname);
            panel2.Location = new Point(25, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 181);
            panel2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(482, 113);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_stud_delete
            // 
            btn_stud_delete.Location = new Point(384, 113);
            btn_stud_delete.Name = "btn_stud_delete";
            btn_stud_delete.Size = new Size(75, 23);
            btn_stud_delete.TabIndex = 6;
            btn_stud_delete.Text = "DELETE";
            btn_stud_delete.UseVisualStyleBackColor = true;
            // 
            // btn_stud_update
            // 
            btn_stud_update.Location = new Point(287, 113);
            btn_stud_update.Name = "btn_stud_update";
            btn_stud_update.Size = new Size(75, 23);
            btn_stud_update.TabIndex = 5;
            btn_stud_update.Text = "UPDATE";
            btn_stud_update.UseVisualStyleBackColor = true;
            // 
            // btn_stud_add
            // 
            btn_stud_add.Location = new Point(195, 113);
            btn_stud_add.Name = "btn_stud_add";
            btn_stud_add.Size = new Size(75, 23);
            btn_stud_add.TabIndex = 4;
            btn_stud_add.Text = "ADD";
            btn_stud_add.UseVisualStyleBackColor = true;
            btn_stud_add.Click += btn_stud_add_Click;
            // 
            // cmb_scourse
            // 
            cmb_scourse.FormattingEnabled = true;
            cmb_scourse.Items.AddRange(new object[] { "1", "2", "3" });
            cmb_scourse.Location = new Point(425, 41);
            cmb_scourse.Name = "cmb_scourse";
            cmb_scourse.Size = new Size(213, 23);
            cmb_scourse.TabIndex = 3;
            // 
            // lbl_scourse
            // 
            lbl_scourse.AutoSize = true;
            lbl_scourse.Location = new Point(425, 23);
            lbl_scourse.Name = "lbl_scourse";
            lbl_scourse.Size = new Size(44, 15);
            lbl_scourse.TabIndex = 2;
            lbl_scourse.Text = "Course";
            // 
            // txtb_sname
            // 
            txtb_sname.Location = new Point(130, 41);
            txtb_sname.Name = "txtb_sname";
            txtb_sname.Size = new Size(224, 23);
            txtb_sname.TabIndex = 1;
            // 
            // lbl_sname
            // 
            lbl_sname.AutoSize = true;
            lbl_sname.Location = new Point(130, 23);
            lbl_sname.Name = "lbl_sname";
            lbl_sname.Size = new Size(58, 15);
            lbl_sname.TabIndex = 0;
            lbl_sname.Text = "FullName";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label lbl_scourse;
        private TextBox txtb_sname;
        private Label lbl_sname;
        private Button btn_cancel;
        private Button btn_stud_delete;
        private Button btn_stud_update;
        private Button btn_stud_add;
        private ComboBox cmb_scourse;
    }
}