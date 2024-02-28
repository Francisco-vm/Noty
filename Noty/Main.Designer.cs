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
            TextArea = new RichTextBox();
            Panel_Bottom = new Panel();
            btn_Delete = new Button();
            btn_Save = new Button();
            tbx_Title = new TextBox();
            Panel_SeparatorRight = new Panel();
            Panel_SeparatorLeft = new Panel();
            Panel_NoteAndNotebooks = new Panel();
            Panel_Notes = new Panel();
            ls_Notes = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            Panel_NoteBooks = new Panel();
            btn_RenameNoteBook = new Button();
            ls_NoteBooks = new ListBox();
            tbx_NameNotebook = new TextBox();
            panel2 = new Panel();
            btn_DeleteNotebook = new Button();
            btn_SortNoteBooks = new Button();
            label1 = new Label();
            Panel_Top = new Panel();
            textBox1 = new TextBox();
            Panel_Right = new Panel();
            Panel_Left = new Panel();
            btn_Home = new Button();
            btn_Note = new Button();
            btn_NoteBook = new Button();
            btn_New = new Button();
            Panel_Welcome = new Panel();
            lbl_By = new Label();
            lbl_SelectRoot = new Label();
            btn_OpenRoot = new Button();
            lbl_Noty = new Label();
            pic_Logo = new PictureBox();
            btn_Format = new Button();
            Panel_Main.SuspendLayout();
            Panel_Bottom.SuspendLayout();
            Panel_NoteAndNotebooks.SuspendLayout();
            Panel_Notes.SuspendLayout();
            panel1.SuspendLayout();
            Panel_NoteBooks.SuspendLayout();
            panel2.SuspendLayout();
            Panel_Top.SuspendLayout();
            Panel_Left.SuspendLayout();
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
            Panel_Main.Controls.Add(Panel_Top);
            Panel_Main.Controls.Add(Panel_Right);
            Panel_Main.Controls.Add(Panel_Left);
            Panel_Main.Dock = DockStyle.Fill;
            Panel_Main.Location = new Point(0, 0);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(978, 544);
            Panel_Main.TabIndex = 1;
            Panel_Main.Visible = false;
            // 
            // TextArea
            // 
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Dock = DockStyle.Fill;
            TextArea.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextArea.Location = new Point(412, 109);
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(493, 387);
            TextArea.TabIndex = 8;
            TextArea.Text = "";
            TextArea.MouseClick += TextArea_MouseClick;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.BackColor = Color.WhiteSmoke;
            Panel_Bottom.Controls.Add(btn_Format);
            Panel_Bottom.Controls.Add(btn_Delete);
            Panel_Bottom.Controls.Add(btn_Save);
            Panel_Bottom.Dock = DockStyle.Bottom;
            Panel_Bottom.Location = new Point(412, 496);
            Panel_Bottom.Name = "Panel_Bottom";
            Panel_Bottom.Size = new Size(493, 48);
            Panel_Bottom.TabIndex = 3;
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Right;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Image = Properties.Resources.icon_DeleteV2Yellow_x48;
            btn_Delete.Location = new Point(397, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(48, 48);
            btn_Delete.TabIndex = 1;
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Save
            // 
            btn_Save.Dock = DockStyle.Right;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Image = Properties.Resources.icon_SaveYellow_x48;
            btn_Save.Location = new Point(445, 0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(48, 48);
            btn_Save.TabIndex = 0;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // tbx_Title
            // 
            tbx_Title.BorderStyle = BorderStyle.None;
            tbx_Title.Dock = DockStyle.Top;
            tbx_Title.Font = new Font("Tahoma", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Title.Location = new Point(412, 55);
            tbx_Title.Name = "tbx_Title";
            tbx_Title.Size = new Size(493, 54);
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
            Panel_SeparatorLeft.Location = new Point(373, 55);
            Panel_SeparatorLeft.Name = "Panel_SeparatorLeft";
            Panel_SeparatorLeft.Size = new Size(39, 489);
            Panel_SeparatorLeft.TabIndex = 4;
            // 
            // Panel_NoteAndNotebooks
            // 
            Panel_NoteAndNotebooks.BackColor = Color.White;
            Panel_NoteAndNotebooks.Controls.Add(Panel_Notes);
            Panel_NoteAndNotebooks.Controls.Add(panel1);
            Panel_NoteAndNotebooks.Controls.Add(Panel_NoteBooks);
            Panel_NoteAndNotebooks.Controls.Add(panel2);
            Panel_NoteAndNotebooks.Dock = DockStyle.Left;
            Panel_NoteAndNotebooks.Location = new Point(55, 55);
            Panel_NoteAndNotebooks.Name = "Panel_NoteAndNotebooks";
            Panel_NoteAndNotebooks.Size = new Size(318, 489);
            Panel_NoteAndNotebooks.TabIndex = 2;
            Panel_NoteAndNotebooks.Paint += Panel_NoteAndNotebooks_Paint;
            // 
            // Panel_Notes
            // 
            Panel_Notes.Controls.Add(ls_Notes);
            Panel_Notes.Dock = DockStyle.Top;
            Panel_Notes.Location = new Point(0, 285);
            Panel_Notes.Name = "Panel_Notes";
            Panel_Notes.Size = new Size(318, 188);
            Panel_Notes.TabIndex = 5;
            // 
            // ls_Notes
            // 
            ls_Notes.BorderStyle = BorderStyle.None;
            ls_Notes.Dock = DockStyle.Fill;
            ls_Notes.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ls_Notes.FormattingEnabled = true;
            ls_Notes.ItemHeight = 29;
            ls_Notes.Location = new Point(0, 0);
            ls_Notes.Name = "ls_Notes";
            ls_Notes.Size = new Size(318, 188);
            ls_Notes.TabIndex = 3;
            ls_Notes.SelectedIndexChanged += ls_Notes_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 53);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 14);
            label2.Name = "label2";
            label2.Size = new Size(90, 36);
            label2.TabIndex = 1;
            label2.Text = "Notes";
            // 
            // Panel_NoteBooks
            // 
            Panel_NoteBooks.BackColor = Color.White;
            Panel_NoteBooks.Controls.Add(btn_RenameNoteBook);
            Panel_NoteBooks.Controls.Add(ls_NoteBooks);
            Panel_NoteBooks.Controls.Add(tbx_NameNotebook);
            Panel_NoteBooks.Dock = DockStyle.Top;
            Panel_NoteBooks.Location = new Point(0, 53);
            Panel_NoteBooks.Name = "Panel_NoteBooks";
            Panel_NoteBooks.Size = new Size(318, 179);
            Panel_NoteBooks.TabIndex = 2;
            // 
            // btn_RenameNoteBook
            // 
            btn_RenameNoteBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_RenameNoteBook.FlatAppearance.BorderSize = 0;
            btn_RenameNoteBook.FlatStyle = FlatStyle.Flat;
            btn_RenameNoteBook.Image = Properties.Resources.icon_EditYellow_x48;
            btn_RenameNoteBook.Location = new Point(261, 9);
            btn_RenameNoteBook.Name = "btn_RenameNoteBook";
            btn_RenameNoteBook.Size = new Size(51, 45);
            btn_RenameNoteBook.TabIndex = 2;
            btn_RenameNoteBook.UseVisualStyleBackColor = true;
            btn_RenameNoteBook.Click += btn_RenameNoteBook_Click;
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
            ls_NoteBooks.Location = new Point(0, 63);
            ls_NoteBooks.Name = "ls_NoteBooks";
            ls_NoteBooks.Size = new Size(318, 116);
            ls_NoteBooks.TabIndex = 0;
            ls_NoteBooks.SelectedIndexChanged += ls_NoteBooks_SelectedIndexChanged;
            // 
            // tbx_NameNotebook
            // 
            tbx_NameNotebook.BorderStyle = BorderStyle.None;
            tbx_NameNotebook.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NameNotebook.Location = new Point(6, 15);
            tbx_NameNotebook.Name = "tbx_NameNotebook";
            tbx_NameNotebook.Size = new Size(233, 37);
            tbx_NameNotebook.TabIndex = 1;
            tbx_NameNotebook.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btn_DeleteNotebook);
            panel2.Controls.Add(btn_SortNoteBooks);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 53);
            panel2.TabIndex = 5;
            // 
            // btn_DeleteNotebook
            // 
            btn_DeleteNotebook.Location = new Point(240, 11);
            btn_DeleteNotebook.Name = "btn_DeleteNotebook";
            btn_DeleteNotebook.Size = new Size(33, 34);
            btn_DeleteNotebook.TabIndex = 2;
            btn_DeleteNotebook.Text = "Delete";
            btn_DeleteNotebook.UseVisualStyleBackColor = true;
            btn_DeleteNotebook.Click += btn_DeleteNotebook_Click;
            // 
            // btn_SortNoteBooks
            // 
            btn_SortNoteBooks.Location = new Point(279, 11);
            btn_SortNoteBooks.Name = "btn_SortNoteBooks";
            btn_SortNoteBooks.Size = new Size(33, 34);
            btn_SortNoteBooks.TabIndex = 1;
            btn_SortNoteBooks.Text = "Ordenar";
            btn_SortNoteBooks.UseVisualStyleBackColor = true;
            btn_SortNoteBooks.Click += btn_SortNoteBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(155, 36);
            label1.TabIndex = 0;
            label1.Text = "NoteBooks";
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.Gainsboro;
            Panel_Top.Controls.Add(textBox1);
            Panel_Top.Dock = DockStyle.Top;
            Panel_Top.Location = new Point(55, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(883, 55);
            Panel_Top.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 2;
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
            // Panel_Left
            // 
            Panel_Left.BackColor = Color.Black;
            Panel_Left.Controls.Add(btn_Home);
            Panel_Left.Controls.Add(btn_Note);
            Panel_Left.Controls.Add(btn_NoteBook);
            Panel_Left.Controls.Add(btn_New);
            Panel_Left.Dock = DockStyle.Left;
            Panel_Left.ForeColor = SystemColors.ControlLightLight;
            Panel_Left.Location = new Point(0, 0);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new Size(55, 544);
            Panel_Left.TabIndex = 1;
            // 
            // btn_Home
            // 
            btn_Home.Dock = DockStyle.Bottom;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.ForeColor = SystemColors.Desktop;
            btn_Home.Image = Properties.Resources.icon_homeYellow_x48;
            btn_Home.Location = new Point(0, 482);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(55, 62);
            btn_Home.TabIndex = 3;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // btn_Note
            // 
            btn_Note.Dock = DockStyle.Top;
            btn_Note.FlatStyle = FlatStyle.Flat;
            btn_Note.ForeColor = SystemColors.Desktop;
            btn_Note.Image = Properties.Resources.icon_NoteYellow_x48;
            btn_Note.Location = new Point(0, 120);
            btn_Note.Name = "btn_Note";
            btn_Note.Size = new Size(55, 64);
            btn_Note.TabIndex = 0;
            btn_Note.UseVisualStyleBackColor = true;
            btn_Note.Visible = false;
            btn_Note.Click += btn_Note_Click;
            // 
            // btn_NoteBook
            // 
            btn_NoteBook.Dock = DockStyle.Top;
            btn_NoteBook.FlatStyle = FlatStyle.Flat;
            btn_NoteBook.ForeColor = SystemColors.Desktop;
            btn_NoteBook.Image = Properties.Resources.icon_NotebookYellow_x48;
            btn_NoteBook.Location = new Point(0, 55);
            btn_NoteBook.Name = "btn_NoteBook";
            btn_NoteBook.Size = new Size(55, 65);
            btn_NoteBook.TabIndex = 2;
            btn_NoteBook.UseVisualStyleBackColor = true;
            btn_NoteBook.Visible = false;
            btn_NoteBook.Click += btn_NoteBook_Click;
            // 
            // btn_New
            // 
            btn_New.Dock = DockStyle.Top;
            btn_New.FlatStyle = FlatStyle.Flat;
            btn_New.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_New.ForeColor = Color.Black;
            btn_New.Image = Properties.Resources.icon_PlusYellow_x48;
            btn_New.Location = new Point(0, 0);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(55, 55);
            btn_New.TabIndex = 1;
            btn_New.TextAlign = ContentAlignment.MiddleRight;
            btn_New.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
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
            // btn_Format
            // 
            btn_Format.Location = new Point(6, 7);
            btn_Format.Name = "btn_Format";
            btn_Format.Size = new Size(39, 34);
            btn_Format.TabIndex = 2;
            btn_Format.Text = "F";
            btn_Format.UseVisualStyleBackColor = true;
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
            Panel_Notes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Panel_NoteBooks.ResumeLayout(false);
            Panel_NoteBooks.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Panel_Top.ResumeLayout(false);
            Panel_Top.PerformLayout();
            Panel_Left.ResumeLayout(false);
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
        private TextBox tbx_NameNotebook;
        private ListBox ls_Notes;
        private Panel Panel_NoteBooks;
        private Button btn_Delete;
        private Button btn_Save;
        private Panel panel1;
        private Button btn_Home;
        private TextBox textBox1;
        private Panel Panel_Notes;
        private Button btn_RenameNoteBook;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btn_SortNoteBooks;
        private Button btn_DeleteNotebook;
        private Button btn_Format;
    }
}
