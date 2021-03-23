namespace tugas.AssesmentSatu{
    class AssesmentProgSatu : Utilities{
        public AssesmentProgSatu(){
            dynamic namaP = this.Input("Nama Pegawai : "),
                    penghasilanP = this.Input("Penghasilan Pegawai : ", IsInt: true);

            double pajak =  (penghasilanP >= 20000 && penghasilanP <= 40000) ? penghasilanP * 0.15 : 
                            (penghasilanP > 40000) ? penghasilanP * 0.2 : 0;

            this.Output($" 1. Nama Pegawai : {namaP} \n 2. Penghasilan : {penghasilanP} Rupiah \n 3. Total Pajak : {pajak} Rupiah");
        }
    }
}