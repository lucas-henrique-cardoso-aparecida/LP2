using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482021009
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Form aberto = new Form();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
               // String de conexão da sua máquina
                conexao = new SqlConnection("Data Source=DESKTOP-70GGNNK\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro banco de dados" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros tipos de erro" + ex.Message);
            }
        }

        private void cadastroDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aberto != null)
                aberto.Close();

            frmVacina FrmVacina = new frmVacina();
            FrmVacina.MdiParent = this; // componente atual no caso o frmPrincipal
            FrmVacina.WindowState = FormWindowState.Maximized;
            aberto = FrmVacina;
            FrmVacina.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aberto != null)
                aberto.Close();

            frmSobre FrmSobre = new frmSobre();
            FrmSobre.MdiParent = this; // componente atual no caso o frmPrincipal
            FrmSobre.WindowState = FormWindowState.Maximized;
            aberto = FrmSobre;
            FrmSobre.Show();
        }
    }
}
