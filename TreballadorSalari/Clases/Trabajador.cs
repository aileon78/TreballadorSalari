using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreballadorSalari.Clases
{

    [Serializable]
    class Trabajador
    {
        //variables
        private String nom;
        private char sexe;
        private double salari;



        //constructores
        public Trabajador()
        {
        }

        public Trabajador(string nom, char sexe, double salari)
        {
            this.Nom = nom;
            this.Sexe = sexe;
            this.Salari = salari;
        }

        //metodos
        public string Nom { get => nom; set => nom = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public double Salari { get => salari; set => salari = value; }


        //ESCRIBIREMOS EL OBJETO DENTRO DE UN FICHERO
        public void escriuObjecteFitxerObjecteStream(Trabajador tra, String fitxer = "fitxer/trabajadores.dat", bool afegri = true)
        {

            Stream str = File.Open(fitxer, FileMode.Append);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, tra);
            str.Close();

        }


        //LEEREMOS ELOBJETO DESDE EL FICEHRO
        public Trabajador[] llegeixObjecteFitxer(String arxiu = "fitxer/trabajadores.dat")
        {
            //LEEMOS

            Stream str = File.Open(arxiu, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int i = 0;
            Trabajador[] tra = new Trabajador[100];

            do
            {
                try
                {
                    tra[i] = (Trabajador)formatter.Deserialize(str);
                }
                catch
                {
                    //Message....
                }
                i++;

            } while (tra[i-1] != null);
            str.Close();
            return tra;

        }



    }
}
