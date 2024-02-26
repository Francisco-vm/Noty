namespace Noty
{
    partial class Main
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
            Panel_Main = new Panel();
            Panel_Right = new Panel();
            Panel_Bottom = new Panel();
            btn_Delete = new Button();
            btn_Save = new Button();
            TextArea = new RichTextBox();
            tbx_Title = new TextBox();
            Panel_SeparatorRight = new Panel();
            Panel_SeparatorLeft = new Panel();
            Panel_NoteAndNotebooks = new Panel();
            ls_Notes = new ListBox();
            panel1 = new Panel();
            Panel_NotesTop = new Panel();
            pictureBox1 = new PictureBox();
            ls_NoteBooks = new ListBox();
            tbx_NameNotebook = new TextBox();
            Panel_Left = new Panel();
            Panel_Top = new Panel();
            btn_NoteBook = new Button();
            btn_New = new Button();
            btn_Note = new Button();
            Panel_Welcome = new Panel();
            lbl_By = new Label();
            lbl_SelectRoot = new Label();
            btn_OpenRoot = new Button();
            lbl_Noty = new Label();
            pic_Logo = new PictureBox();
            Panel_Main.SuspendLayout();
            Panel_Bottom.SuspendLayout();
            Panel_NoteAndNotebooks.SuspendLayout();
            Panel_NotesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_Top.SuspendLayout();
            Panel_Welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // Panel_Main
            // 
            Panel_Main.BackColor = SystemColors.ActiveBorder;
            Panel_Main.Controls.Add(TextArea);
            Panel_Main.Controls.Add(Panel_Bottom);
            Panel_Main.Controls.Add(tbx_Title);
            Panel_Main.Controls.Add(Panel_SeparatorRight);
            Panel_Main.Controls.Add(Panel_SeparatorLeft);
            Panel_Main.Controls.Add(Panel_NoteAndNotebooks);
            Panel_Main.Controls.Add(Panel_Left);
            Panel_Main.Controls.Add(Panel_Top);
            Panel_Main.Controls.Add(Panel_Right);
            Panel_Main.Dock = DockStyle.Fill;
            Panel_Main.Location = new Point(0, 0);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(978, 544);
            Panel_Main.TabIndex = 1;
            Panel_Main.Visible = false;
            // 
            // Panel_Right
            // 
            Panel_Right.BackColor = Color.Black;
            Panel_Right.Dock = DockStyle.Right;
            Panel_Right.Location = new Point(938, 0);
            Panel_Right.Name = "Panel_Right";
            Panel_Right.Size = new Size(40, 544);
            Panel_Right.TabIndex = 5;
            Panel_Right.Visible = false;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.BackColor = Color.Yellow;
            Panel_Bottom.Controls.Add(btn_Delete);
            Panel_Bottom.Controls.Add(btn_Save);
            Panel_Bottom.Dock = DockStyle.Bottom;
            Panel_Bottom.Location = new Point(407, 506);
            Panel_Bottom.Name = "Panel_Bottom";
            Panel_Bottom.Size = new Size(498, 38);
            Panel_Bottom.TabIndex = 3;
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Right;
            btn_Delete.Location = new Point(274, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 38);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Dock = DockStyle.Right;
            btn_Save.Location = new Point(386, 0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 38);
            btn_Save.TabIndex = 0;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // TextArea
            // 
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Dock = DockStyle.Fill;
            TextArea.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextArea.Location = new Point(407, 109);
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(498, 397);
            TextArea.TabIndex = 8;
            TextArea.Text = "";
            TextArea.MouseClick += TextArea_MouseClick;
            // 
            // tbx_Title
            // 
            tbx_Title.BorderStyle = BorderStyle.None;
            tbx_Title.Dock = DockStyle.Top;
            tbx_Title.Font = new Font("Tahoma", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Title.Location = new Point(407, 55);
            tbx_Title.Name = "tbx_Title";
            tbx_Title.Size = new Size(498, 54);
            tbx_Title.TabIndex = 7;
            tbx_Title.TextAlign = HorizontalAlignment.Center;
            // 
            // Panel_SeparatorRight
            // 
            Panel_SeparatorRight.BackColor = Color.White;
            Panel_SeparatorRight.Dock = DockStyle.Right;
            Panel_SeparatorRight.Location = new Point(905, 55);
            Panel_SeparatorRight.Name = "Panel_SeparatorRight";
            Panel_SeparatorRight.Size = new Size(33, 489);
            Panel_SeparatorRight.TabIndex = 6;
            Panel_SeparatorRight.Visible = false;
            // 
            // Panel_SeparatorLeft
            // 
            Panel_SeparatorLeft.BackColor = Color.Gainsboro;
            Panel_SeparatorLeft.Dock = DockStyle.Left;
            Panel_SeparatorLeft.Location = new Point(368, 55);
            Panel_SeparatorLeft.Name = "Panel_SeparatorLeft";
            Panel_SeparatorLeft.Size = new Size(39, 489);
            Panel_SeparatorLeft.TabIndex = 4;
            // 
            // Panel_NoteAndNotebooks
            // 
            Panel_NoteAndNotebooks.BackColor = Color.White;
            Panel_NoteAndNotebooks.Controls.Add(ls_Notes);
            Panel_NoteAndNotebooks.Controls.Add(panel1);
            Panel_NoteAndNotebooks.Controls.Add(Panel_NotesTop);
            Panel_NoteAndNotebooks.Dock = DockStyle.Left;
            Panel_NoteAndNotebooks.Location = new Point(50, 55);
            Panel_NoteAndNotebooks.Name = "Panel_NoteAndNotebooks";
            Panel_NoteAndNotebooks.Size = new Size(318, 489);
            Panel_NoteAndNotebooks.TabIndex = 2;
            // 
            // ls_Notes
            // 
            ls_Notes.BorderStyle = BorderStyle.None;
            ls_Notes.Dock = DockStyle.Top;
            ls_Notes.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ls_Notes.FormattingEnabled = true;
            ls_Notes.ItemHeight = 29;
            ls_Notes.Location = new Point(0, 229);
            ls_Notes.Name = "ls_Notes";
            ls_Notes.Size = new Size(318, 261);
            ls_Notes.TabIndex = 3;
            ls_Notes.SelectedIndexChanged += ls_Notes_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 42);
            panel1.TabIndex = 4;
            // 
            // Panel_NotesTop
            // 
            Panel_NotesTop.BackColor = Color.White;
            Panel_NotesTop.Controls.Add(pictureBox1);
            Panel_NotesTop.Controls.Add(ls_NoteBooks);
            Panel_NotesTop.Controls.Add(tbx_NameNotebook);
            Panel_NotesTop.Dock = DockStyle.Top;
            Panel_NotesTop.Location = new Point(0, 0);
            Panel_NotesTop.Name = "Panel_NotesTop";
            Panel_NotesTop.Size = new Size(318, 187);
            Panel_NotesTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Notebook_x48;
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ls_NoteBooks
            // 
            ls_NoteBooks.BackColor = Color.White;
            ls_NoteBooks.BorderStyle = BorderStyle.None;
            ls_NoteBooks.Dock = DockStyle.Bottom;
            ls_NoteBooks.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ls_NoteBooks.ForeColor = Color.Black;
            ls_NoteBooks.FormattingEnabled = true;
            ls_NoteBooks.ItemHeight = 29;
            ls_NoteBooks.Location = new Point(0, 71);
            ls_NoteBooks.Name = "ls_NoteBooks";
            ls_NoteBooks.Size = new Size(318, 116);
            ls_NoteBooks.TabIndex = 0;
            ls_NoteBooks.SelectedIndexChanged += ls_NoteBooks_SelectedIndexChanged;
            // 
            // tbx_NameNotebook
            // 
            tbx_NameNotebook.BorderStyle = BorderStyle.None;
            tbx_NameNotebook.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NameNotebook.Location = new Point(60, 6);
            tbx_NameNotebook.Name = "tbx_NameNotebook";
            tbx_NameNotebook.ReadOnly = true;
            tbx_NameNotebook.Size = new Size(252, 37);
            tbx_NameNotebook.TabIndex = 1;
            tbx_NameNotebook.TextAlign = HorizontalAlignment.Center;
            // 
            // Panel_Left
            // 
            Panel_Left.BackColor = Color.Black;
            Panel_Left.Dock = DockStyle.Left;
            Panel_Left.ForeColor = SystemColors.ControlLightLight;
            Panel_Left.Location = new Point(0, 55);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new Size(50, 489);
            Panel_Left.TabIndex = 1;
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.Gainsboro;
            Panel_Top.Controls.Add(btn_NoteBook);
            Panel_Top.Controls.Add(btn_New);
            Panel_Top.Controls.Add(btn_Note);
            Panel_Top.Dock = DockStyle.Top;
            Panel_Top.Location = new Point(0, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(938, 55);
            Panel_Top.TabIndex = 0;
            // 
            // btn_NoteBook
            // 
            btn_NoteBook.Location = new Point(104, 12);
            btn_NoteBook.Name = "btn_NoteBook";
            btn_NoteBook.Size = new Size(105, 34);
            btn_NoteBook.TabIndex = 2;
            btn_NoteBook.Text = "NoteBook";
            btn_NoteBook.UseVisualStyleBackColor = true;
            btn_NoteBook.Visible = false;
            btn_NoteBook.Click += btn_NoteBook_Click;
            // 
            // btn_New
            // 
            btn_New.Location = new Point(215, 12);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(40, 34);
            btn_New.TabIndex = 1;
            btn_New.Text = "+";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // btn_Note
            // 
            btn_Note.Location = new Point(12, 12);
            btn_Note.Name = "btn_Note";
            btn_Note.Size = new Size(86, 34);
            btn_Note.TabIndex = 0;
            btn_Note.Text = "Note";
            btn_Note.UseVisualStyleBackColor = true;
            btn_Note.Visible = false;
            btn_Note.Click += btn_Note_Click;
            // 
            // Panel_Welcome
            // 
            Panel_Welcome.BackColor = Color.White;
            Panel_Welcome.Controls.Add(Panel_Main);
            Panel_Welcome.Controls.Add(lbl_By);
            Panel_Welcome.Controls.Add(lbl_SelectRoot);
            Panel_Welcome.Controls.Add(btn_OpenRoot);
            Panel_Welcome.Controls.Add(lbl_Noty);
            Panel_Welcome.Controls.Add(pic_Logo);
            Panel_Welcome.Dock = DockStyle.Fill;
            Panel_Welcome.Location = new Point(0, 0);
            Panel_Welcome.Name = "Panel_Welcome";
            Panel_Welcome.Size = new Size(978, 544);
            Panel_Welcome.TabIndex = 2;
            // 
            // lbl_By
            // 
            lbl_By.AutoSize = true;
            lbl_By.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_By.Location = new Point(842, 516);
            lbl_By.Name = "lbl_By";
            lbl_By.Size = new Size(124, 19);
            lbl_By.TabIndex = 4;
            lbl_By.Text = "By Francisco-vm";
            // 
            // lbl_SelectRoot
            // 
            lbl_SelectRoot.AutoSize = true;
            lbl_SelectRoot.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SelectRoot.Location = new Point(686, 200);
            lbl_SelectRoot.Name = "lbl_SelectRoot";
            lbl_SelectRoot.Size = new Size(208, 24);
            lbl_SelectRoot.TabIndex = 3;
            lbl_SelectRoot.Text = "Select your root folder";
            // 
            // btn_OpenRoot
            // 
            btn_OpenRoot.BackColor = Color.White;
            btn_OpenRoot.FlatAppearance.BorderSize = 0;
            btn_OpenRoot.FlatStyle = FlatStyle.Flat;
            btn_OpenRoot.Image = Properties.Resources.icon_Folder_x48;
            btn_OpenRoot.Location = new Point(732, 227);
            btn_OpenRoot.Name = "btn_OpenRoot";
            btn_OpenRoot.Size = new Size(112, 99);
            btn_OpenRoot.TabIndex = 2;
            btn_OpenRoot.TextAlign = ContentAlignment.BottomCenter;
            btn_OpenRoot.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_OpenRoot.UseVisualStyleBackColor = false;
            btn_OpenRoot.Click += btn_OpenRoot_Click;
            // 
            // lbl_Noty
            // 
            lbl_Noty.AutoSize = true;
            lbl_Noty.Font = new Font("Tahoma", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Noty.Location = new Point(235, 359);
            lbl_Noty.Name = "lbl_Noty";
            lbl_Noty.Size = new Size(153, 72);
            lbl_Noty.TabIndex = 1;
            lbl_Noty.Text = "Noty";
            // 
            // pic_Logo
            // 
            pic_Logo.Image = Properties.Resources.Logo;
            pic_Logo.Location = new Point(157, 113);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(231, 230);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(Panel_Welcome);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noty";
            Panel_Main.ResumeLayout(false);
            Panel_Main.PerformLayout();
            Panel_Bottom.ResumeLayout(false);
            Panel_NoteAndNotebooks.ResumeLayout(false);
            Panel_NotesTop.ResumeLayout(false);
            Panel_NotesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_Top.ResumeLayout(false);
            Panel_Welcome.ResumeLayout(false);
            Panel_Welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Main;
        private Panel Panel_Welcome;
        private PictureBox pic_Logo;
        private Label lbl_Noty;
        private Button btn_OpenRoot;
        private Label lbl_SelectRoot;
        private Label lbl_By;
        private Panel Panel_Top;
        private Panel Panel_Bottom;
        private Panel Panel_NoteAndNotebooks;
        private Panel Panel_Left;
        private RichTextBox TextArea;
        private TextBox tbx_Title;
        private Panel Panel_SeparatorRight;
        private Panel Panel_Right;
        private Panel Panel_SeparatorLeft;
        private Button btn_Note;
        private ListBox ls_NoteBooks;
        private Button btn_NoteBook;
        private Button btn_New;
        private PictureBox pictureBox1;
        private TextBox tbx_NameNotebook;
        private ListBox ls_Notes;
        private Panel Panel_NotesTop;
        private Button btn_Delete;
        private Button btn_Save;
        private Panel panel1;
    }
}
