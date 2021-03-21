namespace tugas.Quiz.QuizDua
{
    public class Berat:Utilities
    {
        private double kilogram;
        public Berat(){
            kilogram = this.Input("Masukan berat dalam gram : ", IsDouble: true)/1000;
            Output(
                kilogram < 1  ? "Berat Benda Ringan" : 
                (kilogram >= 1 && kilogram <= 3) ? "Berat Benda Sedang" : 
                "Sangat berat Sekali"
            );
        }
    }
}