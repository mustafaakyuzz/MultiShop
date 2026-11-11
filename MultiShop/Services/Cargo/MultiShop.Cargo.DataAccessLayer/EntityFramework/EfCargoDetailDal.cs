using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context) : base(context)
        {
            
        }
    }
}
