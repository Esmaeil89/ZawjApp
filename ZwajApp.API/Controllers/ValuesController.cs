﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZwajApp.API.Data;

namespace ZwajApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public async Task<IActionResult> GetValues ()
        {
            var Values = await _context.Values.ToListAsync();
            return Ok(Values);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue (int id)
        {
            var Value = await _context.Values.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(Value);
        }
    }
}
