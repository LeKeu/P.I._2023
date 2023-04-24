using projeto_integrado.Classes;
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
    public partial class gerenciamento_m : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Thread th;

        //Constructor
        public gerenciamento_m()
        {
            InitializeComponent();
            random = new Random();
            btn_fechar_forms_filho_m.Visible = false;
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
                    painel_titulo.BackColor = color;
                    painel_logo.BackColor = CorTema.MudarLuminosidadeCores(color, -0.3);
                    CorTema.PrimaryColor = color;
                    CorTema.SecondaryColor = CorTema.MudarLuminosidadeCores(color, -0.3);
                    btn_fechar_forms_filho_m.Visible = true;
                }
            }
        }

        private void DesabilitarBotao()
        {
            foreach (Control previousBtn in menu_lateral.Controls)
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
            this.painel_principal_m.Controls.Add(childForm);
            this.painel_principal_m.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_titulo_m.Text = childForm.Text;
        }

        private void principal_m_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms.Membros(), sender);
            // conexao_api.AddRow("ListaPagamento", new List<object>() {"eu", "goosto", "muito", "dee", "vc" });
        }

        private void dependente_m_Click(object sender, EventArgs e)
        {
           AbrirFormFilho(new Forms.Dependentes(), sender);
        }

        private void pagamento_m_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Forms.Pagamentos(), sender);
        }

        private void btn_fechar_forms_filho_m_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DesabilitarBotao();
            label_titulo_m.Text = "HOME";
            painel_titulo.BackColor = Color.FromArgb(0, 150, 136);
            painel_logo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_fechar_forms_filho_m.Visible = false;
        }

        private void painel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_fechar_m_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_m_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimizar_m_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void opengerenciarpatrimonio(object obj)
        {
            Application.Run(new gerenciamento_p());
        }

        private void btn_gerenciarpatrimonio_m_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opengerenciarpatrimonio);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
