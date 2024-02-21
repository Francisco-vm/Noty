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
            tbx_Title = new TextBox();
            Panel_SeparatorRight = new Panel();
            Panel_Right = new Panel();
            Panel_SeparatorLeft = new Panel();
            Panel_Bottom = new Panel();
            Panel_Notes = new Panel();
            ls_Notes = new ListBox();
            Panel_NotesTop = new Panel();
            pictureBox1 = new PictureBox();
            tbx_NameNotebook = new TextBox();
            Panel_Left = new Panel();
            Panel_NoteBooks = new Panel();
            ls_NoteBooks = new ListBox();
            Panel_LeftButtons = new Panel();
            btn_NoteBook = new Button();
            btn_New = new Button();
            btn_Note = new Button();
            Panel_Top = new Panel();
            Panel_Welcome = new Panel();
            lbl_By = new Label();
            lbl_SelectRoot = new Label();
            btn_OpenRoot = new Button();
            lbl_Noty = new Label();
            pic_Logo = new PictureBox();
            Panel_Main.SuspendLayout();
            Panel_Notes.SuspendLayout();
            Panel_NotesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_Left.SuspendLayout();
            Panel_NoteBooks.SuspendLayout();
            Panel_LeftButtons.SuspendLayout();
            Panel_Welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // Panel_Main
            // 
            Panel_Main.BackColor = SystemColors.ActiveBorder;
            Panel_Main.Controls.Add(TextArea);
            Panel_Main.Controls.Add(tbx_Title);
            Panel_Main.Controls.Add(Panel_SeparatorRight);
            Panel_Main.Controls.Add(Panel_Right);
            Panel_Main.Controls.Add(Panel_SeparatorLeft);
            Panel_Main.Controls.Add(Panel_Bottom);
            Panel_Main.Controls.Add(Panel_Notes);
            Panel_Main.Controls.Add(Panel_Left);
            Panel_Main.Controls.Add(Panel_Top);
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
            TextArea.Location = new Point(355, 106);
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(512, 413);
            TextArea.TabIndex = 8;
            TextArea.Text = "";
            // 
            // tbx_Title
            // 
            tbx_Title.BorderStyle = BorderStyle.FixedSingle;
            tbx_Title.Dock = DockStyle.Top;
            tbx_Title.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Title.Location = new Point(355, 55);
            tbx_Title.Name = "tbx_Title";
            tbx_Title.Size = new Size(512, 51);
            tbx_Title.TabIndex = 7;
            tbx_Title.TextAlign = HorizontalAlignment.Center;
            // 
            // Panel_SeparatorRight
            // 
            Panel_SeparatorRight.BackColor = Color.White;
            Panel_SeparatorRight.Dock = DockStyle.Right;
            Panel_SeparatorRight.Location = new Point(867, 55);
            Panel_SeparatorRight.Name = "Panel_SeparatorRight";
            Panel_SeparatorRight.Size = new Size(33, 464);
            Panel_SeparatorRight.TabIndex = 6;
            // 
            // Panel_Right
            // 
            Panel_Right.BackColor = Color.FromArgb(128, 128, 255);
            Panel_Right.Dock = DockStyle.Right;
            Panel_Right.Location = new Point(900, 55);
            Panel_Right.Name = "Panel_Right";
            Panel_Right.Size = new Size(78, 464);
            Panel_Right.TabIndex = 5;
            // 
            // Panel_SeparatorLeft
            // 
            Panel_SeparatorLeft.BackColor = Color.White;
            Panel_SeparatorLeft.Dock = DockStyle.Left;
            Panel_SeparatorLeft.Location = new Point(316, 55);
            Panel_SeparatorLeft.Name = "Panel_SeparatorLeft";
            Panel_SeparatorLeft.Size = new Size(39, 464);
            Panel_SeparatorLeft.TabIndex = 4;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.BackColor = Color.FromArgb(128, 255, 128);
            Panel_Bottom.Dock = DockStyle.Bottom;
            Panel_Bottom.Location = new Point(316, 519);
            Panel_Bottom.Name = "Panel_Bottom";
            Panel_Bottom.Size = new Size(662, 25);
            Panel_Bottom.TabIndex = 3;
            // 
            // Panel_Notes
            // 
            Panel_Notes.BackColor = Color.FromArgb(255, 255, 128);
            Panel_Notes.Controls.Add(ls_Notes);
            Panel_Notes.Controls.Add(Panel_NotesTop);
            Panel_Notes.Dock = DockStyle.Left;
            Panel_Notes.Location = new Point(133, 55);
            Panel_Notes.Name = "Panel_Notes";
            Panel_Notes.Size = new Size(183, 489);
            Panel_Notes.TabIndex = 2;
            // 
            // ls_Notes
            // 
            ls_Notes.BorderStyle = BorderStyle.None;
            ls_Notes.Dock = DockStyle.Fill;
            ls_Notes.FormattingEnabled = true;
            ls_Notes.ItemHeight = 25;
            ls_Notes.Location = new Point(0, 108);
            ls_Notes.Name = "ls_Notes";
            ls_Notes.Size = new Size(183, 381);
            ls_Notes.TabIndex = 3;
            ls_Notes.SelectedIndexChanged += ls_Notes_SelectedIndexChanged;
            // 
            // Panel_NotesTop
            // 
            Panel_NotesTop.BackColor = Color.White;
            Panel_NotesTop.Controls.Add(pictureBox1);
            Panel_NotesTop.Controls.Add(tbx_NameNotebook);
            Panel_NotesTop.Dock = DockStyle.Top;
            Panel_NotesTop.Location = new Point(0, 0);
            Panel_NotesTop.Name = "Panel_NotesTop";
            Panel_NotesTop.Size = new Size(183, 108);
            Panel_NotesTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Folder_x48;
            pictureBox1.Location = new Point(69, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbx_NameNotebook
            // 
            tbx_NameNotebook.BorderStyle = BorderStyle.None;
            tbx_NameNotebook.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NameNotebook.Location = new Point(0, 58);
            tbx_NameNotebook.Name = "tbx_NameNotebook";
            tbx_NameNotebook.Size = new Size(183, 34);
            tbx_NameNotebook.TabIndex = 1;
            tbx_NameNotebook.TextAlign = HorizontalAlignment.Center;
            // 
            // Panel_Left
            // 
            Panel_Left.BackColor = Color.FromArgb(255, 192, 128);
            Panel_Left.Controls.Add(Panel_NoteBooks);
            Panel_Left.Controls.Add(Panel_LeftButtons);
            Panel_Left.Dock = DockStyle.Left;
            Panel_Left.Location = new Point(0, 55);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new Size(133, 489);
            Panel_Left.TabIndex = 1;
            // 
            // Panel_NoteBooks
            // 
            Panel_NoteBooks.Controls.Add(ls_NoteBooks);
            Panel_NoteBooks.Dock = DockStyle.Fill;
            Panel_NoteBooks.Location = new Point(0, 108);
            Panel_NoteBooks.Name = "Panel_NoteBooks";
            Panel_NoteBooks.Size = new Size(133, 381);
            Panel_NoteBooks.TabIndex = 1;
            // 
            // ls_NoteBooks
            // 
            ls_NoteBooks.BorderStyle = BorderStyle.None;
            ls_NoteBooks.Dock = DockStyle.Fill;
            ls_NoteBooks.FormattingEnabled = true;
            ls_NoteBooks.ItemHeight = 25;
            ls_NoteBooks.Location = new Point(0, 0);
            ls_NoteBooks.Name = "ls_NoteBooks";
            ls_NoteBooks.Size = new Size(133, 381);
            ls_NoteBooks.TabIndex = 0;
            ls_NoteBooks.SelectedIndexChanged += ls_NoteBooks_SelectedIndexChanged;
            // 
            // Panel_LeftButtons
            // 
            Panel_LeftButtons.BackColor = Color.White;
            Panel_LeftButtons.Controls.Add(btn_NoteBook);
            Panel_LeftButtons.Controls.Add(btn_New);
            Panel_LeftButtons.Controls.Add(btn_Note);
            Panel_LeftButtons.Dock = DockStyle.Top;
            Panel_LeftButtons.Location = new Point(0, 0);
            Panel_LeftButtons.Name = "Panel_LeftButtons";
            Panel_LeftButtons.Size = new Size(133, 108);
            Panel_LeftButtons.TabIndex = 0;
            // 
            // btn_NoteBook
            // 
            btn_NoteBook.Location = new Point(87, 58);
            btn_NoteBook.Name = "btn_NoteBook";
            btn_NoteBook.Size = new Size(40, 34);
            btn_NoteBook.TabIndex = 2;
            btn_NoteBook.Text = "Nb";
            btn_NoteBook.UseVisualStyleBackColor = true;
            btn_NoteBook.Visible = false;
            // 
            // btn_New
            // 
            btn_New.Location = new Point(52, 6);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(40, 34);
            btn_New.TabIndex = 1;
            btn_New.Text = "+";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // btn_Note
            // 
            btn_Note.Location = new Point(12, 58);
            btn_Note.Name = "btn_Note";
            btn_Note.Size = new Size(40, 34);
            btn_Note.TabIndex = 0;
            btn_Note.Text = "N";
            btn_Note.UseVisualStyleBackColor = true;
            btn_Note.Visible = false;
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.FromArgb(255, 128, 128);
            Panel_Top.Dock = DockStyle.Top;
            Panel_Top.Location = new Point(0, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(978, 55);
            Panel_Top.TabIndex = 0;
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
            Panel_Notes.ResumeLayout(false);
            Panel_NotesTop.ResumeLayout(false);
            Panel_NotesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_Left.ResumeLayout(false);
            Panel_NoteBooks.ResumeLayout(false);
            Panel_LeftButtons.ResumeLayout(false);
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
        private Panel Panel_Notes;
        private Panel Panel_Left;
        private RichTextBox TextArea;
        private TextBox tbx_Title;
        private Panel Panel_SeparatorRight;
        private Panel Panel_Right;
        private Panel Panel_SeparatorLeft;
        private Panel Panel_NoteBooks;
        private Panel Panel_LeftButtons;
        private Button btn_Note;
        private ListBox ls_NoteBooks;
        private Button btn_NoteBook;
        private Button btn_New;
        private PictureBox pictureBox1;
        private TextBox tbx_NameNotebook;
        private ListBox ls_Notes;
        private Panel Panel_NotesTop;
    }
}
