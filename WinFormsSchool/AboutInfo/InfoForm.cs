
namespace WinFormsSchool
{
    public partial class InfoForm : Base.BaseForm1
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            textBoxInfo.Multiline = true;
            textBoxInfo.IsAccessible  = false;
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Text += Environment.NewLine;
            textBoxInfo.Text = "This program is NOT meant as a fully functional program that can be used for schooladministration." + Environment.NewLine;
            textBoxInfo.Text += "It is meant for education reason only." + Environment.NewLine + Environment.NewLine;
            textBoxInfo.Text += "C# FOR BEGINNERS!" + Environment.NewLine + Environment.NewLine;
            textBoxInfo.Text += "Advantages from this program : you need no database or a webserver" + Environment.NewLine;
            textBoxInfo.Text += "We concentrate us only on C# and winforms" + Environment.NewLine;
            textBoxInfo.Text += "Database connection can added later on." + Environment.NewLine + Environment.NewLine;
            textBoxInfo.Text += "It is for a beginner programmer who want to learn following things:" + Environment.NewLine;
            textBoxInfo.Text += "-> C#" + Environment.NewLine;
            textBoxInfo.Text += "-> Object Oriënted programming : classes, interfaces, inheritance"+ Environment.NewLine;
            textBoxInfo.Text += "-> WinForms : forms, datagrid, menu, open new detailscreens " + Environment.NewLine;
            textBoxInfo.Text += Environment.NewLine ;
            textBoxInfo.Text += "For more information go to the files in the Info folder from the project.";//Todo link maken naar deze files?
            textBoxInfo.SelectionStart = 0;
            textBoxInfo.SelectionLength = 0;
            textBoxInfo.Dock = DockStyle.None;
            textBoxInfo.ForeColor = Color.White;
            textBoxInfo.BackColor = Color.FromArgb(66, 66, 66);
            textBoxInfo.Font = new Font("Helvetica", 10);
            textBoxInfo.BorderStyle = BorderStyle.None;
            LabelPageTitle.Text = "Info";
        }
    }
}
