namespace Sem02_Ejemplo_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1 = int.Parse(txtPrimero.Text);
            num2 = int.Parse(txtSegundo.Text);
            num3 = int.Parse(txtTercero.Text);

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2 && num1 > num3)
                    txtMayor.Text = txtPrimero.Text;
                if (num2 > num1 && num2 > num3)
                    txtMayor.Text = txtSegundo.Text;
                if (num3 > num1 && num3 > num2)
                    txtMayor.Text = txtTercero.Text;
            }
            else
                txtMayor.Text = ("¡Error! Debe ingresar números diferentes entre sí");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimero.Clear();
            txtSegundo.Clear();
            txtTercero.Clear();
            txtMayor.Clear();
        }
    }
}