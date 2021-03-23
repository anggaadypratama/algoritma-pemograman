namespace tugas.Quiz.QuizDua
{
    public class Bulan : Utilities
    {
        public Bulan(){
            int bulan = Input("Masukan Bulan Ke Berapa : ", IsInt: true);
            string hasil = bulan switch {
                1 => "Januari",
                2 => "Februari",
                3 => "Maret",
                4 => "April",
                5 => "Mei",
                6 => "Juni",
                7 => "Juli",
                8 => "Agustus",
                9 => "September",
                10 => "Oktober",
                11 => "November",
                12 => "Desember",
                _ => "Tersebut tidak ada"
            };
            Output($"bulan ke-{bulan} adalah bulan {hasil}");
        }
    }
}