using System;

namespace tugas{
    public class Utilities{
        public void Output(dynamic output) => Console.Write(output);
        public dynamic Input(string output, bool IsInt = false, bool IsDouble = false){
            Output(output);
            return  IsInt ? Convert.ToInt32(Console.ReadLine()) : 
                    IsDouble ? Convert.ToDouble(Console.ReadLine()) :
                    Console.ReadLine();
        }
    }
}