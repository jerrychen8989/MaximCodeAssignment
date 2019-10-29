using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximCode.Data;

namespace MaximCode.Repo
{
    public class CarRepository
    {
        MaximDBContext db = new MaximDBContext();
        public void Add()
        {
            //Hard code add since the data is not so big//
            //Car1//
            Car car1 = new Car() { Id = 1, Make = "Honda", Model = "CRV", Color = "Green", Year = "2016", Price = 23845, TCCRating = 8, HwyMPG = 33 };
            db.Cars.Add(car1);
            //Car2//
            Car car2 = new Car() { Id = 2, Make = "Ford", Model = "Escape", Color = "Red", Year = "2017", Price = 23590, TCCRating = 7.8, HwyMPG = 32 };
            db.Cars.Add(car2);
            //Car3//
            Car car3 = new Car() { Id = 3, Make = "Hyundai", Model = "Sante Fe", Color = "Grey", Year = "2016", Price = 24950, TCCRating = 8, HwyMPG = 27 };
            db.Cars.Add(car3);
            //Car4//
            Car car4 = new Car() { Id = 4, Make = "Mazda", Model = "CX-5", Color = "Red", Year = "2017", Price = 21795, TCCRating = 8, HwyMPG = 35 };
            db.Cars.Add(car4);
            //Car5//
            Car car5 = new Car() { Id = 5, Make = "Subaru", Model = "Forester", Color = "Blue", Year = "2016", Price = 22395, TCCRating = 8.4, HwyMPG = 32 };
            db.Cars.Add(car5);
            db.SaveChanges();
        }
        public IEnumerable<Car> getAll()
        {
            return db.Cars.ToList();
        }
        public IEnumerable<Car> GetDifferentCondition(Predicate<Car> deleg)
        {
            List<Car> listofCars = new List<Car>();
            foreach (var item in getAll())
            {
                if (deleg(item))
                {
                    listofCars.Add(item);
                }
            }
            return listofCars;
        }

    }
}
