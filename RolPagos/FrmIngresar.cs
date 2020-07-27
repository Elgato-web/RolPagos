using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolPagos
{
    public partial class FrmIngresar : Form
    {
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RolPagos.Modelo.RolPagos carrera = new RolPagos.Modelo.RolPagos();
            int x = 0;
            try
            {
                carrera.codRol = txtClave.Text;
                carrera.nombreEmpleado = txtNombre.Text;
                carrera.totalIngresos = int.Parse(txtIngresos.Text);
                carrera.totalEgresos = int.Parse(txtEgresos.Text);
                carrera.departamento = txtDepartamento.Text;


                x = RolPagos.Modelo.RolPagosk.pagos(carrera);
                if (x > 0)
                {
                    MessageBox.Show("Datos Guardados");
                }
                else
                {
                    MessageBox.Show("Datos no Guardados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                DataTable dt = Modelo.RolPagosk.getAll();
                this.dataGrid.DataSource = dt;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "LinkEliminar")
            {
                int fila = e.RowIndex;
                string codigo = dataGrid[2, fila].Value.ToString();
                string confirmMessage = string.Format("¿Esta segur@ que quiere eliminar el codigo {0}?",
                    grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, " Eliminar Codigo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Codigo Eliminado Exitosamente");
                    grid.Rows.RemoveAt(fila);
                    

                }

            }
            if (grid.Columns[e.ColumnIndex].Name == "LinkModificar")
            {
                int fila = e.RowIndex;
                string codigo = dataGrid[2, fila].Value.ToString();
                string confirmMessage = string.Format("¿Esta segur@ que quiere modificar el codigo {0}?",
                    grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, " Modifcar Codigo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Modelo.RolPagos H = RolPagos.Modelo.RolPagosk.getpagos(codigo);
                    FrmModificar modificar = new FrmModificar(H);
                    modificar.ShowDialog();
                    DataTable dt = Modelo.RolPagosk.getAll();
                    this.dataGrid.DataSource = dt;

                }
            }

}