namespace TestTaskProject
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
            tabControl1 = new TabControl();
            ReadTC = new TabPage();
            ReadDataView = new DataGridView();
            TeacherTC = new TabPage();
            tabControl2 = new TabControl();
            CreateTeacher = new TabPage();
            CreateTeacherButton = new Button();
            TeacherSalaryTB = new TextBox();
            TeacherAgeTB = new TextBox();
            TeacherNameTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            UpdateTeacher = new TabPage();
            button1 = new Button();
            label7 = new Label();
            UpdateIDTeacherTB = new TextBox();
            UpdateSalaryTeacherTB = new TextBox();
            UpdateAgeTeacherTB = new TextBox();
            UpdateNameTeacherTB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            UpdateDGVT = new DataGridView();
            DeleteTeacher = new TabPage();
            DeleteTeacherButton = new Button();
            dataGridView2 = new DataGridView();
            SubjectTC = new TabPage();
            tabControl3 = new TabControl();
            CreateSubject = new TabPage();
            textBox1 = new TextBox();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            dataGridView3 = new DataGridView();
            DeleteSubject = new TabPage();
            DeleteSubjectButton = new Button();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            ReadTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReadDataView).BeginInit();
            TeacherTC.SuspendLayout();
            tabControl2.SuspendLayout();
            CreateTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            UpdateTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateDGVT).BeginInit();
            DeleteTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SubjectTC.SuspendLayout();
            tabControl3.SuspendLayout();
            CreateSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            DeleteSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ReadTC);
            tabControl1.Controls.Add(TeacherTC);
            tabControl1.Controls.Add(SubjectTC);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1193, 698);
            tabControl1.TabIndex = 0;
            // 
            // ReadTC
            // 
            ReadTC.Controls.Add(ReadDataView);
            ReadTC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ReadTC.ForeColor = SystemColors.ActiveCaptionText;
            ReadTC.Location = new Point(4, 29);
            ReadTC.Name = "ReadTC";
            ReadTC.Padding = new Padding(3);
            ReadTC.Size = new Size(1185, 665);
            ReadTC.TabIndex = 0;
            ReadTC.Text = "Read";
            ReadTC.UseVisualStyleBackColor = true;
            // 
            // ReadDataView
            // 
            ReadDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReadDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ReadDataView.BackgroundColor = SystemColors.ControlLight;
            ReadDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadDataView.Cursor = Cursors.Hand;
            ReadDataView.Location = new Point(8, 8);
            ReadDataView.Name = "ReadDataView";
            ReadDataView.ReadOnly = true;
            ReadDataView.RowHeadersWidth = 51;
            ReadDataView.Size = new Size(1169, 641);
            ReadDataView.TabIndex = 0;
            // 
            // TeacherTC
            // 
            TeacherTC.Controls.Add(tabControl2);
            TeacherTC.Location = new Point(4, 29);
            TeacherTC.Name = "TeacherTC";
            TeacherTC.Padding = new Padding(3);
            TeacherTC.Size = new Size(1185, 665);
            TeacherTC.TabIndex = 1;
            TeacherTC.Text = "Teacher";
            TeacherTC.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(CreateTeacher);
            tabControl2.Controls.Add(UpdateTeacher);
            tabControl2.Controls.Add(DeleteTeacher);
            tabControl2.Location = new Point(8, 8);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1169, 651);
            tabControl2.TabIndex = 0;
            // 
            // CreateTeacher
            // 
            CreateTeacher.Controls.Add(CreateTeacherButton);
            CreateTeacher.Controls.Add(TeacherSalaryTB);
            CreateTeacher.Controls.Add(TeacherAgeTB);
            CreateTeacher.Controls.Add(TeacherNameTB);
            CreateTeacher.Controls.Add(label3);
            CreateTeacher.Controls.Add(label2);
            CreateTeacher.Controls.Add(label1);
            CreateTeacher.Controls.Add(dataGridView1);
            CreateTeacher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateTeacher.Location = new Point(4, 29);
            CreateTeacher.Name = "CreateTeacher";
            CreateTeacher.Padding = new Padding(3);
            CreateTeacher.Size = new Size(1161, 618);
            CreateTeacher.TabIndex = 0;
            CreateTeacher.Text = "Create";
            CreateTeacher.UseVisualStyleBackColor = true;
            // 
            // CreateTeacherButton
            // 
            CreateTeacherButton.FlatStyle = FlatStyle.System;
            CreateTeacherButton.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateTeacherButton.Location = new Point(694, 493);
            CreateTeacherButton.Name = "CreateTeacherButton";
            CreateTeacherButton.Size = new Size(194, 41);
            CreateTeacherButton.TabIndex = 7;
            CreateTeacherButton.Text = "Create";
            CreateTeacherButton.UseVisualStyleBackColor = true;
            CreateTeacherButton.Click += CreateTeacherButton_Click;
            // 
            // TeacherSalaryTB
            // 
            TeacherSalaryTB.Location = new Point(677, 379);
            TeacherSalaryTB.Name = "TeacherSalaryTB";
            TeacherSalaryTB.Size = new Size(229, 34);
            TeacherSalaryTB.TabIndex = 6;
            TeacherSalaryTB.KeyPress += TeacherAgeTB_KeyPress;
            // 
            // TeacherAgeTB
            // 
            TeacherAgeTB.Location = new Point(677, 261);
            TeacherAgeTB.Name = "TeacherAgeTB";
            TeacherAgeTB.Size = new Size(229, 34);
            TeacherAgeTB.TabIndex = 5;
            TeacherAgeTB.WordWrap = false;
            TeacherAgeTB.KeyPress += TeacherAgeTB_KeyPress;
            // 
            // TeacherNameTB
            // 
            TeacherNameTB.Location = new Point(677, 144);
            TeacherNameTB.Name = "TeacherNameTB";
            TeacherNameTB.Size = new Size(229, 34);
            TeacherNameTB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(748, 333);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 3;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(757, 211);
            label2.Name = "label2";
            label2.Size = new Size(57, 31);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(750, 97);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(448, 576);
            dataGridView1.TabIndex = 0;
            // 
            // UpdateTeacher
            // 
            UpdateTeacher.Controls.Add(button1);
            UpdateTeacher.Controls.Add(label7);
            UpdateTeacher.Controls.Add(UpdateIDTeacherTB);
            UpdateTeacher.Controls.Add(UpdateSalaryTeacherTB);
            UpdateTeacher.Controls.Add(UpdateAgeTeacherTB);
            UpdateTeacher.Controls.Add(UpdateNameTeacherTB);
            UpdateTeacher.Controls.Add(label6);
            UpdateTeacher.Controls.Add(label5);
            UpdateTeacher.Controls.Add(label4);
            UpdateTeacher.Controls.Add(UpdateDGVT);
            UpdateTeacher.Location = new Point(4, 29);
            UpdateTeacher.Name = "UpdateTeacher";
            UpdateTeacher.Padding = new Padding(3);
            UpdateTeacher.Size = new Size(1161, 618);
            UpdateTeacher.TabIndex = 1;
            UpdateTeacher.Text = "Update";
            UpdateTeacher.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Candara", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(692, 506);
            button1.Name = "button1";
            button1.Size = new Size(141, 36);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(489, 265);
            label7.Name = "label7";
            label7.Size = new Size(37, 31);
            label7.TabIndex = 8;
            label7.Text = "ID";
            // 
            // UpdateIDTeacherTB
            // 
            UpdateIDTeacherTB.Location = new Point(532, 265);
            UpdateIDTeacherTB.Name = "UpdateIDTeacherTB";
            UpdateIDTeacherTB.Size = new Size(125, 27);
            UpdateIDTeacherTB.TabIndex = 7;
            UpdateIDTeacherTB.TextChanged += UpdateIDTeacherTB_TextChanged;
            // 
            // UpdateSalaryTeacherTB
            // 
            UpdateSalaryTeacherTB.Location = new Point(830, 384);
            UpdateSalaryTeacherTB.Name = "UpdateSalaryTeacherTB";
            UpdateSalaryTeacherTB.Size = new Size(214, 27);
            UpdateSalaryTeacherTB.TabIndex = 6;
            // 
            // UpdateAgeTeacherTB
            // 
            UpdateAgeTeacherTB.Location = new Point(830, 269);
            UpdateAgeTeacherTB.Name = "UpdateAgeTeacherTB";
            UpdateAgeTeacherTB.Size = new Size(214, 27);
            UpdateAgeTeacherTB.TabIndex = 5;
            // 
            // UpdateNameTeacherTB
            // 
            UpdateNameTeacherTB.Location = new Point(830, 165);
            UpdateNameTeacherTB.Name = "UpdateNameTeacherTB";
            UpdateNameTeacherTB.Size = new Size(214, 27);
            UpdateNameTeacherTB.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(899, 334);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 3;
            label6.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(907, 225);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 2;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(899, 116);
            label4.Name = "label4";
            label4.Size = new Size(77, 31);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // UpdateDGVT
            // 
            UpdateDGVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateDGVT.Location = new Point(18, 16);
            UpdateDGVT.Name = "UpdateDGVT";
            UpdateDGVT.RowHeadersWidth = 51;
            UpdateDGVT.Size = new Size(449, 583);
            UpdateDGVT.TabIndex = 0;
            // 
            // DeleteTeacher
            // 
            DeleteTeacher.Controls.Add(DeleteTeacherButton);
            DeleteTeacher.Controls.Add(dataGridView2);
            DeleteTeacher.Location = new Point(4, 29);
            DeleteTeacher.Name = "DeleteTeacher";
            DeleteTeacher.Size = new Size(1161, 618);
            DeleteTeacher.TabIndex = 2;
            DeleteTeacher.Text = "Delete";
            DeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // DeleteTeacherButton
            // 
            DeleteTeacherButton.Font = new Font("Candara", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteTeacherButton.Location = new Point(880, 246);
            DeleteTeacherButton.Name = "DeleteTeacherButton";
            DeleteTeacherButton.Size = new Size(209, 57);
            DeleteTeacherButton.TabIndex = 1;
            DeleteTeacherButton.Text = "Delete";
            DeleteTeacherButton.UseVisualStyleBackColor = true;
            DeleteTeacherButton.Click += DeleteTeacherButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(19, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(774, 581);
            dataGridView2.TabIndex = 0;
            // 
            // SubjectTC
            // 
            SubjectTC.Controls.Add(tabControl3);
            SubjectTC.Location = new Point(4, 29);
            SubjectTC.Name = "SubjectTC";
            SubjectTC.Size = new Size(1185, 665);
            SubjectTC.TabIndex = 2;
            SubjectTC.Text = "Subject";
            SubjectTC.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(CreateSubject);
            tabControl3.Controls.Add(DeleteSubject);
            tabControl3.Location = new Point(8, 9);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1169, 639);
            tabControl3.TabIndex = 0;
            // 
            // CreateSubject
            // 
            CreateSubject.Controls.Add(textBox1);
            CreateSubject.Controls.Add(button2);
            CreateSubject.Controls.Add(label9);
            CreateSubject.Controls.Add(label8);
            CreateSubject.Controls.Add(comboBox1);
            CreateSubject.Controls.Add(dataGridView3);
            CreateSubject.Location = new Point(4, 29);
            CreateSubject.Name = "CreateSubject";
            CreateSubject.Padding = new Padding(3);
            CreateSubject.Size = new Size(1161, 606);
            CreateSubject.TabIndex = 0;
            CreateSubject.Text = "Create";
            CreateSubject.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(792, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(823, 337);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(689, 252);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 2;
            label9.Text = "Subject";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(689, 155);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Teachers";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(795, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(25, 19);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(534, 567);
            dataGridView3.TabIndex = 0;
            // 
            // DeleteSubject
            // 
            DeleteSubject.Controls.Add(DeleteSubjectButton);
            DeleteSubject.Controls.Add(dataGridView4);
            DeleteSubject.Location = new Point(4, 29);
            DeleteSubject.Name = "DeleteSubject";
            DeleteSubject.Size = new Size(1161, 606);
            DeleteSubject.TabIndex = 2;
            DeleteSubject.Text = "Delete";
            DeleteSubject.UseVisualStyleBackColor = true;
            // 
            // DeleteSubjectButton
            // 
            DeleteSubjectButton.Location = new Point(787, 271);
            DeleteSubjectButton.Name = "DeleteSubjectButton";
            DeleteSubjectButton.Size = new Size(180, 52);
            DeleteSubjectButton.TabIndex = 1;
            DeleteSubjectButton.Text = "Delete";
            DeleteSubjectButton.UseVisualStyleBackColor = true;
            DeleteSubjectButton.Click += DeleteSubjectButton_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(16, 17);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(586, 570);
            dataGridView4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 710);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ReadTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReadDataView).EndInit();
            TeacherTC.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            CreateTeacher.ResumeLayout(false);
            CreateTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            UpdateTeacher.ResumeLayout(false);
            UpdateTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateDGVT).EndInit();
            DeleteTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            SubjectTC.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            CreateSubject.ResumeLayout(false);
            CreateSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            DeleteSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ReadTC;
        private DataGridView ReadDataView;
        private TabPage TeacherTC;
        private TabPage SubjectTC;
        private TabControl tabControl2;
        private TabPage CreateTeacher;
        private TabPage UpdateTeacher;
        private TabPage DeleteTeacher;
        private TabControl tabControl3;
        private TabPage CreateSubject;
        private TabPage DeleteSubject;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CreateTeacherButton;
        private TextBox TeacherSalaryTB;
        private TextBox TeacherAgeTB;
        private TextBox TeacherNameTB;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView UpdateDGVT;
        private TextBox UpdateSalaryTeacherTB;
        private TextBox UpdateAgeTeacherTB;
        private TextBox UpdateNameTeacherTB;
        private Button button1;
        private Label label7;
        private TextBox UpdateIDTeacherTB;
        private DataGridView dataGridView2;
        private Button DeleteTeacherButton;
        private Button button2;
        private Label label9;
        private Label label8;
        private ComboBox comboBox1;
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private DataGridView dataGridView4;
        private Button DeleteSubjectButton;
    }
}
