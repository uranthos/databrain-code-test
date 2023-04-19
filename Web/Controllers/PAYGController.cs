using DataBrain.Common.CommonDefs;
using DataBrain.Common.Interfaces;
using DataBrain.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/payg")]
    [Produces("application/json")]
    public class PAYGController : Controller
    {
        private IPAYGService _PAYGService;

        public PAYGController(IPAYGService paygService)
        {
            _PAYGService = paygService;
        }

        //returns the taxable amount based upon the users income and how frequently they get paid
        [HttpPost("calculatetax")]
        public PAYGResultModel GetValue([FromBody] PAYGSubmissionModel model)
        {
            //As PaymentFrequency is an enum, the model passes it through as an int which matches the indexing within the enum
            return new PAYGResultModel(
                _PAYGService.GetTax(model.TaxableIncome, 
                (PaymentFrequency)model.Frequency)); 

        }
    }

}