using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
    public class CustomerService
    {
        static CustomerService()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Customer, CustomerModel>();
                cfg.CreateMap<CustomerModel, Customer>();
            });
        }
        public static List<CustomerModel> Get()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<CustomerModel>>(DataAccessFactory.CustomerDataAccess().Get()); // for automapper 6.1.1
            return data;
        }
        public static CustomerModel Get(int id)
        {

            var data = Mapper.Map<CustomerModel>(DataAccessFactory.CustomerDataAccess().Get(id)); // for automapper 6.1.1
            return data;
        }
        public static void Create(CustomerModel customer)
        {

            var data = Mapper.Map<Customer>(customer); // for automapper 6.1.1
            DataAccessFactory.CustomerDataAccess().Add(data);

        }
        public static void Edit(CustomerModel customer)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CustomerModel, Customer>());
            var data = Mapper.Map<Customer>(customer); // for automapper 6.1.1
            DataAccessFactory.CustomerDataAccess().Edit(data);

        }
        public static void Delete(int id)
        {
            DataAccessFactory.CustomerDataAccess().Delete(id);
        }


    }
}
