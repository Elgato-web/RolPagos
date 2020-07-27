using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolPagos.Modelo
{
    public partial class FrmModificar : Form
    {
        public FrmModificar(Modelo.RolPagos car)
        {
            InitializeComponent();
            txtClave.Text = car.codRol;
            txtNombre.Text = car.nombreEmpleado;
            txtDepartamento.Text = car.departamento;
            txtIngresos.Text = car.totalIngresos.ToString();
            txtEgresos.Text = car.totalEgresos.ToString();



        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            {
                RolPagos.Modelo.RolPagos car  = new Modelo.RolPagos();
                car.codRol = txtClave.Text;
                car.nombreEmpleado = txtNombre.Text;
                car.totalIngresos = int.Parse(txtIngresos.Text);
                car.totalEgresos = int.Parse(txtEgresos.Text);
                car.departamento = txtDepartamento.Text;
                x = RolPagos.Modelo.RolPagosk.update(car);
                if (x > 0)
                    MessageBox.Show("Actualizacion Copmpletada");
                else
                    MessageBox.Show("No se pudo acutalizar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                this.Close();
            }
        }
    }
}