namespace DataKaryawan.Models.DataKaryawan
{
    public class EmployeeUnit
    {
        public int Id { get; set; }
        public int KaryawanId { get; set; }
        public int UnitKerjaId { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime? TanggalSelesai { get; set; }
    }
}
