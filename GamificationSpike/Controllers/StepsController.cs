using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using GamificationSpike.Models;

namespace GamificationSpike.Controllers
{
    [Route("api/steps")]
    [ApiController]
    public class StepsController : ControllerBase
    {
        private readonly GamificationSpikeContext _context;

        public StepsController(GamificationSpikeContext context)
        {
            _context = context;

            if (_context.Steps.Count() == 0)
            {
                Step s = new Step { Name = "Wearing your hearing aid" };
                _context.Steps.Add(s);

                Item i1 = new Item { Name = "Put it in your ear" };
                i1.StepId = s.Id;
                _context.Items.Add(i1);

                Item i2 = new Item { Name = "Turn up the volume" };
                i2.StepId = s.Id;
                _context.Items.Add(i2);

                Item i3 = new Item { Name = "Hear everything" };
                i3.StepId = s.Id;
                _context.Items.Add(i3);

                s.numSteps = 3;

                _context.SaveChanges();
            }

        }

        [HttpGet]
        public ActionResult<List<Step>> GetAll()
        {
            return _context.Steps.ToList();
        }

        [HttpGet("{id}", Name = "GetStep")]
        public ActionResult<Step> GetById(long id)
        {
            var item = _context.Steps.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}