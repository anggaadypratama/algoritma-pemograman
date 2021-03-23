namespace tugas.Quiz.QuizDua
{
    class Berat: Utilities
    {
        public Berat(){
            double kilogram = this.Input("Masukan berat dalam gram : ", IsDouble: true)/1000;
            Output(kilogram < 1  ? "Berat Benda Ringan" : (kilogram >= 1 && kilogram <= 3) ? "Berat Benda Sedang" : "Sangat berat Sekali");
        }
    }
}