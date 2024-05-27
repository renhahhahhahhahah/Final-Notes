namespace Notes3
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
            TxtBxTitle = new TextBox();
            TxtBxNotes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousnotes = new DataGridView();
            LoadBtn = new Button();
            DeleteBtn = new Button();
            NewNotesBtn = new Button();
            SaveBtn = new Button();
            Exitbtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)previousnotes).BeginInit();
            SuspendLayout();
            // 
            // TxtBxTitle
            // 
            TxtBxTitle.BackColor = Color.DarkViolet;
            TxtBxTitle.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBxTitle.Location = new Point(460, 48);
            TxtBxTitle.Name = "TxtBxTitle";
            TxtBxTitle.Size = new Size(328, 25);
            TxtBxTitle.TabIndex = 0;
            // 
            // TxtBxNotes
            // 
            TxtBxNotes.BackColor = Color.DarkViolet;
            TxtBxNotes.Location = new Point(460, 100);
            TxtBxNotes.Multiline = true;
            TxtBxNotes.Name = "TxtBxNotes";
            TxtBxNotes.Size = new Size(328, 354);
            TxtBxNotes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 24);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 3;
            label2.Text = "Notes:";
            // 
            // previousnotes
            // 
            previousnotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousnotes.BackgroundColor = Color.DarkViolet;
            previousnotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousnotes.GridColor = Color.Orange;
            previousnotes.Location = new Point(12, 12);
            previousnotes.Name = "previousnotes";
            previousnotes.Size = new Size(431, 320);
            previousnotes.TabIndex = 4;
            previousnotes.CellContentDoubleClick += previousnotes_CellContentDoubleClick;
            previousnotes.CellDoubleClick += previousnotes_CellDoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.FromArgb(64, 0, 64);
            LoadBtn.FlatStyle = FlatStyle.Popup;
            LoadBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadBtn.ForeColor = Color.Khaki;
            LoadBtn.Location = new Point(12, 338);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(208, 55);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(64, 0, 64);
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Khaki;
            DeleteBtn.Location = new Point(235, 338);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(208, 55);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // NewNotesBtn
            // 
            NewNotesBtn.BackColor = Color.FromArgb(64, 0, 64);
            NewNotesBtn.FlatStyle = FlatStyle.Popup;
            NewNotesBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewNotesBtn.ForeColor = Color.Khaki;
            NewNotesBtn.Location = new Point(12, 399);
            NewNotesBtn.Name = "NewNotesBtn";
            NewNotesBtn.Size = new Size(208, 55);
            NewNotesBtn.TabIndex = 7;
            NewNotesBtn.Text = "New Notes";
            NewNotesBtn.UseVisualStyleBackColor = false;
            NewNotesBtn.Click += NewNotesBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(64, 0, 64);
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.Khaki;
            SaveBtn.Location = new Point(235, 399);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(208, 55);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Purple;
            Exitbtn.FlatStyle = FlatStyle.Popup;
            Exitbtn.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(758, 9);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(30, 23);
            Exitbtn.TabIndex = 9;
            Exitbtn.Text = "X";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(722, 9);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 10;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(800, 461);
            Controls.Add(button1);
            Controls.Add(Exitbtn);
            Controls.Add(SaveBtn);
            Controls.Add(NewNotesBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(LoadBtn);
            Controls.Add(previousnotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtBxNotes);
            Controls.Add(TxtBxTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "NoteTaker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousnotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBxTitle;
        private TextBox TxtBxNotes;
        private Label label1;
        private Label label2;
        private DataGridView previousnotes;
        private Button LoadBtn;
        private Button DeleteBtn;
        private Button NewNotesBtn;
        private Button SaveBtn;
        private Button Exitbtn;
        private Button button1;
    }
}
