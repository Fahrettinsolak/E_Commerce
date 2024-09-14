﻿using E_Commerce.Cargo.DataAccessLayer.Abstract;
using E_Commerce.Cargo.DataAccessLayer.Concrete;
using E_Commerce.Cargo.DataAccessLayer.Repositories;
using E_Commerce.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Cargo.DataAccessLayer.EntityFramework
{
    public class EFCargoOperationDal : GenericRepository<CargoOperation>, ICargoOperationDal
    {
        public EFCargoOperationDal(CargoContext context) : base(context)
        {

        }
    }
}