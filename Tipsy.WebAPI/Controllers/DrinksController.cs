using Tipsy.Models;
using Tipsy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Tipsy.Models.DrinkModels;

namespace Tipsy.WebAPI.Controllers
{
    [Authorize]
    public class DrinksController : ApiController
    {
        private DrinkService CreateDrinkService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var drinkService = new DrinkService(userId);
            return drinkService;
        }

        public IHttpActionResult Get()
        {
            DrinkService drinkService = CreateDrinkService();
            var drinks = drinkService.GetDrinks();
            return Ok(drinks);
        }

        public IHttpActionResult Post(DrinksCreate drink)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateDrinkService();

            if (!service.CreateDrink(drink))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            DrinkService drinkService = CreateDrinkService();
            var drink = drinkService.GetDrinkById(id);
            return Ok(drink);
        }

        public IHttpActionResult Put(DrinksEdit drink)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateDrinkService();

            if (!service.UpdateDrinks(drink))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateDrinkService();

            if (!service.DeleteDrink(id))
                return InternalServerError();

            return Ok();
        }
    }
}
