using DataKaryawan.Models;
using DataKaryawan.Models.DataKaryawan;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataKaryawan.Controllers
{
    [ApiController]
    [Route("api/HomeController")]
    public class HomeController : Controller
    {
        private readonly IKaryawanRepository _karyawanRepository;

        public HomeController(IKaryawanRepository karyawanRepository)
        {
            _karyawanRepository = karyawanRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetKaryawan()
        {
            var karyawan = await _karyawanRepository.GetAllKaryawanAsync();
            return Ok(karyawan);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetKaryawan(int id)
        {
            var karyawan = await _karyawanRepository.GetKaryawanByIdAsync(id);
            if (karyawan == null) return NotFound();
            return Ok(karyawan);
        }

        [HttpPost]
        public async Task<IActionResult> AddKaryawan([FromBody] Employee karyawan)
        {
            await _karyawanRepository.AddKaryawanAsync(karyawan);
            return CreatedAtAction(nameof(GetKaryawan), new { id = karyawan.Id }, karyawan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKaryawan(int id, [FromBody] Employee karyawan)
        {
            if (id != karyawan.Id) return BadRequest();
            await _karyawanRepository.UpdateKaryawanAsync(karyawan);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKaryawan(int id)
        {
            await _karyawanRepository.DeleteKaryawanAsync(id);
            return NoContent();
        }
    }
}
