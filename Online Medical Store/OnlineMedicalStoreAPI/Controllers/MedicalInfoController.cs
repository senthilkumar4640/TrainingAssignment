using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicalStoreAPI.Data;

namespace OnlineMedicalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalInfoController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public MedicalInfoController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/Medicine
        [HttpGet]
        public IActionResult GetMedicine()
        {
            return Ok(_dbContext.medicineList.ToList());
        }

        //GET : api/Medicine/1
        [HttpGet("{id}")]
        public IActionResult GetMedicineByID(int id)
        {
            var medicine = _dbContext.medicineList.FirstOrDefault(m=>m.MedicineID==id);
            if(medicine==null)
            {
                return NotFound();
            }
            return Ok(medicine);
        }

        //Adding a new medicine
        //POST : api/Medicine
        [HttpPost]
        public IActionResult PostMedicine([FromBody] MedicalInfo medicine)
        {
            _dbContext.medicineList.Add(medicine);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing medicine
        //PUT : api/Medicine/1
        [HttpPut("{id}")]
        public IActionResult PutMedicine(int id, [FromBody] MedicalInfo medicine)
        {
            var medicines = _dbContext.medicineList.FirstOrDefault(m=>m.MedicineID == id);
            if(medicines==null)
            {
                return NotFound();
            }
            medicines.MedicineName = medicine.MedicineName;
            medicines.MedicineCount = medicine.MedicineCount;
            medicines.MedicinePrice = medicine.MedicinePrice;
            medicines.MedicineExpiryDate = medicine.MedicineExpiryDate;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
            
        }

        //Deleting an existing medicine
        //DELETE: api/Medicine/1
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var medicine = _dbContext.medicineList.FirstOrDefault(m => m.MedicineID == id);
            if(medicine == null)
            {
                return NotFound();
            }
            _dbContext.medicineList.Remove(medicine);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }
    }
}