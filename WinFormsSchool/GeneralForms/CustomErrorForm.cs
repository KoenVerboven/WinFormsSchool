using AppCode.BLL.GeneralClasses;
using WinFormsSchool.Base;


namespace WinFormsSchool.GeneralForms
{
    public partial class CustomErrorForm : BaseForm1
    {
        readonly CustomErrorClass _customErrorClass;

        public CustomErrorForm(CustomErrorClass customErrorClass)
        {
            InitializeComponent();
            _customErrorClass = customErrorClass;
            LabelPageTitle.Text = "Error";
            LabelErrorMessage.BackColor = Color.Red;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
        }

        private void SetLabelProperties(Color color, Font font)
        {
            foreach (var control in Controls)
            {
                if (control is Label labelEdit)
                {
                    labelEdit.ForeColor = color;
                    labelEdit.Font = font;
                }
            }
        }

        private void CustomErrorForm_Load(object sender, EventArgs e)
        {
            LabelErrorMessage.Text = _customErrorClass.ErrorMessage;
            LabelErrorTime.Text = _customErrorClass.ErrorOccurAtTime.ToString();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
