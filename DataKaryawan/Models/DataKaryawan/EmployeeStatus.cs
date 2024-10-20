namespace DataKaryawan.Models.DataKaryawan
{
    public class EmployeeStatus
    {
        public int Id { get; set; }
        public int KaryawanId { get; set; }
        public string Status { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime? TanggalSelesai { get; set; }
    }
}
