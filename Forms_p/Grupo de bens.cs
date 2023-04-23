﻿using projeto_integrado.Forms_p_inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms_p
{
    public partial class Grupo_de_bens : Form
    {
        public Grupo_de_bens()
        {
            InitializeComponent();
        }

        private void Grupo_de_bens_Load(object sender, EventArgs e)
        {
            CarregarTema();
        }

        private void CarregarTema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = CorTema.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = CorTema.SecondaryColor;
                }
            }
        }

        private void btn_adicionar_grupo_de_bens_p_Click(object sender, EventArgs e)
        {
            var forminputgrupobens = new grupodebens_inputs();
            forminputgrupobens.Show();
        }
    }
}