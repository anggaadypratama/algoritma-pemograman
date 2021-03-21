namespace tugas.Quiz.QuizDua
{
    public class NilaiMatkul : Utilities
    {
        private string[] matKul = {"Agama", "AlPro" , "MatDis"};
        private int[] nilai = new int[3];
        private int MatKulKe = 0, averageMatkul = 0, totalNilai = 0, input;

        public NilaiMatkul(){
            while(true){
                input = Input($"Nilai Mata Kuliah {matKul[MatKulKe++]} : ", IsInt: true);

                if(input >= 0 && input <= 100) nilai[MatKulKe - 1] = input;
                else {
                    Output("Nilai Tidak Valid");
                    break;
                }

                if(MatKulKe == matKul.Length){
                    for(int i = 0; i < matKul.Length; i++ ) totalNilai += nilai[i];
                    averageMatkul = totalNilai/matKul.Length;
                    Output($"{(averageMatkul > 60 && nilai[0] > 60 ? "lulus" : "tidak lulus") }");
                    break;
                }
            }
        }
    }
}