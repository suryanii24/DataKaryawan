namespace DataKaryawan.Models.DataKaryawan
{
    public class EmployeePosition
    {
        public int Id { get; set; }
        public int KaryawanId { get; set; }
        public int JabatanId { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime? TanggalSelesai { get; set; }
    }
}
