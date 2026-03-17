using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace APP
{
    public partial class frm3DCreativeDesign : Form
    {
        Excel.Application app = new Excel.Application();
        Workbook pasta;
        Worksheet plan;
        string path = @"C:\Users\acacio.sribeiro1\OneDrive - SENAC - SP\DATABASE.xlsx"; //C:\Users\acacio.sribeiro1\OneDrive - SENAC - SP\DATABASE.xlsx

        public frm3DCreativeDesign()
        {
            InitializeComponent();
            pasta = app.Workbooks.Open(path);
            plan = pasta.Worksheets["plan"];

            txtNome.Text = plan.Cells[3, 6].Value.ToString();
            txtTipo.Text = plan.Cells[3, 7].Value.ToString();
        }

        private void frm3DCreativeDesign_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            app.Quit();
        }
    }
}
