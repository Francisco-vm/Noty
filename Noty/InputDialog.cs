using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noty
{
    public class InputDialog : Form
    {
        private Panel Main;
        private Button btn_Cancel;
        private Button btn_Ok;
        private TextBox tbx_NewNameNotebook;
        private Label lbl_Title;
        

        public string UserInput => tbx_NewNameNotebook.Text;

        public InputDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Main = new Panel();
            btn_Cancel = new Button();
            btn_Ok = new Button();
            tbx_NewNameNotebook = new TextBox();
            lbl_Title = new Label();
            Main.SuspendLayout();
            SuspendLayout();
            // 
            // Main
            // 
            Main.BackColor = Color.White;
            Main.Controls.Add(btn_Cancel);
            Main.Controls.Add(btn_Ok);
            Main.Controls.Add(tbx_NewNameNotebook);
            Main.Controls.Add(lbl_Title);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 0);
            Main.Name = "Main";
            Main.Size = new Size(478, 194);
            Main.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.DimGray;
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(270, 131);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 34);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Ok
            // 
            btn_Ok.BackColor = Color.Gold;
            btn_Ok.DialogResult = DialogResult.OK;
            btn_Ok.FlatAppearance.BorderSize = 0;
            btn_Ok.FlatStyle = FlatStyle.Flat;
            btn_Ok.Location = new Point(92, 131);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(112, 34);
            btn_Ok.TabIndex = 2;
            btn_Ok.Text = "Acept";
            btn_Ok.UseVisualStyleBackColor = false;
            // 
            // tbx_NewNameNotebook
            // 
            tbx_NewNameNotebook.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NewNameNotebook.Location = new Point(92, 72);
            tbx_NewNameNotebook.Name = "tbx_NewNameNotebook";
            tbx_NewNameNotebook.Size = new Size(290, 36);
            tbx_NewNameNotebook.TabIndex = 1;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(173, 22);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(121, 29);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "New Title:";
            // 
            // InputDialog
            // 
            ClientSize = new Size(478, 194);
            Controls.Add(Main);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notebook";
            Main.ResumeLayout(false);
            Main.PerformLayout();
            ResumeLayout(false);
        }
    }
}
