namespace GUI.Forms
{
    partial class FormThucung
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
            dtg_thucung = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_name = new TextBox();
            tbx_breed = new TextBox();
            tbx_color = new TextBox();
            tbx_age = new TextBox();
            tbx_search = new TextBox();
            label5 = new Label();
            btn_show = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            cbb_color = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_thucung).BeginInit();
            SuspendLayout();
            // 
            // dtg_thucung
            // 
            dtg_thucung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_thucung.Location = new Point(-2, 333);
            dtg_thucung.Name = "dtg_thucung";
            dtg_thucung.RowHeadersWidth = 51;
            dtg_thucung.Size = new Size(1149, 188);
            dtg_thucung.TabIndex = 0;
            dtg_thucung.CellClick += dtg_thucung_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 124);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "Loài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 48);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Màu lông";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 124);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 4;
            label4.Text = "Tuổi";
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(131, 48);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(335, 27);
            tbx_name.TabIndex = 5;
            // 
            // tbx_breed
            // 
            tbx_breed.Location = new Point(131, 124);
            tbx_breed.Name = "tbx_breed";
            tbx_breed.Size = new Size(335, 27);
            tbx_breed.TabIndex = 6;
            // 
            // tbx_color
            // 
            tbx_color.Location = new Point(724, 48);
            tbx_color.Name = "tbx_color";
            tbx_color.Size = new Size(335, 27);
            tbx_color.TabIndex = 7;
            // 
            // tbx_age
            // 
            tbx_age.Location = new Point(724, 124);
            tbx_age.Name = "tbx_age";
            tbx_age.Size = new Size(335, 27);
            tbx_age.TabIndex = 8;
            // 
            // tbx_search
            // 
            tbx_search.Location = new Point(793, 282);
            tbx_search.Name = "tbx_search";
            tbx_search.Size = new Size(335, 27);
            tbx_search.TabIndex = 9;
            tbx_search.TextChanged += tbx_search_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 285);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Search";
            // 
            // btn_show
            // 
            btn_show.Location = new Point(25, 283);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(94, 29);
            btn_show.TabIndex = 11;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(164, 283);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(304, 283);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 13;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(460, 283);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cbb_color
            // 
            cbb_color.FormattingEnabled = true;
            cbb_color.ImeMode = ImeMode.Off;
            cbb_color.IntegralHeight = false;
            cbb_color.Location = new Point(941, 210);
            cbb_color.Name = "cbb_color";
            cbb_color.Size = new Size(151, 28);
            cbb_color.TabIndex = 15;
            cbb_color.SelectedIndexChanged += cbb_color_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(811, 213);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 16;
            label6.Text = "Filter màu lông";
            // 
            // FormThucung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 523);
            Controls.Add(label6);
            Controls.Add(cbb_color);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(btn_show);
            Controls.Add(label5);
            Controls.Add(tbx_search);
            Controls.Add(tbx_age);
            Controls.Add(tbx_color);
            Controls.Add(tbx_breed);
            Controls.Add(tbx_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_thucung);
            Name = "FormThucung";
            Text = "FormThucung";
            ((System.ComponentModel.ISupportInitialize)dtg_thucung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_thucung;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_name;
        private TextBox tbx_breed;
        private TextBox tbx_color;
        private TextBox tbx_age;
        private TextBox tbx_search;
        private Label label5;
        private Button btn_show;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private ComboBox cbb_color;
        private Label label6;
    }
}