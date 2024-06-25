namespace frmLibroDiario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddTextBoxes();
        }

        private void AddTextBoxes()
        {
            TextBox txtCuenta = new TextBox();
            txtCuenta.Location = new Point(620, 80);
            txtCuenta.Size = new Size(160, 20);
            this.Controls.Add(txtCuenta);

            TextBox txtCuentaHaber = new TextBox();
            txtCuentaHaber.Location = new Point(820, 100);
            txtCuentaHaber.Size = new Size(160, 20);
            this.Controls.Add(txtCuentaHaber);

            ComboBox comboBxCuentaDebe = new ComboBox();
            comboBxCuentaDebe.Location = new Point(70, 80);
            comboBxCuentaDebe.Size = new Size(160, 20);
            this.Controls.Add(comboBxCuentaDebe);

            comboBxCuentaDebe.Items.Add("Caja");
            comboBxCuentaDebe.Items.Add("Opción 2");
            comboBxCuentaDebe.Items.Add("Opción 3");

            ComboBox comboBxCuentaHaber = new ComboBox();
            comboBxCuentaHaber.Location = new Point(600 - 160 - 20, 80 + 20);
            comboBxCuentaHaber.Size = new Size(160, 20);
            this.Controls.Add(comboBxCuentaHaber);

            comboBxCuentaHaber.Items.Add("Caja");
            comboBxCuentaHaber.Items.Add("Opción 2");
            comboBxCuentaHaber.Items.Add("Opción 3");

            // Lista de opciones para agregar al ComboBox
            /*string[] opciones = { "Opción A", "Opción B", "Opción C" };*/

            // Agregar elementos al ComboBox usando AddRange
            /*comboBox.Items.AddRange(opciones);*/
        }
    }
}
