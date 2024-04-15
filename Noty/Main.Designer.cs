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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Panel_Main = new Panel();
            TextArea = new RichTextBox();
            Panel_Bottom = new Panel();
            btn_Cut = new Button();
            btn_Paste = new Button();
            btn_Copy = new Button();
            btn_Undo = new Button();
            btn_Redo = new Button();
            tbx_Title = new TextBox();
            Panel_SeparatorRight = new Panel();
            Panel_SeparatorLeft = new Panel();
            Panel_NoteAndNotebooks = new Panel();
            Panel_Notes = new Panel();
            ls_Notes = new ListBox();
            PanelGoldNotes = new Panel();
            btn_SortNotes = new Button();
            lbl_GoldNotes = new Label();
            btn_Delete = new Button();
            Panel_NoteBooks = new Panel();
            ls_NoteBooks = new ListBox();
            Panel_GoldNoteBooks = new Panel();
            btn_RenameNoteBook = new Button();
            tbx_NameNotebook = new TextBox();
            btn_SortNoteBooks = new Button();
            lbl_GoldNoteBooks = new Label();
            btn_DeleteNoteBook = new Button();
            Panel_Top = new Panel();
            tbx_Screach = new TextBox();
            Panel_Right = new Panel();
            Panel_Left = new Panel();
            lbl_Change = new Label();
            lbl_Home = new Label();
            btn_ReOpenRoot = new Button();
            lbl_Menu = new Label();
            btn_NoteBook = new Button();
            btn_Note = new Button();
            lbl_Note = new Label();
            lbl_NoteBook = new Label();
            lbl_New = new Label();
            btn_Expand = new Button();
            btn_Home = new Button();
            btn_New = new Button();
            Panel_Welcome = new Panel();
            Panel_WelcomeTop = new Panel();
            pic_Github = new PictureBox();
            pic_Noty = new PictureBox();
            lbl_SelectRoot = new Label();
            lbl_By = new Label();
            btn_OpenRoot = new Button();
            lbl_Noty = new Label();
            lbl_Thanks = new Label();
            Panel_LeftTimer = new System.Windows.Forms.Timer(components);
            toolTip = new ToolTip(components);
            Panel_Main.SuspendLayout();
            Panel_Bottom.SuspendLayout();
            Panel_NoteAndNotebooks.SuspendLayout();
            Panel_Notes.SuspendLayout();
            PanelGoldNotes.SuspendLayout();
            Panel_NoteBooks.SuspendLayout();
            Panel_GoldNoteBooks.SuspendLayout();
            Panel_Top.SuspendLayout();
            Panel_Left.SuspendLayout();
            Panel_Welcome.SuspendLayout();
            Panel_WelcomeTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Noty).BeginInit();
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
            resources.ApplyResources(Panel_Main, "Panel_Main");
            Panel_Main.Name = "Panel_Main";
            // 
            // TextArea
            // 
            TextArea.AcceptsTab = true;
            TextArea.BackColor = Color.White;
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Cursor = Cursors.IBeam;
            resources.ApplyResources(TextArea, "TextArea");
            TextArea.Name = "TextArea";
            TextArea.ReadOnly = true;
            TextArea.TextChanged += TextArea_TextChanged;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.BackColor = Color.WhiteSmoke;
            Panel_Bottom.Controls.Add(btn_Cut);
            Panel_Bottom.Controls.Add(btn_Paste);
            Panel_Bottom.Controls.Add(btn_Copy);
            Panel_Bottom.Controls.Add(btn_Undo);
            Panel_Bottom.Controls.Add(btn_Redo);
            resources.ApplyResources(Panel_Bottom, "Panel_Bottom");
            Panel_Bottom.Name = "Panel_Bottom";
            // 
            // btn_Cut
            // 
            resources.ApplyResources(btn_Cut, "btn_Cut");
            btn_Cut.FlatAppearance.BorderSize = 0;
            btn_Cut.Image = Properties.Resources.icon_Cut_x24;
            btn_Cut.Name = "btn_Cut";
            btn_Cut.UseVisualStyleBackColor = true;
            btn_Cut.Click += btn_Cut_Click;
            // 
            // btn_Paste
            // 
            resources.ApplyResources(btn_Paste, "btn_Paste");
            btn_Paste.FlatAppearance.BorderSize = 0;
            btn_Paste.Image = Properties.Resources.icon_Paste_x24;
            btn_Paste.Name = "btn_Paste";
            btn_Paste.UseVisualStyleBackColor = true;
            btn_Paste.Click += btn_Paste_Click;
            // 
            // btn_Copy
            // 
            resources.ApplyResources(btn_Copy, "btn_Copy");
            btn_Copy.FlatAppearance.BorderSize = 0;
            btn_Copy.Image = Properties.Resources.icon_Copy_x24;
            btn_Copy.Name = "btn_Copy";
            btn_Copy.UseVisualStyleBackColor = true;
            btn_Copy.Click += btn_Copy_Click;
            // 
            // btn_Undo
            // 
            resources.ApplyResources(btn_Undo, "btn_Undo");
            btn_Undo.FlatAppearance.BorderSize = 0;
            btn_Undo.Image = Properties.Resources.icon_Undo_x24;
            btn_Undo.Name = "btn_Undo";
            btn_Undo.UseVisualStyleBackColor = true;
            btn_Undo.Click += btn_Undo_Click;
            // 
            // btn_Redo
            // 
            resources.ApplyResources(btn_Redo, "btn_Redo");
            btn_Redo.FlatAppearance.BorderSize = 0;
            btn_Redo.Image = Properties.Resources.icon_Redo_x24;
            btn_Redo.Name = "btn_Redo";
            btn_Redo.UseVisualStyleBackColor = true;
            btn_Redo.Click += btn_Redo_Click;
            // 
            // tbx_Title
            // 
            tbx_Title.BackColor = Color.White;
            tbx_Title.BorderStyle = BorderStyle.None;
            tbx_Title.Cursor = Cursors.IBeam;
            resources.ApplyResources(tbx_Title, "tbx_Title");
            tbx_Title.Name = "tbx_Title";
            tbx_Title.ReadOnly = true;
            tbx_Title.TextChanged += tbx_Title_TextChanged;
            tbx_Title.KeyPress += tbx_Title_KeyPress;
            // 
            // Panel_SeparatorRight
            // 
            Panel_SeparatorRight.BackColor = Color.White;
            resources.ApplyResources(Panel_SeparatorRight, "Panel_SeparatorRight");
            Panel_SeparatorRight.Name = "Panel_SeparatorRight";
            // 
            // Panel_SeparatorLeft
            // 
            Panel_SeparatorLeft.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(Panel_SeparatorLeft, "Panel_SeparatorLeft");
            Panel_SeparatorLeft.Name = "Panel_SeparatorLeft";
            // 
            // Panel_NoteAndNotebooks
            // 
            Panel_NoteAndNotebooks.BackColor = Color.White;
            Panel_NoteAndNotebooks.Controls.Add(Panel_Notes);
            Panel_NoteAndNotebooks.Controls.Add(PanelGoldNotes);
            Panel_NoteAndNotebooks.Controls.Add(Panel_NoteBooks);
            Panel_NoteAndNotebooks.Controls.Add(Panel_GoldNoteBooks);
            resources.ApplyResources(Panel_NoteAndNotebooks, "Panel_NoteAndNotebooks");
            Panel_NoteAndNotebooks.Name = "Panel_NoteAndNotebooks";
            // 
            // Panel_Notes
            // 
            Panel_Notes.Controls.Add(ls_Notes);
            resources.ApplyResources(Panel_Notes, "Panel_Notes");
            Panel_Notes.Name = "Panel_Notes";
            // 
            // ls_Notes
            // 
            ls_Notes.BorderStyle = BorderStyle.None;
            resources.ApplyResources(ls_Notes, "ls_Notes");
            ls_Notes.FormattingEnabled = true;
            ls_Notes.Name = "ls_Notes";
            ls_Notes.DrawItem += ls_Notes_DrawItem;
            ls_Notes.SelectedIndexChanged += ls_Notes_SelectedIndexChanged;
            // 
            // PanelGoldNotes
            // 
            PanelGoldNotes.BackColor = Color.Gold;
            PanelGoldNotes.Controls.Add(btn_SortNotes);
            PanelGoldNotes.Controls.Add(lbl_GoldNotes);
            PanelGoldNotes.Controls.Add(btn_Delete);
            resources.ApplyResources(PanelGoldNotes, "PanelGoldNotes");
            PanelGoldNotes.Name = "PanelGoldNotes";
            // 
            // btn_SortNotes
            // 
            resources.ApplyResources(btn_SortNotes, "btn_SortNotes");
            btn_SortNotes.FlatAppearance.BorderSize = 0;
            btn_SortNotes.Image = Properties.Resources.icon_Sort_x24;
            btn_SortNotes.Name = "btn_SortNotes";
            btn_SortNotes.UseVisualStyleBackColor = true;
            btn_SortNotes.Click += btn_SortNotes_Click;
            // 
            // lbl_GoldNotes
            // 
            resources.ApplyResources(lbl_GoldNotes, "lbl_GoldNotes");
            lbl_GoldNotes.Name = "lbl_GoldNotes";
            // 
            // btn_Delete
            // 
            resources.ApplyResources(btn_Delete, "btn_Delete");
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.Image = Properties.Resources.icon_Delete_x24;
            btn_Delete.Name = "btn_Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Panel_NoteBooks
            // 
            Panel_NoteBooks.BackColor = Color.White;
            Panel_NoteBooks.Controls.Add(ls_NoteBooks);
            resources.ApplyResources(Panel_NoteBooks, "Panel_NoteBooks");
            Panel_NoteBooks.Name = "Panel_NoteBooks";
            // 
            // ls_NoteBooks
            // 
            ls_NoteBooks.BackColor = Color.White;
            ls_NoteBooks.BorderStyle = BorderStyle.None;
            resources.ApplyResources(ls_NoteBooks, "ls_NoteBooks");
            ls_NoteBooks.ForeColor = Color.Black;
            ls_NoteBooks.FormattingEnabled = true;
            ls_NoteBooks.Name = "ls_NoteBooks";
            ls_NoteBooks.DrawItem += ls_NoteBooks_DrawItem;
            ls_NoteBooks.SelectedIndexChanged += ls_NoteBooks_SelectedIndexChanged;
            // 
            // Panel_GoldNoteBooks
            // 
            Panel_GoldNoteBooks.BackColor = Color.Gold;
            Panel_GoldNoteBooks.Controls.Add(btn_RenameNoteBook);
            Panel_GoldNoteBooks.Controls.Add(tbx_NameNotebook);
            Panel_GoldNoteBooks.Controls.Add(btn_SortNoteBooks);
            Panel_GoldNoteBooks.Controls.Add(lbl_GoldNoteBooks);
            Panel_GoldNoteBooks.Controls.Add(btn_DeleteNoteBook);
            resources.ApplyResources(Panel_GoldNoteBooks, "Panel_GoldNoteBooks");
            Panel_GoldNoteBooks.Name = "Panel_GoldNoteBooks";
            // 
            // btn_RenameNoteBook
            // 
            resources.ApplyResources(btn_RenameNoteBook, "btn_RenameNoteBook");
            btn_RenameNoteBook.FlatAppearance.BorderSize = 0;
            btn_RenameNoteBook.Image = Properties.Resources.icon_Edit_x24;
            btn_RenameNoteBook.Name = "btn_RenameNoteBook";
            btn_RenameNoteBook.UseVisualStyleBackColor = true;
            btn_RenameNoteBook.Click += btn_RenameNoteBook_Click;
            // 
            // tbx_NameNotebook
            // 
            tbx_NameNotebook.BackColor = Color.Gold;
            tbx_NameNotebook.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tbx_NameNotebook, "tbx_NameNotebook");
            tbx_NameNotebook.Name = "tbx_NameNotebook";
            tbx_NameNotebook.ReadOnly = true;
            // 
            // btn_SortNoteBooks
            // 
            resources.ApplyResources(btn_SortNoteBooks, "btn_SortNoteBooks");
            btn_SortNoteBooks.FlatAppearance.BorderSize = 0;
            btn_SortNoteBooks.Image = Properties.Resources.icon_Sort_x24;
            btn_SortNoteBooks.Name = "btn_SortNoteBooks";
            btn_SortNoteBooks.UseVisualStyleBackColor = true;
            btn_SortNoteBooks.Click += btn_SortNoteBooks_Click;
            // 
            // lbl_GoldNoteBooks
            // 
            resources.ApplyResources(lbl_GoldNoteBooks, "lbl_GoldNoteBooks");
            lbl_GoldNoteBooks.ForeColor = Color.Black;
            lbl_GoldNoteBooks.Name = "lbl_GoldNoteBooks";
            // 
            // btn_DeleteNoteBook
            // 
            resources.ApplyResources(btn_DeleteNoteBook, "btn_DeleteNoteBook");
            btn_DeleteNoteBook.FlatAppearance.BorderSize = 0;
            btn_DeleteNoteBook.Image = Properties.Resources.icon_Delete_x24;
            btn_DeleteNoteBook.Name = "btn_DeleteNoteBook";
            btn_DeleteNoteBook.UseVisualStyleBackColor = true;
            btn_DeleteNoteBook.Click += btn_DeleteNotebook_Click;
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.Gainsboro;
            Panel_Top.Controls.Add(tbx_Screach);
            resources.ApplyResources(Panel_Top, "Panel_Top");
            Panel_Top.Name = "Panel_Top";
            // 
            // tbx_Screach
            // 
            tbx_Screach.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(tbx_Screach, "tbx_Screach");
            tbx_Screach.Name = "tbx_Screach";
            // 
            // Panel_Right
            // 
            Panel_Right.BackColor = Color.Black;
            resources.ApplyResources(Panel_Right, "Panel_Right");
            Panel_Right.Name = "Panel_Right";
            // 
            // Panel_Left
            // 
            Panel_Left.BackColor = Color.FromArgb(35, 40, 45);
            Panel_Left.Controls.Add(lbl_Change);
            Panel_Left.Controls.Add(lbl_Home);
            Panel_Left.Controls.Add(btn_ReOpenRoot);
            Panel_Left.Controls.Add(lbl_Menu);
            Panel_Left.Controls.Add(btn_NoteBook);
            Panel_Left.Controls.Add(btn_Note);
            Panel_Left.Controls.Add(lbl_Note);
            Panel_Left.Controls.Add(lbl_NoteBook);
            Panel_Left.Controls.Add(lbl_New);
            Panel_Left.Controls.Add(btn_Expand);
            Panel_Left.Controls.Add(btn_Home);
            Panel_Left.Controls.Add(btn_New);
            resources.ApplyResources(Panel_Left, "Panel_Left");
            Panel_Left.ForeColor = SystemColors.ControlLightLight;
            Panel_Left.Name = "Panel_Left";
            // 
            // lbl_Change
            // 
            resources.ApplyResources(lbl_Change, "lbl_Change");
            lbl_Change.ForeColor = SystemColors.ButtonShadow;
            lbl_Change.Name = "lbl_Change";
            // 
            // lbl_Home
            // 
            resources.ApplyResources(lbl_Home, "lbl_Home");
            lbl_Home.ForeColor = SystemColors.ButtonShadow;
            lbl_Home.Name = "lbl_Home";
            // 
            // btn_ReOpenRoot
            // 
            btn_ReOpenRoot.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_ReOpenRoot, "btn_ReOpenRoot");
            btn_ReOpenRoot.ForeColor = SystemColors.Desktop;
            btn_ReOpenRoot.Image = Properties.Resources.icon_Folder_x24;
            btn_ReOpenRoot.Name = "btn_ReOpenRoot";
            btn_ReOpenRoot.UseVisualStyleBackColor = true;
            btn_ReOpenRoot.Click += btn_ReOpenRoot_Click;
            // 
            // lbl_Menu
            // 
            resources.ApplyResources(lbl_Menu, "lbl_Menu");
            lbl_Menu.ForeColor = SystemColors.ButtonShadow;
            lbl_Menu.Name = "lbl_Menu";
            // 
            // btn_NoteBook
            // 
            btn_NoteBook.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_NoteBook, "btn_NoteBook");
            btn_NoteBook.ForeColor = SystemColors.Desktop;
            btn_NoteBook.Image = Properties.Resources.icon_Notebook_x24;
            btn_NoteBook.Name = "btn_NoteBook";
            btn_NoteBook.UseVisualStyleBackColor = true;
            btn_NoteBook.Click += btn_NoteBook_Click;
            // 
            // btn_Note
            // 
            btn_Note.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_Note, "btn_Note");
            btn_Note.ForeColor = SystemColors.Desktop;
            btn_Note.Image = Properties.Resources.icon_Note_x24;
            btn_Note.Name = "btn_Note";
            btn_Note.UseVisualStyleBackColor = true;
            btn_Note.Click += btn_Note_Click;
            // 
            // lbl_Note
            // 
            resources.ApplyResources(lbl_Note, "lbl_Note");
            lbl_Note.ForeColor = SystemColors.ButtonShadow;
            lbl_Note.Name = "lbl_Note";
            // 
            // lbl_NoteBook
            // 
            resources.ApplyResources(lbl_NoteBook, "lbl_NoteBook");
            lbl_NoteBook.ForeColor = SystemColors.ButtonShadow;
            lbl_NoteBook.Name = "lbl_NoteBook";
            // 
            // lbl_New
            // 
            resources.ApplyResources(lbl_New, "lbl_New");
            lbl_New.ForeColor = SystemColors.ButtonShadow;
            lbl_New.Name = "lbl_New";
            // 
            // btn_Expand
            // 
            btn_Expand.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_Expand, "btn_Expand");
            btn_Expand.Image = Properties.Resources.icon_Menu_x24;
            btn_Expand.Name = "btn_Expand";
            btn_Expand.UseVisualStyleBackColor = true;
            btn_Expand.Click += btn_Expand_Click;
            // 
            // btn_Home
            // 
            btn_Home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_Home, "btn_Home");
            btn_Home.ForeColor = SystemColors.Desktop;
            btn_Home.Image = Properties.Resources.icon_Home_x24;
            btn_Home.Name = "btn_Home";
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // btn_New
            // 
            btn_New.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_New, "btn_New");
            btn_New.ForeColor = Color.Black;
            btn_New.Image = Properties.Resources.icon_New_x24;
            btn_New.Name = "btn_New";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // Panel_Welcome
            // 
            Panel_Welcome.BackColor = Color.White;
            Panel_Welcome.Controls.Add(Panel_WelcomeTop);
            resources.ApplyResources(Panel_Welcome, "Panel_Welcome");
            Panel_Welcome.Name = "Panel_Welcome";
            // 
            // Panel_WelcomeTop
            // 
            Panel_WelcomeTop.Controls.Add(Panel_Main);
            Panel_WelcomeTop.Controls.Add(pic_Github);
            Panel_WelcomeTop.Controls.Add(pic_Noty);
            Panel_WelcomeTop.Controls.Add(lbl_SelectRoot);
            Panel_WelcomeTop.Controls.Add(lbl_By);
            Panel_WelcomeTop.Controls.Add(btn_OpenRoot);
            Panel_WelcomeTop.Controls.Add(lbl_Noty);
            Panel_WelcomeTop.Controls.Add(lbl_Thanks);
            resources.ApplyResources(Panel_WelcomeTop, "Panel_WelcomeTop");
            Panel_WelcomeTop.Name = "Panel_WelcomeTop";
            // 
            // pic_Github
            // 
            pic_Github.Image = Properties.Resources.icon_Github_x16;
            resources.ApplyResources(pic_Github, "pic_Github");
            pic_Github.Name = "pic_Github";
            pic_Github.TabStop = false;
            // 
            // pic_Noty
            // 
            pic_Noty.Image = Properties.Resources.Noty_notbg;
            resources.ApplyResources(pic_Noty, "pic_Noty");
            pic_Noty.Name = "pic_Noty";
            pic_Noty.TabStop = false;
            // 
            // lbl_SelectRoot
            // 
            resources.ApplyResources(lbl_SelectRoot, "lbl_SelectRoot");
            lbl_SelectRoot.Name = "lbl_SelectRoot";
            // 
            // lbl_By
            // 
            resources.ApplyResources(lbl_By, "lbl_By");
            lbl_By.Name = "lbl_By";
            // 
            // btn_OpenRoot
            // 
            btn_OpenRoot.BackColor = Color.White;
            btn_OpenRoot.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_OpenRoot, "btn_OpenRoot");
            btn_OpenRoot.Image = Properties.Resources.icon_FolderRoot_x64;
            btn_OpenRoot.Name = "btn_OpenRoot";
            btn_OpenRoot.UseVisualStyleBackColor = false;
            btn_OpenRoot.Click += btn_OpenRoot_Click;
            // 
            // lbl_Noty
            // 
            resources.ApplyResources(lbl_Noty, "lbl_Noty");
            lbl_Noty.Name = "lbl_Noty";
            // 
            // lbl_Thanks
            // 
            resources.ApplyResources(lbl_Thanks, "lbl_Thanks");
            lbl_Thanks.Name = "lbl_Thanks";
            // 
            // Panel_LeftTimer
            // 
            Panel_LeftTimer.Interval = 16;
            Panel_LeftTimer.Tick += slidebarTimer_Tick;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_Welcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Load += Main_Load;
            Panel_Main.ResumeLayout(false);
            Panel_Main.PerformLayout();
            Panel_Bottom.ResumeLayout(false);
            Panel_NoteAndNotebooks.ResumeLayout(false);
            Panel_Notes.ResumeLayout(false);
            PanelGoldNotes.ResumeLayout(false);
            PanelGoldNotes.PerformLayout();
            Panel_NoteBooks.ResumeLayout(false);
            Panel_GoldNoteBooks.ResumeLayout(false);
            Panel_GoldNoteBooks.PerformLayout();
            Panel_Top.ResumeLayout(false);
            Panel_Top.PerformLayout();
            Panel_Left.ResumeLayout(false);
            Panel_Left.PerformLayout();
            Panel_Welcome.ResumeLayout(false);
            Panel_WelcomeTop.ResumeLayout(false);
            Panel_WelcomeTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Noty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Main;
        private Panel Panel_Welcome;
        private PictureBox pic_Noty;
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
        private Panel PanelGoldNotes;
        private Button btn_Home;
        private TextBox tbx_Screach;
        private Panel Panel_Notes;
        private Button btn_RenameNoteBook;
        private Panel Panel_GoldNoteBooks;
        private Label lbl_GoldNotes;
        private Label lbl_GoldNoteBooks;
        private Button btn_SortNoteBooks;
        private Button btn_DeleteNoteBook;
        private System.Windows.Forms.Timer Panel_LeftTimer;
        private Button btn_Expand;
        private Label lbl_New;
        private Label lbl_Note;
        private Label lbl_NoteBook;
        private Label lbl_Menu;
        private Button btn_SortNotes;
        private Button btn_ReOpenRoot;
        private Label lbl_Change;
        private Label lbl_Home;
        private Button btn_Redo;
        private Button btn_Undo;
        private Button btn_Cut;
        private Button btn_Paste;
        private Button btn_Copy;
        private ToolTip toolTip;
        private Panel Panel_WelcomeTop;
        private PictureBox pic_Github;
        private Label lbl_Thanks;
    }
}
