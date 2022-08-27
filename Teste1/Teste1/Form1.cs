using MySql.Data.MySqlClient;

namespace Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string mysqlcon = "server=localhost;user=root;database=testepx;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Sucesso, deu boa!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}