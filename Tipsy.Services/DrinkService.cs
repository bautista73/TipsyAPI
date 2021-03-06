using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;
using Tipsy.Models.DrinkModels;

namespace Tipsy.Services
{
    public class DrinkService
    {
        private readonly Guid _userId;

        public DrinkService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDrink(DrinksCreate model)
        {
            var entity =
                new Drinks()
                {
                    UserId = _userId,
                    DrinkName = model.DrinkName,
                    Price = model.Price,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Drink.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<DrinksListItem> GetDrinks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Drink
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new DrinksListItem
                                {
                                    DrinkId = e.DrinkId,
                                    DrinkName = e.DrinkName,
                                    Price = e.Price,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );
                return query.ToArray();
            }
        }

        public DrinksDetail GetDrinkById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drink
                        .Single(e => e.DrinkId == id);
                return
                    new DrinksDetail
                    {
                        DrinkId = entity.DrinkId,
                        DrinkName = entity.DrinkName,
                        Price = entity.Price,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateDrinks(DrinksEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drink
                        .Single(e => e.DrinkId == model.DrinkId);
                entity.DrinkName = model.DrinkName;
                entity.Price = model.Price;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDrink(int drinkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drink
                        .Single(e => e.DrinkId == drinkId);

                ctx.Drink.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
