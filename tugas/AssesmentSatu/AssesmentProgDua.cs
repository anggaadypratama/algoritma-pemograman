using System;

namespace tugas.AssesmentSatu{
    class AssesmentProgDua : Utilities{
        private Tuple<double, string> LuasLingkaran(){
            this.Output("Kamu Memilih Luas Lingkaran \n");
            double jariJari = this.Input("Masukan Jari-Jari", IsDouble: true);
            return Tuple.Create(Math.Round(Math.PI * Math.Pow(jariJari, 2 ), 2), "Lingkaran");
         }

        private Tuple<double, string> LuasPersegiPanjang(){
            this.Output("Kamu Memilih Luas Persegi Panjang \n");
            double panjang = this.Input("Masukan Panjang : ", IsDouble: true), lebar = this.Input("Masukan Lebar : ", IsDouble: true);
            return Tuple.Create(panjang * lebar, "Persegi Panjang");
         }

         private Tuple<double, string> LuasSegitiga(){
             this.Output("Kamu Memilih Luas Segitiga \n");
             double alas = this.Input("Masukan alas : ", IsDouble: true), tinggi = this.Input("Masukan tinggi : ", IsDouble: true);
             return Tuple.Create(Math.Round(0.5 * alas * tinggi), "Segitiga");
         }

         public void HitungLuas(){
             this.Output(" 1. Hitung Luas Lingkaran \n 2. Hitung Luas persegi panjang \n 3. Hitung luas segitiga");
             double inputmenu = this.Input("Pilih menu (1/2/3) : ", IsDouble: true);
             dynamic hasil =    (inputmenu == 1) ? LuasLingkaran() :
                                (inputmenu == 2) ? LuasPersegiPanjang() :
                                (inputmenu == 3) ? LuasSegitiga() :
                                "Tidak ada menu yang dimaksud";

            Output((inputmenu >= 1 && inputmenu <= 3 ? ($"Luas {hasil!.Item2} adalah  : {hasil!.Item1}"): hasil));
         }
    }
}