using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class ManagersService
    {
        public static object DataAccessFactory { get; private set; }

        //auto mapper 6.1.1 used
        public static List<ManagerModel> Get()
        {
            //AutoMapper.Mapper
            Mapper.Initialize(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var data = AutoMapper.Mapper.Map<List<ManagerModel>>(DataAccessFactory.ManagersDataAccess().Get()); // for automapper 6.1.1
            return data;
        }
        public static ManagerModel Get(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var data = Mapper.Map<ManagerModel>(DataAccessFactory.ManagersDataAccess().Get(id)); // for automapper 6.1.1
            return data;
        }
        public static void Create(ManagerModel manager)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ManagerModel, Manager>());
            var data = Mapper.Map<Manager>(manager); // for automapper 6.1.1
            DataAccessFactory.ManagersDataAccess().Add(data);

        }
        public static void Edit(ManagerModel manager)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ManagerModel, Manager>());
            var data = Mapper.Map<Manager>(manager); // for automapper 6.1.1
            DataAccessFactory.ManagersDataAccess().Edit(data);

        }
        public static void Delete(int id)
        {
            DataAccessFactory.ManagersDataAccess().Delete(id);
        }




    }
}
