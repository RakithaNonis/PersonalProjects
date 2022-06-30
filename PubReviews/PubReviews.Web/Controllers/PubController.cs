using Microsoft.AspNetCore.Mvc;
using PubReviews.Data.Data.Models;
using PubReviews.Data.Services;
using PubReviews.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PubReviews.Web.Controllers
{
    public class PubController : Controller
    {
        private IPubService _pubService;

        public PubController(IPubService pubService)
        {
            _pubService = pubService;
        }

        public IActionResult Index()
        {
            var data = _pubService.Get();
            var viewmodelList = new List<PubViewModel>();

            foreach (var item in data)
            {
                viewmodelList.Add
                    (
                        new PubViewModel 
                        {
                            GuestId=item.GuestId,
                            GuestName=item.GuestName,
                            PhoneNumber=item.PhoneNumber,
                            Address=item.Address,
                            CountryCode=item.CountryCode,
                            EmailAddress=item.EmailAddress,
                            HotelCode=item.HotelCode,
                            GenderId=item.GenderId,
                            NumofDays=item.NumofDays,
                            CheckinDate=item.CheckinDate
                        }
                    );
            }
            return View(nameof(Index),viewmodelList);
        }
    }
}
