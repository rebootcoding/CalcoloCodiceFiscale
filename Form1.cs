using System.Drawing.Drawing2D;
using System.IO;

namespace CalcoloCodiceFiscale
{
    public partial class Form1 : Form
    {
        public const string path = "C:\\Users\\michele.f.meloni\\source\\repos\\CalcoloCodiceFiscale\\ElencoComuni.csv";
        //public List<Comune> ListaComuni = new List<Comune>();
        public Form1()
        {
            InitializeComponent();

            var listaComuni = new List<Comune>();
            var allLines = File.ReadAllLines(path);
            foreach (var linea in allLines)
            {
                var split = linea.Split(",");
                listaComuni.Add(new Comune(split[0], split[1]));
            }
            cbx_comune_nascita.DataSource = listaComuni;
            cbx_comune_nascita.DisplayMember = "Nome";

            //using (var sr = new StreamReader(path))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        var linea = sr.ReadLine().Split(",").ToList();
            //        var comune = linea[0];
            //        var codComune = linea[1];
            //        var completo = new Comune(comune, codComune);
            //        cbx_comune_nascita.Items.Add(completo);
            //        cbx_comune_nascita.DisplayMember = "Nome";


            //    }
            //}
        }


        private void btn_codice_fiscale_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = tbx_cognome.Text;
            var dataNascita = tpk_data_nascita.Value;
            var comuneNascita = (Comune)cbx_comune_nascita.SelectedItem;
            var sex = btn_femmina.Checked ? "F" : "M";

            var calculator = new Tecnosoftware.CodiceFiscale.CodiceFiscale(cognome, nome, dataNascita,comuneNascita.Codice,sex);
            MessageBox.Show(calculator.estraiCF());


            //var sesso = gbx_Sesso.Text;
            //var codNome;
            //var codCognome;
            //var giornoNascita;
            //var meseNascita;
            //var annoNascita;
            //var comuneNascita;
        }
    }
}