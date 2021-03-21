namespace tugas.Quiz.QuizSatu{
    public class Aritmatika:Utilities{

        private int nilaiPertama, nilaiKedua;
        private string kondisi;

        public Aritmatika(){
            this.nilaiPertama = this.Input("Masukan Nilai Pertama : ", IsInt: true);
            this.nilaiKedua = this.Input("Masukan Nilai Kedua : ", IsInt: true);
            this.kondisi = this.Input("Masukan kondisi aritmatika (tambah, kurang , bagi ,kali) : ").ToLower();
        }

        public void hitungAritmatika(){
            string result = this.kondisi switch
            {
                "tambah"     => $"{nilaiPertama+nilaiKedua}",
                "kurang"     => $"{nilaiPertama-nilaiKedua}",
                "bagi" => $"{nilaiPertama/nilaiKedua}",
                "kali" => $"{nilaiPertama*nilaiKedua}",
                _ => "tidak ada kondisi yang dimaksud"
            };
            Output($"Hasil dari {this.nilaiPertama} Di{this.kondisi} {this.nilaiKedua} adalah {result}");
        }
    }
}