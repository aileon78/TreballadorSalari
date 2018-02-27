using System;
using System.Windows.Forms;
using TreballadorSalari.Clases;

namespace TreballadorSalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            TBNom.Text = "";
            CBSexo.Text = "";
            TBSalario.Text = "";

        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            //declaramos la variables para ir recogiendo los datos
            String nom;
            char sexo;
            double salario;

            //recogemos los datos
            nom = TBNom.Text;
            sexo = Convert.ToChar(CBSexo.Text);
            salario = Convert.ToDouble(TBSalario.Text);

            //creamos objeto para guardar los datos
            Trabajador tra = new Trabajador(nom, sexo, salario);

            //le decimos a nuestro "tra" que guarde los datos en un fichero
            //de tipo trabajador utilizandola funcion escriuobjecfitxerObjectStream
            tra.escriuObjecteFitxerObjecteStream(tra);

            limpiarCampos();






        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {
            //recogeremos el vector de objetos
            Trabajador[] tra = new Trabajador[100];

            //Creamos el objeto donde recogeremos los datos
            Trabajador t = new Trabajador();

            //extraemos los datos
            tra = t.llegeixObjecteFitxer();

            //finalmente mostramos los datos
            mostrarDatos(tra);

        }

        private void mostrarDatos(Trabajador[] tra)
        {
            RTB1.Text = "";
            int maxVec = contarVector(tra);
            int i;
            for (i = 0; i < maxVec; i++)
            {
                RTB1.Text = RTB1.Text + "Nombre : " + tra[i].Nom + "\n" +
                    "Sexo : " + tra[i].Sexe + "\n" +
                    "Salario : " + tra[i].Salari + "\n\n";

            }
        }




        //contamos los objetos qu hay en el vector
        private int contarVector(Object[] obj)
        {
            int i = 0;
            do
            {
                if (obj[i] != null)
                {
                    i++;
                }
                else
                {
                    return i;
                }


            } while (i < obj.Length);



            return i;
        }


        private void CalculoSa(Trabajador[] tra)
        {
            RTB1.Text = "";
            int maxVec = contarVector(tra);
            int i = 0;

            int masgrande=0;

           
            for (i = 0; i < maxVec; i++)
            {

                if (tra[i].Salari > masgrande)
                {

                    masgrande = i;






                }
                else { }

            }
            RTB1.Text = RTB1.Text + "Nombre : " + tra[masgrande].Nom + "\n" +
                                                      "Sexo : " + tra[masgrande].Sexe + "\n" +
                                                      "Salario : " + tra[masgrande].Salari + "\n\n";



        }

        //private void mostraSalariMasGrande(Trabajador t)
        //{
        //    int masgrande = 0;

        //    for (int i = 0; i < length; i++)
        //    {

        //    }

        //    RTB1.Text = RTB1.Text + "Nombre : " + t[masgrande].Nom + "\n" +
        //                                               "Sexo : " + t[masgrande].Sexe + "\n" +
        //                                               "Salario : " + t[masgrande].Salari + "\n\n";




        //}

        private void BTCalcSal_Click(object sender, EventArgs e)
        {
            Trabajador[] tra = new Trabajador[0];
            Trabajador t = new Trabajador();

           

            tra = t.llegeixObjecteFitxer();


            CalculoSa(tra);





            // recogeremos el vector de objetos
            // Trabajador[] tra = new Trabajador[100];

            //Creamos el objeto donde recogeremos los datos
            //Trabajador t = new Trabajador();

            //extraemos los datos
            //tra = t.llegeixObjecteFitxer();

            //finalmente mostramos los datos
            //mostrarDatos(tra);



        }
    }
}
