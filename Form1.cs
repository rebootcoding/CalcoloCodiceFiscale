using System.Drawing.Drawing2D;
using System.IO;

namespace CalcoloCodiceFiscale
{
    public partial class Form1 : Form
    {
        public const string path = "C:\\Users\\michele.f.meloni\\source\\repos\\CalcoloCodiceFiscale\\ElencoComuni.csv";
        public List<Comune> ListaComuni = new List<Comune>();
        public Form1()
        {
            InitializeComponent();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var linea = sr.ReadLine().Split(",").ToList();
                    var comune = linea[0];
                    var codComune = linea[1];
                    var completo = new Comune(comune, codComune);

                    cbx_comune_nascita.Items.Add(completo);
                    cbx_comune_nascita.DisplayMember = "comune";


                }
            }
        }


        private void btn_codice_fiscale_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = tbx_cognome.Text;
            var dataNascita = tpk_data_nascita.Text;
            var comuneNascita = cbx_comune_nascita.SelectedItem;
            var sesso = gbx_Sesso.Text;
            //var codNome;
            //var codCognome;
            //var giornoNascita;
            //var meseNascita;
            //var annoNascita;
            //var comuneNascita;
        }
    }
}