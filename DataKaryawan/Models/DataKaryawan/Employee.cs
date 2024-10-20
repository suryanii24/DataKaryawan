namespace DataKaryawan.Models.DataKaryawan
{
    public class Employee
    {
        public int Id { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public List<EmployeeStatus> EmployeeStatuses { get; set; }
        public List<EmployeeUnit> EmployeeUnits { get; set; }
        public List<EmployeePosition> EmployeePositions { get; set; }
    }
}
