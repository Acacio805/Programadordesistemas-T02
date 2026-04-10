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

        public void NovoPedido(object sender, EventArgs e)
        {
            Panel pedidoPanel = new Panel()
            {
                Size = new Size(361, 111),
                BackColor = SystemColors.Control,
            };

            System.Windows.Forms.TextBox txtPedido1 = new System.Windows.Forms.TextBox()
            {
                BackColor = SystemColors.Control,
                Size = new Size(353, 23),
                Location = new System.Drawing.Point(3, 12),
                ReadOnly = true
            };

            System.Windows.Forms.TextBox txtPedido2 = new System.Windows.Forms.TextBox()
            {
                BackColor = SystemColors.Control,
                Size = new Size(353, 23),
                Location = new System.Drawing.Point(3, 41),
                ReadOnly = true
            };

            System.Windows.Forms.Button btnAceitar = new System.Windows.Forms.Button()
            {
                BackColor= Color.DarkGreen,
                Size = new Size(75, 27),
                Location = new System.Drawing.Point(119, 73),
            };

            System.Windows.Forms.Button btnRejeitar = new System.Windows.Forms.Button()
            {
                BackColor = Color.DarkRed ,
                Size = new Size(75, 27),
                Location = new System.Drawing.Point(281, 73),
            };

            System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
            {
                BackColor = SystemColors.ControlDark,
                Size = new Size(75, 27),
                Location = new System.Drawing.Point(200, 73),
            };

            pedidoPanel.Controls.Add(txtPedido1);
            pedidoPanel.Controls.Add(txtPedido2);
            pedidoPanel.Controls.Add(btnAceitar);
            pedidoPanel.Controls.Add(btnRejeitar);
            pedidoPanel.Controls.Add(btnInfo);
            flpanelPedidosNovos.Controls.Add(pedidoPanel);
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

        private void butaoTeste_Click(object sender, EventArgs e)
        {
            NovoPedido(sender, e);
        }
    }
}
