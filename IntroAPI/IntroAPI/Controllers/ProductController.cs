
using IntroAPI.Models.EF;
using IntroAPI.Models.VM;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace IntroAPI.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/product/names")]
        [HttpGet]
        public List<string> PNames()
        {
            class17Entities db = new class17Entities();
            var data = (from e in db.products select e.Name).ToList();
            return data;
        }

        [Route("api/product/names/{id}")]
        [HttpGet]
        public string PNames(int id)
        {
            class17Entities db = new class17Entities();
            var data = (from e in db.products where e.Id == id select e.Name).FirstOrDefault();
            return data;
        }
        public List<ProductModel> Get()
        {
            class17Entities db = new class17Entities();
           //    var data = new List<ProductModel>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(db.products.ToList());
            return data;

        /***     foreach (var e in db.products)
            {
                data.Add(new ProductModel() { Id = e.Id, Name = e.Name, Price = e.Price });
            }
            return data;   **/
        }
         public void Post(ProductModel p)
         {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel,product>());
            var mapper = new Mapper(config);
            var data = mapper.Map<product>(p);
            class17Entities db = new class17Entities();
            db.products.Add(data);
            db.SaveChanges();
         }
    }
}
