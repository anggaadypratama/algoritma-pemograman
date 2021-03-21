using System;

namespace tugas{
    public class Utilities{
        protected void Output(string output) => Console.Write(output);
        protected dynamic Input(string output, bool IsInt = false, bool IsDouble = false){
            Output(output);
            return  IsInt ? Convert.ToInt32(Console.ReadLine()) : 
                    IsDouble ? Convert.ToDouble(Console.ReadLine()) :
                    Console.ReadLine();
        }
    }
}