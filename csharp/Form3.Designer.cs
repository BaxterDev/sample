namespace csharp
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            materialTabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(0, 0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(917, 416);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "home-outline.png";
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(909, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "settings-2-outline.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(903, 376);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Setting";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home-outline.png");
            imageList1.Images.SetKeyName(1, "settings-2-outline.png");
            imageList1.Images.SetKeyName(2, "heart-outline.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(materialTabControl1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(2, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 416);
            panel1.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(4F, 10F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 499);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "Form3";
            Padding = new Padding(2, 42, 2, 2);
            Text = "Material Skin Winform";
            Load += Form3_Load;
            materialTabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private Panel panel1;
    }
}