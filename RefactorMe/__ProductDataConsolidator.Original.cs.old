using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMe
{
    public class ProductDataConsolidator
    {
        public static List<Product> Get() {
            var l = new LawnmowerRepository().GetAll();
            var p = new PhoneCaseRepository().GetAll();
            var t = new TShirtRepository().GetAll();

            var ps = new List<Product>();

            foreach (var i in l) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "Lawnmower"
                });
            }

            foreach (var i in p) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "Phone Case"
                });
            }

            foreach (var i in t) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "T-Shirt"
                });
            }

            return ps;
        }

        public static List<Product> GetInUSDollars() {
            var l = new LawnmowerRepository().GetAll();
            var p = new PhoneCaseRepository().GetAll();
            var t = new TShirtRepository().GetAll();

            var ps = new List<Product>();

            foreach (var i in l) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.76,
                    Type = "Lawnmower"
                });
            }

            foreach (var i in p) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.76,
                    Type = "Phone Case"
                });
            }

            foreach (var i in t) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.76,
                    Type = "T-Shirt"
                });
            }

            return ps;
        }

        public static List<Product> GetInEuros() {
            var l = new LawnmowerRepository().GetAll();
            var p = new PhoneCaseRepository().GetAll();
            var t = new TShirtRepository().GetAll();

            var ps = new List<Product>();

            foreach (var i in l) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.67,
                    Type = "Lawnmower"
                });
            }

            foreach (var i in p) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.67,
                    Type = "Phone Case"
                });
            }

            foreach (var i in t) {
                ps.Add(new Product() {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price * 0.67,
                    Type = "T-Shirt"
                });
            }

            return ps;
        }
 
 
    }
}
