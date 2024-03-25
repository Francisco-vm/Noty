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
            lbl_By = new Label();
            lbl_SelectRoot = new Label();
            btn_OpenRoot = new Button();
            lbl_Noty = new Label();
            pic_Noty = new PictureBox();
            Panel_LeftTimer = new System.Windows.Forms.Timer(components);
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
            Panel_Main.Dock = DockStyle.Fill;
            Panel_Main.Location = new Point(0, 0);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(979, 543);
            Panel_Main.TabIndex = 1;
            Panel_Main.Visible = false;
            // 
            // TextArea
            // 
            TextArea.AcceptsTab = true;
            TextArea.BackColor = Color.White;
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Cursor = Cursors.IBeam;
            TextArea.Dock = DockStyle.Fill;
            TextArea.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextArea.Location = new Point(527, 109);
            TextArea.Name = "TextArea";
            TextArea.ReadOnly = true;
            TextArea.Size = new Size(379, 386);
            TextArea.TabIndex = 8;
            TextArea.Text = "";
            TextArea.TextChanged += TextArea_TextChanged;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.BackColor = Color.WhiteSmoke;
            Panel_Bottom.Controls.Add(btn_Undo);
            Panel_Bottom.Controls.Add(btn_Redo);
            Panel_Bottom.Dock = DockStyle.Bottom;
            Panel_Bottom.Location = new Point(527, 495);
            Panel_Bottom.Name = "Panel_Bottom";
            Panel_Bottom.Size = new Size(379, 48);
            Panel_Bottom.TabIndex = 3;
            // 
            // btn_Undo
            // 
            btn_Undo.Dock = DockStyle.Right;
            btn_Undo.FlatAppearance.BorderSize = 0;
            btn_Undo.FlatStyle = FlatStyle.Flat;
            btn_Undo.Image = Properties.Resources.icon_Undo_x24;
            btn_Undo.Location = new Point(299, 0);
            btn_Undo.Name = "btn_Undo";
            btn_Undo.Size = new Size(40, 48);
            btn_Undo.TabIndex = 4;
            btn_Undo.UseVisualStyleBackColor = true;
            // 
            // btn_Redo
            // 
            btn_Redo.Dock = DockStyle.Right;
            btn_Redo.FlatAppearance.BorderSize = 0;
            btn_Redo.FlatStyle = FlatStyle.Flat;
            btn_Redo.Image = Properties.Resources.icon_Redo_x24;
            btn_Redo.Location = new Point(339, 0);
            btn_Redo.Name = "btn_Redo";
            btn_Redo.Size = new Size(40, 48);
            btn_Redo.TabIndex = 5;
            btn_Redo.UseVisualStyleBackColor = true;
            // 
            // tbx_Title
            // 
            tbx_Title.BackColor = Color.White;
            tbx_Title.BorderStyle = BorderStyle.None;
            tbx_Title.Cursor = Cursors.IBeam;
            tbx_Title.Dock = DockStyle.Top;
            tbx_Title.Font = new Font("Tahoma", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Title.Location = new Point(527, 55);
            tbx_Title.Name = "tbx_Title";
            tbx_Title.ReadOnly = true;
            tbx_Title.Size = new Size(379, 54);
            tbx_Title.TabIndex = 7;
            tbx_Title.TextAlign = HorizontalAlignment.Center;
            tbx_Title.TextChanged += tbx_Title_TextChanged;
            tbx_Title.KeyPress += tbx_Title_KeyPress;
            // 
            // Panel_SeparatorRight
            // 
            Panel_SeparatorRight.BackColor = Color.White;
            Panel_SeparatorRight.Dock = DockStyle.Right;
            Panel_SeparatorRight.Location = new Point(906, 55);
            Panel_SeparatorRight.Name = "Panel_SeparatorRight";
            Panel_SeparatorRight.Size = new Size(33, 488);
            Panel_SeparatorRight.TabIndex = 6;
            Panel_SeparatorRight.Visible = false;
            // 
            // Panel_SeparatorLeft
            // 
            Panel_SeparatorLeft.BackColor = Color.WhiteSmoke;
            Panel_SeparatorLeft.Dock = DockStyle.Left;
            Panel_SeparatorLeft.Location = new Point(488, 55);
            Panel_SeparatorLeft.Name = "Panel_SeparatorLeft";
            Panel_SeparatorLeft.Size = new Size(39, 488);
            Panel_SeparatorLeft.TabIndex = 4;
            // 
            // Panel_NoteAndNotebooks
            // 
            Panel_NoteAndNotebooks.BackColor = Color.White;
            Panel_NoteAndNotebooks.Controls.Add(Panel_Notes);
            Panel_NoteAndNotebooks.Controls.Add(PanelGoldNotes);
            Panel_NoteAndNotebooks.Controls.Add(Panel_NoteBooks);
            Panel_NoteAndNotebooks.Controls.Add(Panel_GoldNoteBooks);
            Panel_NoteAndNotebooks.Dock = DockStyle.Left;
            Panel_NoteAndNotebooks.Location = new Point(54, 55);
            Panel_NoteAndNotebooks.Name = "Panel_NoteAndNotebooks";
            Panel_NoteAndNotebooks.Size = new Size(434, 488);
            Panel_NoteAndNotebooks.TabIndex = 2;
            // 
            // Panel_Notes
            // 
            Panel_Notes.Controls.Add(ls_Notes);
            Panel_Notes.Dock = DockStyle.Fill;
            Panel_Notes.Location = new Point(0, 343);
            Panel_Notes.Name = "Panel_Notes";
            Panel_Notes.Size = new Size(434, 145);
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
            ls_Notes.Size = new Size(434, 145);
            ls_Notes.TabIndex = 3;
            ls_Notes.DrawItem += ls_Notes_DrawItem;
            ls_Notes.SelectedIndexChanged += ls_Notes_SelectedIndexChanged;
            // 
            // PanelGoldNotes
            // 
            PanelGoldNotes.BackColor = Color.Gold;
            PanelGoldNotes.Controls.Add(btn_SortNotes);
            PanelGoldNotes.Controls.Add(lbl_GoldNotes);
            PanelGoldNotes.Controls.Add(btn_Delete);
            PanelGoldNotes.Dock = DockStyle.Top;
            PanelGoldNotes.Location = new Point(0, 288);
            PanelGoldNotes.Name = "PanelGoldNotes";
            PanelGoldNotes.Size = new Size(434, 55);
            PanelGoldNotes.TabIndex = 4;
            // 
            // btn_SortNotes
            // 
            btn_SortNotes.Dock = DockStyle.Right;
            btn_SortNotes.FlatAppearance.BorderSize = 0;
            btn_SortNotes.FlatStyle = FlatStyle.Flat;
            btn_SortNotes.Image = Properties.Resources.icon_Sort_x24;
            btn_SortNotes.Location = new Point(354, 0);
            btn_SortNotes.Name = "btn_SortNotes";
            btn_SortNotes.Size = new Size(40, 55);
            btn_SortNotes.TabIndex = 3;
            btn_SortNotes.UseVisualStyleBackColor = true;
            btn_SortNotes.Click += btn_SortNotes_Click;
            // 
            // lbl_GoldNotes
            // 
            lbl_GoldNotes.AutoSize = true;
            lbl_GoldNotes.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GoldNotes.Location = new Point(6, 15);
            lbl_GoldNotes.Name = "lbl_GoldNotes";
            lbl_GoldNotes.Size = new Size(83, 29);
            lbl_GoldNotes.TabIndex = 1;
            lbl_GoldNotes.Text = "Notes";
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Right;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Image = Properties.Resources.icon_Delete_x24;
            btn_Delete.Location = new Point(394, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(40, 55);
            btn_Delete.TabIndex = 1;
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Panel_NoteBooks
            // 
            Panel_NoteBooks.BackColor = Color.White;
            Panel_NoteBooks.Controls.Add(ls_NoteBooks);
            Panel_NoteBooks.Dock = DockStyle.Top;
            Panel_NoteBooks.Location = new Point(0, 55);
            Panel_NoteBooks.Name = "Panel_NoteBooks";
            Panel_NoteBooks.Size = new Size(434, 233);
            Panel_NoteBooks.TabIndex = 2;
            // 
            // ls_NoteBooks
            // 
            ls_NoteBooks.BackColor = Color.White;
            ls_NoteBooks.BorderStyle = BorderStyle.None;
            ls_NoteBooks.Dock = DockStyle.Fill;
            ls_NoteBooks.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ls_NoteBooks.ForeColor = Color.Black;
            ls_NoteBooks.FormattingEnabled = true;
            ls_NoteBooks.ItemHeight = 29;
            ls_NoteBooks.Location = new Point(0, 0);
            ls_NoteBooks.Name = "ls_NoteBooks";
            ls_NoteBooks.Size = new Size(434, 233);
            ls_NoteBooks.TabIndex = 0;
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
            Panel_GoldNoteBooks.Dock = DockStyle.Top;
            Panel_GoldNoteBooks.Location = new Point(0, 0);
            Panel_GoldNoteBooks.Name = "Panel_GoldNoteBooks";
            Panel_GoldNoteBooks.Size = new Size(434, 55);
            Panel_GoldNoteBooks.TabIndex = 5;
            // 
            // btn_RenameNoteBook
            // 
            btn_RenameNoteBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_RenameNoteBook.Dock = DockStyle.Right;
            btn_RenameNoteBook.FlatAppearance.BorderSize = 0;
            btn_RenameNoteBook.FlatStyle = FlatStyle.Flat;
            btn_RenameNoteBook.Image = Properties.Resources.icon_Edit_x24;
            btn_RenameNoteBook.Location = new Point(314, 0);
            btn_RenameNoteBook.Name = "btn_RenameNoteBook";
            btn_RenameNoteBook.Size = new Size(40, 55);
            btn_RenameNoteBook.TabIndex = 2;
            btn_RenameNoteBook.UseVisualStyleBackColor = true;
            btn_RenameNoteBook.Click += btn_RenameNoteBook_Click;
            // 
            // tbx_NameNotebook
            // 
            tbx_NameNotebook.BackColor = Color.Gold;
            tbx_NameNotebook.BorderStyle = BorderStyle.None;
            tbx_NameNotebook.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NameNotebook.Location = new Point(155, 13);
            tbx_NameNotebook.Name = "tbx_NameNotebook";
            tbx_NameNotebook.ReadOnly = true;
            tbx_NameNotebook.Size = new Size(153, 29);
            tbx_NameNotebook.TabIndex = 1;
            tbx_NameNotebook.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_SortNoteBooks
            // 
            btn_SortNoteBooks.Dock = DockStyle.Right;
            btn_SortNoteBooks.FlatAppearance.BorderSize = 0;
            btn_SortNoteBooks.FlatStyle = FlatStyle.Flat;
            btn_SortNoteBooks.Image = Properties.Resources.icon_Sort_x24;
            btn_SortNoteBooks.Location = new Point(354, 0);
            btn_SortNoteBooks.Name = "btn_SortNoteBooks";
            btn_SortNoteBooks.Size = new Size(40, 55);
            btn_SortNoteBooks.TabIndex = 1;
            btn_SortNoteBooks.UseVisualStyleBackColor = true;
            btn_SortNoteBooks.Click += btn_SortNoteBooks_Click;
            // 
            // lbl_GoldNoteBooks
            // 
            lbl_GoldNoteBooks.AutoSize = true;
            lbl_GoldNoteBooks.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GoldNoteBooks.ForeColor = Color.Black;
            lbl_GoldNoteBooks.Location = new Point(6, 13);
            lbl_GoldNoteBooks.Name = "lbl_GoldNoteBooks";
            lbl_GoldNoteBooks.Size = new Size(142, 29);
            lbl_GoldNoteBooks.TabIndex = 0;
            lbl_GoldNoteBooks.Text = "Notebooks";
            // 
            // btn_DeleteNoteBook
            // 
            btn_DeleteNoteBook.Dock = DockStyle.Right;
            btn_DeleteNoteBook.FlatAppearance.BorderSize = 0;
            btn_DeleteNoteBook.FlatStyle = FlatStyle.Flat;
            btn_DeleteNoteBook.Image = Properties.Resources.icon_Delete_x24;
            btn_DeleteNoteBook.Location = new Point(394, 0);
            btn_DeleteNoteBook.Name = "btn_DeleteNoteBook";
            btn_DeleteNoteBook.Size = new Size(40, 55);
            btn_DeleteNoteBook.TabIndex = 2;
            btn_DeleteNoteBook.UseVisualStyleBackColor = true;
            btn_DeleteNoteBook.Click += btn_DeleteNotebook_Click;
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.Gainsboro;
            Panel_Top.Controls.Add(tbx_Screach);
            Panel_Top.Dock = DockStyle.Top;
            Panel_Top.Location = new Point(54, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(885, 55);
            Panel_Top.TabIndex = 0;
            Panel_Top.Visible = false;
            // 
            // tbx_Screach
            // 
            tbx_Screach.BackColor = Color.WhiteSmoke;
            tbx_Screach.Location = new Point(17, 12);
            tbx_Screach.Name = "tbx_Screach";
            tbx_Screach.Size = new Size(338, 31);
            tbx_Screach.TabIndex = 2;
            // 
            // Panel_Right
            // 
            Panel_Right.BackColor = Color.Black;
            Panel_Right.Dock = DockStyle.Right;
            Panel_Right.Location = new Point(939, 0);
            Panel_Right.Name = "Panel_Right";
            Panel_Right.Size = new Size(40, 543);
            Panel_Right.TabIndex = 5;
            Panel_Right.Visible = false;
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
            Panel_Left.Dock = DockStyle.Left;
            Panel_Left.ForeColor = SystemColors.ControlLightLight;
            Panel_Left.Location = new Point(0, 0);
            Panel_Left.MaximumSize = new Size(184, 0);
            Panel_Left.MinimumSize = new Size(54, 0);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new Size(54, 543);
            Panel_Left.TabIndex = 1;
            // 
            // lbl_Change
            // 
            lbl_Change.AutoSize = true;
            lbl_Change.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Change.ForeColor = SystemColors.ButtonShadow;
            lbl_Change.Location = new Point(66, 120);
            lbl_Change.Name = "lbl_Change";
            lbl_Change.Size = new Size(92, 29);
            lbl_Change.TabIndex = 11;
            lbl_Change.Text = "Change";
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.ForeColor = SystemColors.ButtonShadow;
            lbl_Home.Location = new Point(66, 67);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(75, 29);
            lbl_Home.TabIndex = 10;
            lbl_Home.Text = "Home";
            // 
            // btn_ReOpenRoot
            // 
            btn_ReOpenRoot.FlatAppearance.BorderSize = 0;
            btn_ReOpenRoot.FlatStyle = FlatStyle.Flat;
            btn_ReOpenRoot.ForeColor = SystemColors.Desktop;
            btn_ReOpenRoot.Image = Properties.Resources.icon_Folder_x24;
            btn_ReOpenRoot.Location = new Point(3, 111);
            btn_ReOpenRoot.Name = "btn_ReOpenRoot";
            btn_ReOpenRoot.Size = new Size(48, 48);
            btn_ReOpenRoot.TabIndex = 9;
            btn_ReOpenRoot.UseVisualStyleBackColor = true;
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Menu.ForeColor = SystemColors.ButtonShadow;
            lbl_Menu.Location = new Point(66, 14);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(71, 29);
            lbl_Menu.TabIndex = 8;
            lbl_Menu.Text = "Menu";
            // 
            // btn_NoteBook
            // 
            btn_NoteBook.FlatAppearance.BorderSize = 0;
            btn_NoteBook.FlatStyle = FlatStyle.Flat;
            btn_NoteBook.ForeColor = SystemColors.Desktop;
            btn_NoteBook.Image = Properties.Resources.icon_Notebook_x24;
            btn_NoteBook.Location = new Point(3, 273);
            btn_NoteBook.Name = "btn_NoteBook";
            btn_NoteBook.Size = new Size(48, 48);
            btn_NoteBook.TabIndex = 2;
            btn_NoteBook.UseVisualStyleBackColor = true;
            btn_NoteBook.Visible = false;
            btn_NoteBook.Click += btn_NoteBook_Click;
            // 
            // btn_Note
            // 
            btn_Note.FlatAppearance.BorderSize = 0;
            btn_Note.FlatStyle = FlatStyle.Flat;
            btn_Note.ForeColor = SystemColors.Desktop;
            btn_Note.Image = Properties.Resources.icon_Note_x24;
            btn_Note.Location = new Point(3, 219);
            btn_Note.Name = "btn_Note";
            btn_Note.Size = new Size(48, 48);
            btn_Note.TabIndex = 0;
            btn_Note.UseVisualStyleBackColor = true;
            btn_Note.Visible = false;
            btn_Note.Click += btn_Note_Click;
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Note.ForeColor = SystemColors.ButtonShadow;
            lbl_Note.Location = new Point(66, 228);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(63, 29);
            lbl_Note.TabIndex = 7;
            lbl_Note.Text = "Note";
            lbl_Note.Visible = false;
            // 
            // lbl_NoteBook
            // 
            lbl_NoteBook.AutoSize = true;
            lbl_NoteBook.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NoteBook.ForeColor = SystemColors.ButtonShadow;
            lbl_NoteBook.Location = new Point(66, 282);
            lbl_NoteBook.Name = "lbl_NoteBook";
            lbl_NoteBook.Size = new Size(114, 29);
            lbl_NoteBook.TabIndex = 6;
            lbl_NoteBook.Text = "Notebook";
            lbl_NoteBook.Visible = false;
            // 
            // lbl_New
            // 
            lbl_New.AutoSize = true;
            lbl_New.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_New.ForeColor = SystemColors.ButtonShadow;
            lbl_New.Location = new Point(66, 175);
            lbl_New.Name = "lbl_New";
            lbl_New.Size = new Size(60, 29);
            lbl_New.TabIndex = 5;
            lbl_New.Text = "New";
            // 
            // btn_Expand
            // 
            btn_Expand.FlatAppearance.BorderSize = 0;
            btn_Expand.FlatStyle = FlatStyle.Flat;
            btn_Expand.Image = Properties.Resources.icon_Menu_x24;
            btn_Expand.Location = new Point(3, 3);
            btn_Expand.Name = "btn_Expand";
            btn_Expand.Size = new Size(48, 48);
            btn_Expand.TabIndex = 4;
            btn_Expand.UseVisualStyleBackColor = true;
            btn_Expand.Click += btn_Expand_Click;
            // 
            // btn_Home
            // 
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.ForeColor = SystemColors.Desktop;
            btn_Home.Image = Properties.Resources.icon_Home_x24;
            btn_Home.Location = new Point(3, 57);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(48, 48);
            btn_Home.TabIndex = 3;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // btn_New
            // 
            btn_New.FlatAppearance.BorderSize = 0;
            btn_New.FlatStyle = FlatStyle.Flat;
            btn_New.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_New.ForeColor = Color.Black;
            btn_New.Image = Properties.Resources.icon_New_x24;
            btn_New.Location = new Point(3, 165);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(48, 48);
            btn_New.TabIndex = 1;
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
            Panel_Welcome.Controls.Add(pic_Noty);
            Panel_Welcome.Dock = DockStyle.Fill;
            Panel_Welcome.Location = new Point(0, 0);
            Panel_Welcome.Name = "Panel_Welcome";
            Panel_Welcome.Size = new Size(979, 543);
            Panel_Welcome.TabIndex = 2;
            // 
            // lbl_By
            // 
            lbl_By.AutoSize = true;
            lbl_By.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_By.Location = new Point(841, 517);
            lbl_By.Name = "lbl_By";
            lbl_By.Size = new Size(124, 19);
            lbl_By.TabIndex = 4;
            lbl_By.Text = "By Francisco-vm";
            // 
            // lbl_SelectRoot
            // 
            lbl_SelectRoot.AutoSize = true;
            lbl_SelectRoot.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SelectRoot.Location = new Point(686, 180);
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
            btn_OpenRoot.Image = Properties.Resources.icon_FolderRoot_x64;
            btn_OpenRoot.Location = new Point(731, 210);
            btn_OpenRoot.Name = "btn_OpenRoot";
            btn_OpenRoot.Size = new Size(111, 98);
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
            lbl_Noty.Location = new Point(200, 358);
            lbl_Noty.Name = "lbl_Noty";
            lbl_Noty.Size = new Size(153, 72);
            lbl_Noty.TabIndex = 1;
            lbl_Noty.Text = "Noty";
            // 
            // pic_Noty
            // 
            pic_Noty.Image = Properties.Resources.Noty_notbg;
            pic_Noty.Location = new Point(157, 113);
            pic_Noty.Name = "pic_Noty";
            pic_Noty.Size = new Size(231, 230);
            pic_Noty.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Noty.TabIndex = 0;
            pic_Noty.TabStop = false;
            // 
            // Panel_LeftTimer
            // 
            Panel_LeftTimer.Interval = 16;
            Panel_LeftTimer.Tick += slidebarTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(979, 543);
            Controls.Add(Panel_Welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noty";
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
            Panel_Welcome.PerformLayout();
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
    }
}
