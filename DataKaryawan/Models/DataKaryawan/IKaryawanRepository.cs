namespace DataKaryawan.Models.DataKaryawan
{
    public interface IKaryawanRepository
    {
        Task<IEnumerable<Employee>> GetAllKaryawanAsync();
        Task<Employee> GetKaryawanByIdAsync(int id);
        Task AddKaryawanAsync(Employee karyawan);
        Task UpdateKaryawanAsync(Employee karyawan);
        Task DeleteKaryawanAsync(int id);
    }
}
