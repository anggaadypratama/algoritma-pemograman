// using tugas.AssesmentSatu;
// using tugas.Quiz.QuizSatu;
// using tugas.Quiz.QuizDua;
using tugas.Praktikum;
using tugas;
using System;

namespace ProjectConsole{
    class Program{

        // struct DataNilai{
        //     public int[] assesment {get; set;};
        //     public int[] kuis {get; set;};
        //     public int[] tugas {get; set;};
        // }

        static void Main(string[] args) {
            //object tugas
            int totalNilai = 0;
            int[] nilai = new int[3];
            int[,] dataNilai = new int[3,5];

            string komponen(int i) => (i == 0 ? "Assessment" : (i == 1 ? "Tugas" : "Kuis"));

            for(int i = 0; i< 3; i++){
                for(int j = 0; j < 5; j++){
                    Console.Write($"Masukan Nilai {komponen(i)} ke-{j+1} : ");
                    dataNilai[i,j] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for(int i = 0; i< (dataNilai.GetUpperBound(0) + 1);i++){
                for(int j = 0;j < (dataNilai.GetUpperBound(1) + 1); j++){
                    nilai[i] += dataNilai[i,j]/(dataNilai.GetUpperBound(1) + 1);
                }
                Console.WriteLine($"rata-rata nilai {komponen(i)} : {(nilai[i])}");
            }

            foreach(int total in nilai) totalNilai += total;
            Console.WriteLine($"total rata-rata nilai : {totalNilai/nilai.Length}");

        }
    }
}

