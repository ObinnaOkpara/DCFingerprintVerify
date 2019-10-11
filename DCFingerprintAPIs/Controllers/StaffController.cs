using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCFingerprintDBClass;
using DCFingerprintClasses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DCFingerprintClasses;

namespace DCFingerprintAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

        private readonly bsslsys_itfContext _context;

        public StaffController(bsslsys_itfContext context)
        {
            _context = context;
        }


        // GET: api/Staff/StaffId/Password
        /// <summary>
        /// Log Admin in by passing staff id and password.
        /// </summary>
        /// <param name="StaffId">The admin's staffId.</param>
        /// <param name="Password">The admin's password.</param>
        /// <returns></returns>
        [HttpGet("{StaffId}/{Password}")]
        public async Task<IActionResult> GetStaff([FromRoute] string StaffId, [FromRoute] string Password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Admin = await _context.Useracct.FirstOrDefaultAsync(m => m.Userid == StaffId && m.Pwd == Password);

            var rtn = new ApiReturnObject<Useracct>();
            if (Admin == null)
            {
                rtn = new ApiReturnObject<Useracct>()
                {
                    Message = "Login Failed, User not found.",
                    Status = false,
                    Object = Admin
                };
            }
            else
            {
                var SA = await _context.Stafftab.FirstOrDefaultAsync(m => m.FpAuthorised == true && m.Staffid == Admin.Userid);

                if (SA == null)
                {
                    rtn = new ApiReturnObject<Useracct>()
                    {
                        Message = "Login Failed, User is not Authorised to Access this module.",
                        Status = false,
                        Object = null
                    };
                }
                else {
                    rtn = new ApiReturnObject<Useracct>()
                    {
                        Message = "Login Successful.",
                        Status = true,
                        Object = Admin
                    };
                }
            }

            return Ok(rtn);
        }


        // GET: api/Staff/StaffId
        /// <summary>
        /// Find staff by staffid or name.
        /// </summary>
        /// <param name="StaffId">The the staff id or name to search.</param>
        /// <returns></returns>
        [HttpGet("{StaffId}")]
        public async Task<IActionResult> FindStaffs([FromRoute] string StaffId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staffs = await _context.Stafftab.Include(n => n.Fingerprints).Where(m => m.Staffid.Contains(StaffId) || m.Surname.Contains(StaffId) || 
            m.Othernames.Contains(StaffId) || m.Firstname.Contains(StaffId) || m.Middlename.Contains(StaffId)).ToListAsync();

            foreach (var item in staffs)
            {
                if (item.Fingerprints != null)
                {
                    foreach (var i in item.Fingerprints)
                    {
                        i.Staff = null;
                    }
                }
            }

            var rtn = new ApiReturnObject<List<Stafftab>>();
            if (!staffs.Any())
            {
                rtn = new ApiReturnObject<List<Stafftab>>()
                {
                    Message = "No staff was found with such Name or Id.",
                    Status = false,
                    Object = staffs
                };
            }
            else
            {
                rtn = new ApiReturnObject<List<Stafftab>>()
                {
                    Message = "Found.",
                    Status = true,
                    Object = staffs
                };
            }

            return Ok(rtn);
        }

        // POST: api/Staff/Fingerprint
        /// <summary>
        ///     Add new fingerprints to staff
        /// </summary>
        /// <param name="FP">The fingerprint data to be added</param>
        /// <returns></returns>
        [HttpPost("Fingerprint")]
        public async Task<IActionResult> PostFingerprint([FromBody] Fingerprint FP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staff = await _context.Stafftab.FirstOrDefaultAsync(m => m.Id == FP.StafftabId);
            var rtn = new ApiReturnObject<Fingerprint>();
            if (staff == null)
            {
                rtn = new ApiReturnObject<Fingerprint>()
                {
                    Message = "Staff was not found.",
                    Status = false,
                    Object = null
                };
            }
            else
            {
                _context.Fingerprints.Add(FP);

                _context.SaveChanges();

                FP.Staff = null;

                rtn = new ApiReturnObject<Fingerprint>()
                {
                    Message = "Fingerprint was saved successfully.",
                    Status = true,
                    Object = FP
                };
            }

            return Ok(rtn);
        }

    }
}