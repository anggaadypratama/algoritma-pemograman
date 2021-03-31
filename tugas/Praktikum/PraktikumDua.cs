using System;

namespace tugas.Praktikum
{
    public class PraktikumDua : Utilities
    {
        void perulanganSatu(){
            for(int nilai = 1; nilai <= 10; nilai++){
                Output("\nbilangan "+ nilai);
            }
        }

        void perulanganDua(){
            for(int nilai = 1; nilai <= 10; nilai+=2){
                Output("\nbilangan "+ nilai);
            }
        }

        void perulanganTiga(){
            for(int nilai = 10; nilai >= 0; nilai--){
                Output("\nbilangan "+ nilai);
            }
        }

        void perulanganEmpat(){
            int bilangan = Input("Input Nilai", IsInt: true);
            for(int i = 3;  i <= bilangan; i++){
                Output("\nbilangan "+ i);
            }
        }

        //Latihan
        void modifPerulanganDua(){
            for(int i = 0; i < 10 ; i++)
              Console.WriteLine((i<=1) ? i : (i<=5) ? i+=1 : i+= 3);
        }

        void perulanganKondisional(){
            int jumlahBilangan = 0, banyakBilangan = 0,bilangan = 0;

            while(bilangan >= banyakBilangan){
                jumlahBilangan += this.Input($"Input bilangan ke-{++banyakBilangan} : ", IsInt: true);
                this.Output(banyakBilangan);

                if(bilangan == banyakBilangan){
                    this.Output($"\nJumlah {bilangan} yang telah diinputkan = {jumlahBilangan}");
                    this.Output($"\nRata-rata {bilangan} yang telah diinputkan = {jumlahBilangan/banyakBilangan}");
                    break;
                }
            }
        }
    }
}