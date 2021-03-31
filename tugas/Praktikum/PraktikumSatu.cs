namespace tugas.Praktikum
{
    public class PraktikumSatu : Utilities
    {
        public void perulanganSatu(){
            for(int nilai = 1; nilai <= 10; nilai++){
                Output("\nbilangan : "+ nilai);
            }
        }

        public void perulanganDua(){
            for(int nilai = 1; nilai <= 10; nilai+=2){
                Output("\nbilangan : "+ nilai);
            }
        }

        public void perulanganTiga(){
            for(int nilai = 10; nilai >= 0; nilai--){
                Output("\nbilangan : "+ nilai);
            }
        }

        public void perulanganEmpat(){
            int bilangan = Input("Input Nilai : ", IsInt: true);
            for(int i = 3;  i <= bilangan; i++){
                Output("\nbilangan : "+ i);
            }
        }

        //Latihan
        public void modifPerulanganDua(){
            for(int i = 0; i < 10 ; i++)
              Output($"{((i<=1) ? i : (i<=5) ? i+=1 : i+= 3)} ");
        }

        public void perulanganKondisional(){
            int jumlahBilangan = 0, banyakBilangan = 0, bilangan =  this.Input("Jumlah bilangan yang akan di input : ", IsInt: true);

            while(bilangan >= banyakBilangan){
                jumlahBilangan += this.Input($"Input bilangan ke-{++banyakBilangan} : ", IsInt: true);

                if(bilangan == banyakBilangan){
                    this.Output($"\nJumlah {bilangan} yang telah diinputkan = {jumlahBilangan}");
                    this.Output($"\nRata-rata {bilangan} yang telah diinputkan = {jumlahBilangan/banyakBilangan}");
                    break;
                }
            }
        }
    }
}