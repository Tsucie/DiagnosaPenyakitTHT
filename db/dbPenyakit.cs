using System.Collections.Generic;
using DiagnosaPenyakitTHT.Models;

namespace DiagnosaPenyakitTHT.db
{
    public class dbPenyakit
    {
        public List<Penyakit> Penyakit = new List<Penyakit>();

        public dbPenyakit()
        {
            this.Penyakit.Add(new Penyakit { name = "Contact Ulcers", cancer = false, sinus = false, no_gejala = new int[] { 3,16 } });
            this.Penyakit.Add(new Penyakit { name = "Abses Parafaringeal", cancer = false, sinus = false, no_gejala = new int[] { 3,19 } });
            this.Penyakit.Add(new Penyakit { name = "Abses Paritonsiler", cancer = false, sinus = false, no_gejala = new int[] { 1,2,7,14,16,22 } });
            this.Penyakit.Add(new Penyakit { name = "Barotitis Media", cancer = false, sinus = false, no_gejala = new int[] { 2,6, } });
            this.Penyakit.Add(new Penyakit { name = "Deviasi Septum", cancer = false, sinus = false, no_gejala = new int[] { 1,5,6,15,25,29 } });
            this.Penyakit.Add(new Penyakit { name = "Faringitis", cancer = false, sinus = false, no_gejala = new int[] { 1,3,7,13,14 } });
            this.Penyakit.Add(new Penyakit { name = "Laring", cancer = true, sinus = false, no_gejala = new int[] { 3,4,7,13,16,23,24 } });
            this.Penyakit.Add(new Penyakit { name = "Leher & Kepala", cancer = true, sinus = false, no_gejala = new int[] { 3,12,15,21,30,31 } });
            this.Penyakit.Add(new Penyakit { name = "Leher Metastatik", cancer = true, sinus = false, no_gejala = new int[] { 12 } });
            this.Penyakit.Add(new Penyakit { name = "Nasofaring", cancer = true, sinus = false, no_gejala = new int[] { 5,15 } });
            this.Penyakit.Add(new Penyakit { name = "Tonsil", cancer = true, sinus = false, no_gejala = new int[] { 7,12 } });
            this.Penyakit.Add(new Penyakit { name = "Laringitis", cancer = false, sinus = false, no_gejala = new int[] { 1,3,14,19,37 } });
            this.Penyakit.Add(new Penyakit { name = "Neuronitis Vestibularis", cancer = false, sinus = false, no_gejala = new int[] { 10,17 } });
            this.Penyakit.Add(new Penyakit { name = "Osteosklerosis", cancer = false, sinus = false, no_gejala = new int[] { 20,35 } });
            this.Penyakit.Add(new Penyakit { name = "Otitis Media Akut", cancer = false, sinus = false, no_gejala = new int[] { 1,6,10,32 } });
            this.Penyakit.Add(new Penyakit { name = "Meniere", cancer = false, sinus = false, no_gejala = new int[] { 6,10,34,36 } });
            this.Penyakit.Add(new Penyakit { name = "Tonsilitis", cancer = false, sinus = false, no_gejala = new int[] { 1,2,3,4,7,10 } });
            this.Penyakit.Add(new Penyakit { name = "Tumor Syaraf Pendengaran", cancer = false, sinus = false, no_gejala = new int[] { 2,20,38 } });
            this.Penyakit.Add(new Penyakit { name = "Vertigo Postular", cancer = false, sinus = false, no_gejala = new int[] { 17 } });
            this.Penyakit.Add(new Penyakit { name = "Maksilaris", cancer = false, sinus = true, no_gejala = new int[] { 1,2,4,5,8,9,11,28,33 } });
            this.Penyakit.Add(new Penyakit { name = "Frontalis", cancer = false, sinus = true, no_gejala = new int[] { 1,2,4,5,8,9,11,18 } });
            this.Penyakit.Add(new Penyakit { name = "Etmoidalis", cancer = false, sinus = true, no_gejala = new int[] { 1,2,4,5,8,9,11,18,26,27 } });
            this.Penyakit.Add(new Penyakit { name = "Sfenoidalis", cancer = false, sinus = true, no_gejala = new int[] { 1,2,4,5,8,9,11,13 } });
        }
    }
}