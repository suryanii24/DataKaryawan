using Microsoft.EntityFrameworkCore;

namespace DataKaryawan.Models.DataKaryawan
{
    public class KaryawanRepository : IKaryawanRepository
    {
        private readonly ApplicationDbContext _context;

        public KaryawanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllKaryawanAsync()
        {
            return await _context.Employees.Include(k => k.EmployeeStatuses)
                                          .Include(k => k.EmployeeUnits)
                                          .Include(k => k.EmployeePositions)
                                          .ToListAsync();
        }

        public async Task<Employee> GetKaryawanByIdAsync(int id)
        {
            return await _context.Employees.Include(k => k.EmployeeStatuses)
                                          .Include(k => k.EmployeeUnits)
                                          .Include(k => k.EmployeePositions)
                                          .FirstOrDefaultAsync(k => k.Id == id);
        }

        public async Task AddKaryawanAsync(Employee karyawan)
        {
            await _context.Employees.AddAsync(karyawan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateKaryawanAsync(Employee karyawan)
        {
            _context.Employees.Update(karyawan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteKaryawanAsync(int id)
        {
            var karyawan = await _context.Employees.FindAsync(id);
            if (karyawan != null)
            {
                _context.Employees.Remove(karyawan);
                await _context.SaveChangesAsync();
            }
        }
    }
}
