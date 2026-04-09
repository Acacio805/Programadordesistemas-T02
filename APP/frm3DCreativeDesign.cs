using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace APP
{
    public partial class frm3DCreativeDesign : Form
    {

        public frm3DCreativeDesign()
        {
            InitializeComponent();

            panelLeftWhite.Size = new System.Drawing.Size(2, 691);

            this.DoubleBuffered = true;
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            // Force the form to redraw its background
            this.Invalidate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFormulario novoForm = new frmFormulario();
            novoForm.Show();
        }


        private void btnTrash_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmPedido novoForm = new frmPedido();
            novoForm.Show();
        }
    }
}
