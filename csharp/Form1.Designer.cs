namespace csharp
{
    partial class Form1
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
            panel1 = new Panel();
            btn_next = new Button();
            btn_refresh = new Button();
            btn_cancel = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            btn_add = new Button();
            txtb_search = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            mainContainer = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            cmb_sex = new ComboBox();
            lbl_favorite = new Label();
            txtb_favorite = new TextBox();
            lbl_sex = new Label();
            lbl_mobile = new Label();
            txtb_mobile = new TextBox();
            lbl_fname = new Label();
            txtb_name = new TextBox();
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btn_next);
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(txtb_search);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(672, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 429);
            panel1.TabIndex = 0;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(5, 387);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(124, 30);
            btn_next.TabIndex = 9;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(6, 337);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(124, 30);
            btn_refresh.TabIndex = 8;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(6, 283);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(124, 30);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(6, 241);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(124, 30);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(5, 207);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(124, 30);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(5, 171);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(124, 30);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(5, 131);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(124, 30);
            btn_save.TabIndex = 3;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(6, 97);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(124, 30);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txtb_search
            // 
            txtb_search.Location = new Point(4, 40);
            txtb_search.Name = "txtb_search";
            txtb_search.Size = new Size(126, 23);
            txtb_search.TabIndex = 1;
            txtb_search.TextChanged += txtb_search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Search for name";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 33);
            panel2.TabIndex = 1;
            // 
            // mainContainer
            // 
            mainContainer.Controls.Add(tabControl1);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 33);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(672, 396);
            mainContainer.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 396);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(664, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "table";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(659, 362);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmb_sex);
            tabPage2.Controls.Add(lbl_favorite);
            tabPage2.Controls.Add(txtb_favorite);
            tabPage2.Controls.Add(lbl_sex);
            tabPage2.Controls.Add(lbl_mobile);
            tabPage2.Controls.Add(txtb_mobile);
            tabPage2.Controls.Add(lbl_fname);
            tabPage2.Controls.Add(txtb_name);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(664, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Data Entry";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_sex
            // 
            cmb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sex.FormattingEnabled = true;
            cmb_sex.Items.AddRange(new object[] { "Male", "Female" });
            cmb_sex.Location = new Point(151, 167);
            cmb_sex.Name = "cmb_sex";
            cmb_sex.Size = new Size(286, 23);
            cmb_sex.TabIndex = 8;
            // 
            // lbl_favorite
            // 
            lbl_favorite.AutoSize = true;
            lbl_favorite.Location = new Point(148, 192);
            lbl_favorite.Name = "lbl_favorite";
            lbl_favorite.Size = new Size(49, 15);
            lbl_favorite.TabIndex = 7;
            lbl_favorite.Text = "Favorite";
            // 
            // txtb_favorite
            // 
            txtb_favorite.Location = new Point(152, 212);
            txtb_favorite.Name = "txtb_favorite";
            txtb_favorite.Size = new Size(286, 23);
            txtb_favorite.TabIndex = 6;
            // 
            // lbl_sex
            // 
            lbl_sex.AutoSize = true;
            lbl_sex.Location = new Point(151, 143);
            lbl_sex.Name = "lbl_sex";
            lbl_sex.Size = new Size(25, 15);
            lbl_sex.TabIndex = 5;
            lbl_sex.Text = "Sex";
            // 
            // lbl_mobile
            // 
            lbl_mobile.AutoSize = true;
            lbl_mobile.Location = new Point(154, 93);
            lbl_mobile.Name = "lbl_mobile";
            lbl_mobile.Size = new Size(63, 15);
            lbl_mobile.TabIndex = 3;
            lbl_mobile.Text = "Mobile No";
            // 
            // txtb_mobile
            // 
            txtb_mobile.Location = new Point(151, 113);
            txtb_mobile.Name = "txtb_mobile";
            txtb_mobile.Size = new Size(286, 23);
            txtb_mobile.TabIndex = 2;
            // 
            // lbl_fname
            // 
            lbl_fname.AutoSize = true;
            lbl_fname.Location = new Point(154, 43);
            lbl_fname.Name = "lbl_fname";
            lbl_fname.Size = new Size(58, 15);
            lbl_fname.TabIndex = 1;
            lbl_fname.Text = "FullName";
            // 
            // txtb_name
            // 
            txtb_name.Location = new Point(151, 63);
            txtb_name.Name = "txtb_name";
            txtb_name.Size = new Size(286, 23);
            txtb_name.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 429);
            Controls.Add(mainContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainContainer;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TextBox txtb_name;
        private Label lbl_fname;
        private Label lbl_mobile;
        private TextBox txtb_mobile;
        private Label lbl_sex;
        private Label lbl_favorite;
        private TextBox txtb_favorite;
        private ComboBox cmb_sex;
        private Button btn_update;
        private Button btn_edit;
        private Button btn_save;
        private Button btn_add;
        private TextBox txtb_search;
        private Label label1;
        private Button btn_cancel;
        private Button btn_delete;
        private Button btn_refresh;
        private Button btn_next;
    }
}
