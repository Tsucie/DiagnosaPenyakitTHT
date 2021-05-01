using System.Collections.Generic;
using DiagnosaPenyakitTHT.Models;

namespace DiagnosaPenyakitTHT.db
{
    public class dbGejala
    {
        public List<Gejala> Gejala = new List<Gejala>();

        public dbGejala()
        {
            this.Gejala.Add(new Gejala { no = 1, name = "Demam", message = "Apakah Anda demam ?  " });
            this.Gejala.Add(new Gejala { no = 2, name = "Sakit kepala", message = "Apakah Anda merasa sakit kepala ?  " });
            this.Gejala.Add(new Gejala { no = 3, name = "Nyeri saat bicara atau menelan", message = "Apakah Anda merasa nyeri saat bicara atau menelan ?  " });
            this.Gejala.Add(new Gejala { no = 4, name = "Batuk", message = "Apakah Anda batuk ?  " });
            this.Gejala.Add(new Gejala { no = 5, name = "Hidung tersumbat", message = "Apakah hidung Anda tersumbat ?  " });
            this.Gejala.Add(new Gejala { no = 6, name = "Nyeri telinga", message = "Apakah telinga Anda terasa nyeri ?  " });
            this.Gejala.Add(new Gejala { no = 7, name = "Nyeri tenggorokan ", message = "Apakah tenggorokan Anda terasa nyeri ?  " });
            this.Gejala.Add(new Gejala { no = 8, name = "Hidung meler", message = "Apakah dari hidung Anda keluar cairan (meler) ?  " });
            this.Gejala.Add(new Gejala { no = 9, name = "Letih dan lesu", message = "Apakah Anda merasa letih dan lesu ?  " });
            this.Gejala.Add(new Gejala { no = 10, name = "Mual dan muntah", message = "Apakah Anda merasa mual dan ingin muntah ?  " });
            this.Gejala.Add(new Gejala { no = 11, name = "Selaput lendir merah & bengkak", message = "Apakah lendir merah dan telinga Anda bengkak ?  " });
            this.Gejala.Add(new Gejala { no = 12, name = "Ada benjolan di leher", message = "Apakah ada benjolan di leher ?  " });
            this.Gejala.Add(new Gejala { no = 13, name = "Nyeri leher", message = "Apakah merasakan nyeri di leher ?  " });
            this.Gejala.Add(new Gejala { no = 14, name = "Pembengkakan kelenjar getah bening", message = "Apakah ada pembengkakan di sekitar area bawah telinga ?  " });
            this.Gejala.Add(new Gejala { no = 15, name = "Pendarahan hidung", message = "Apakah Anda mengalami mimisan ?  " });
            this.Gejala.Add(new Gejala { no = 16, name = "Suara serak", message = "Apakah Anda Suara Anda serak ?  " });
            this.Gejala.Add(new Gejala { no = 17, name = "Bola mata bergerak tanpa sadar", message = "Apakah bola mata Anda suka bergerak tanpa disadari ?  " });
            this.Gejala.Add(new Gejala { no = 18, name = "Dahi sakit", message = "Apakah dahi Anda terasa sakit ?  " });
            this.Gejala.Add(new Gejala { no = 19, name = "Leher bengkak", message = "Apakah ada pembengkakan di sekitar leher ?  " });
            this.Gejala.Add(new Gejala { no = 20, name = "Tuli", message = "Apakah pendengaran Anda terasa terganggu ?  " });
            this.Gejala.Add(new Gejala { no = 21, name = "Ada yang tumbuh di mulut", message = "Apakah sesuatu yang tumbuh di mulut Anda ?  " });
            this.Gejala.Add(new Gejala { no = 22, name = "Air liur menetes", message = "Apakah ada air liur Anda sering menetes ?  " });
            this.Gejala.Add(new Gejala { no = 23, name = "Berat badan turun", message = "Apakah Anda mengalami penurunan berat badan ?  " });
            this.Gejala.Add(new Gejala { no = 24, name = "Bunyi nafas abnormal", message = "Apakah bunyi nafas Anda terasa tidak normal ?  " });
            this.Gejala.Add(new Gejala { no = 25, name = "Infeksi sinus", message = "Apakah mengalami infeksi pada hidung Anda ?  " });
            this.Gejala.Add(new Gejala { no = 26, name = "Nyeri antara mata", message = "Apakah Anda mengalami nyeri di sekitar mata ?  " });
            this.Gejala.Add(new Gejala { no = 27, name = "Nyeri pinggir hidung", message = "Apakah Anda mengalami nyeri di pinggir hidung ?  " });
            this.Gejala.Add(new Gejala { no = 28, name = "Nyeri pipi di bawah mata", message = "Apakah Anda mengalami nyeri di pipi bawah mata ?  " });
            this.Gejala.Add(new Gejala { no = 29, name = "Nyeri wajah", message = "Apakah Anda mengalami nyeri di sekitar wajah ?  " });
            this.Gejala.Add(new Gejala { no = 30, name = "Perubahan kulit", message = "Apakah Anda mengalami perubahan warna kulit di sekitar telinga ?  " });
            this.Gejala.Add(new Gejala { no = 31, name = "Perubahan suara", message = "Apakah Anda mengalami perubahan suara ?  " });
            this.Gejala.Add(new Gejala { no = 32, name = "Radang gendang telinga", message = "Apakah Anda merasakan sakit di dalam telinga ?  " });
            this.Gejala.Add(new Gejala { no = 33, name = "Sakit gigi", message = "Apakah Anda merasakan sakit gigi ?  " });
            this.Gejala.Add(new Gejala { no = 34, name = "Serangan vertigo", message = "Apakah Anda merasakan sangat pusing dan mempunyai riwayat darah rendah ?  " });
            this.Gejala.Add(new Gejala { no = 35, name = "Telinga berdenging", message = "Apakah Anda telinga Anda terasa berdengung ?  " });
            this.Gejala.Add(new Gejala { no = 36, name = "Telinga terasa penuh", message = "Apakah Anda telinga Anda terasa penuh seperti terisi sesuatu ?  " });
            this.Gejala.Add(new Gejala { no = 37, name = "Tenggorokan gatal", message = "Apakah Anda tenggorokan Anda terasa gatal ?  " });
            this.Gejala.Add(new Gejala { no = 38, name = "Tubuh tak seimbang", message = "Apakah tubuh Anda terasa tidak seimbang ?  " });
        }
    }
}