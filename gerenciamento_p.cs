using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projeto_integrado
{
    public partial class gerenciamento_p : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Thread th;

        public gerenciamento_p()
        {
            InitializeComponent();
            random = new Random();
            btn_fechar_forms_filho_p.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color EscolherCorTema()
        {
            int index = random.Next(CorTema.Cores.Count);
            while (tempIndex == index)
            {
                index = random.Next(CorTema.Cores.Count);
            }
            tempIndex = index;
            string color = CorTema.Cores[index];
            return ColorTranslator.FromHtml(color);
        }

        private void AtivarBotao(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DesabilitarBotao();
                    Color color = EscolherCorTema();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    painel_titulo_p.BackColor = color;
                    painel_logo_p.BackColor = CorTema.MudarLuminosidadeCores(color, -0.3);
                    CorTema.PrimaryColor = color;
                    CorTema.SecondaryColor = CorTema.MudarLuminosidadeCores(color, -0.3);
                    btn_fechar_forms_filho_p.Visible = true;
                }
            }
        }

        private void DesabilitarBotao()
        {
            foreach (Control previousBtn in painel_menu_lateral_p.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void AbrirFormFilho(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            AtivarBotao(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.painel_principal_p.Controls.Add(childForm);
            this.painel_principal_p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_titulo_p.Text = childForm.Text;
        }

        private void btn_principal_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Patrimônio(), sender);
            // conexao_api.AddRow("ListaPagamento", new List<object>() {"eu", "goosto", "muito", "dee", "vc" });
        }

        private void btn_produto_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Produto(), sender);
        }

        private void btn_fabricantes_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Fabricantes(), sender);
        }

        private void btn_fornecedor_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Fornecedor(), sender);
        }

        private void btn_setor_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Setor(), sender);
        }

        private void btn_grupo_de_bens_p_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms_p.Grupo_de_bens(), sender);
        }

        private void btn_fechar_forms_filho_p_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DesabilitarBotao();
            label_titulo_p.Text = "HOME";
            painel_titulo_p.BackColor = Color.FromArgb(0, 150, 136);
            painel_logo_p.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_fechar_forms_filho_p.Visible = false;
        }

        private void painel_titulo_p_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_fechar_p_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_p_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimizar_p_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void opengerenciarmembros(object obj)
        {
            Application.Run(new gerenciamento_m());
        }

        private void btn_gerenciarmembros_p_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opengerenciarmembros);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
