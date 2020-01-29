using System.Globalization;

namespace Nota_Aluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3, NotaFinal;

        public double Notafinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (Notafinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 = Notafinal();
            }

        }

    }
}
