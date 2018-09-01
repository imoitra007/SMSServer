using System.Net;
using System.Net.Http;
using SMS.BusinessLogicLayer.Implementations;
using SMS.BusinessLogicLayer.Interfaces;
using System.Web.Http;
using SMS.DomainEntites.Entities;

namespace Angular.Services.WebAPI.Controllers
{
    public class AdminController : ApiController
    {
        private readonly IAdminManager _adminManager;
        public AdminController()
        {
            _adminManager = new AdminManager();
        }

        [HttpGet]
        public HttpResponseMessage GetAllTeacher(string id = null, bool isActive = true)
        {
            var result = _adminManager.GetAllTeacher(id, isActive);
            if (result != null)
                return Request.CreateResponse(HttpStatusCode.OK, result);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Teacher found.");
        }

        [HttpPost]
        public HttpResponseMessage SaveTeacher(Teacher teacher)
        {
            return null;
        }
    }
}
