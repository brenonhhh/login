using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace login
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }
        // METODOS
        public void Cls()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtTel.Clear();
            txtIdade.Clear();
            dtpAgenda.Value = DateTime.Now;
            cbxMedico.SelectedIndex = -1;
            txtCod.Focus();

        }

        string X = "";

        
        
        private void INICIO_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            

            AcessoBanco acesso = new AcessoBanco();
            dgvPaciente.DataSource = acesso.CarregarDados();
            DataTable dt = new DataTable();
            dt = acesso.carregaMedico();

            foreach (DataRow item in dt.Rows)
            {
                cbxMedico.Items.Add(item[0]);
            }
            
            


        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            
            
            Consulta consulta = new Consulta();
            consulta.codpac = Convert.ToInt32(txtCod.Text);
            consulta.nome = txtNome.Text;
            consulta.telefone = txtTel.Text;
            consulta.idade = Convert.ToInt32(txtIdade.Text);
            consulta.dia = dtpAgenda.Value;
            consulta.medico = cbxMedico.Text;
            AcessoBanco acesso = new AcessoBanco();
            acesso.Agendar(consulta);
            
            dgvPaciente.DataSource = acesso.CarregarDados();
            dgvPaciente.Update();

           
        }
        private void dgvPaciente_SelectionChanged(object sender, EventArgs e)
        {
            int indiceLinha;

            indiceLinha = dgvPaciente.CurrentRow.Index;

            txtCod.Text = dgvPaciente[0, indiceLinha].Value.ToString();
            txtNome.Text = dgvPaciente[1, indiceLinha].Value.ToString();
            txtTel.Text = dgvPaciente[2, indiceLinha].Value.ToString();
            txtIdade.Text= dgvPaciente[3, indiceLinha].Value.ToString();
            cbxMedico.Text = dgvPaciente[4, indiceLinha].Value.ToString();
            dtpAgenda.Text = dgvPaciente[5, indiceLinha].Value.ToString();




        }

        private void BtnRemarcar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            AcessoBanco acesso = new AcessoBanco();
            consulta.dia = dtpRemarcar.Value;
            acesso.Remarcar(consulta);
            dgvPaciente.DataSource = acesso.CarregarDados();
            dgvPaciente.Update();
            
        }

        private void BtnPesqN_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            AcessoBanco acesso = new AcessoBanco();
            consulta.codpac =Convert.ToInt32( txtPesqNum.Text);
            dgvPaciente.DataSource = acesso.PesqPorCod(consulta.codpac);
            dgvPaciente.Update();


        }

        private void TxtPesqNome_TextChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.nome = txtPesqNome.Text;
            AcessoBanco acesso = new AcessoBanco();
            acesso.PesqNome(consulta);
            dgvPaciente.DataSource = acesso.PesqNome(consulta);
        }
    }
}
