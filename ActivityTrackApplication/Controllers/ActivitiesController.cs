using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityTrackApplication.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public ActivitiesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> ActivitiesList()
        {
            return await _dbContext.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivityById(Guid id)
        {
            return await _dbContext.Activities.FindAsync(id);
        }
    }
}
