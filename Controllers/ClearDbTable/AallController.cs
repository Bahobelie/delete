using cnet_db_op.Service.ClearDbservise;
using Microsoft.AspNetCore.Mvc;

namespace cnet_db_op.Controllers.ClearDbTable
{
    [ApiController]
    [Route("api/Deleate")]
    public class AallController : Controller
    {
        private readonly InterfceService articletable;
        private readonly InterfceService persontable;
        private readonly InterfceService orgnationtable;
        private readonly InterfceService commontable;
        private readonly InterfceService commgslandvochertable;
        private readonly InterfceService vochertable;
        public AallController(Func<Tables,InterfceService>servicselctor)
        {
            articletable = servicselctor(Tables.whatever);
            persontable = servicselctor(Tables.person);
            orgnationtable = servicselctor(Tables.Organaitation);
            vochertable = servicselctor(Tables.Vocher);
            commontable = servicselctor(Tables.Common);
            commgslandvochertable = servicselctor(Tables.CommonglsandVocher);
        }
        [HttpDelete("ArticleTable")]

        public JsonResult GetArticle()
        {
             articletable.Delet();
            return new JsonResult("Success");
        }
        [HttpDelete]
        [Route("personTable")]
        public JsonResult GetPerson()
        {
             persontable.Delet();
            return new JsonResult("Success");
        }
        [HttpDelete]
        [Route("VocherTable")]
        public JsonResult GetVocher()
        {
             vochertable.Delet();
            return new JsonResult("Success");
        }
        [HttpDelete]
        [Route("OrganitionTable")]
        public JsonResult Getorganization()
        {
             orgnationtable.Delet();
            return new JsonResult("Success");
        }
        [HttpDelete]
        [Route("CommonTable")]
        public JsonResult GetCommon()
        {
             commontable.Delet();
            return new JsonResult("Success");
        }
        [HttpDelete]
        [Route("CommonglsandvocherTable")]
        public JsonResult GetCommonglsandvocher()
        {
             commgslandvochertable.Delet();
            return new JsonResult("Success");
        }
    }
}
