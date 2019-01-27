using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TallerGitP1
{
    class Informacion
    {

        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;
        private string p8;
        private int cantidad;

        public Informacion()
        {
            this.p1 = "";
            this.p2 = "";
            this.p3 = "";
            this.p4 = "";
            this.p5 = "";
            this.p6 = "";
            this.p7 = "";
            this.p8 = "";
            this.cantidad = 0;
        }

        public string P1 { get => p1; set => p1 = value; }
        public string P2 { get => p2; set => p2 = value; }
        public string P3 { get => p3; set => p3 = value; }
        public string P4 { get => p4; set => p4 = value; }
        public string P5 { get => p5; set => p5 = value; }
        public string P6 { get => p6; set => p6 = value; }
        public string P7 { get => p7; set => p7 = value; }
        public string P8 { get => p8; set => p8 = value; }


        public void escritura() {

            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\txt\\ejemplo"+cantidad+".txt", true);
                
                sw.WriteLine(P1);
                sw.WriteLine(P2);
                sw.WriteLine(P3);
                sw.WriteLine(P4);
                sw.WriteLine(P5);
                sw.WriteLine(P6);
                sw.WriteLine(P7);
                sw.WriteLine(P8);

                cantidad += 1;
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
