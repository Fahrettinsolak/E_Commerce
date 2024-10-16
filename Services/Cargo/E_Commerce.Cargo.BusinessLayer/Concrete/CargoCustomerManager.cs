﻿using E_Commerce.Cargo.BusinessLayer.Abstract;
using E_Commerce.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Cargo.DataAccessLayer.EntityFramework;

namespace E_Commerce.Cargo.BusinessLayer.Concrete
{
     
    public class CargoCustomerManager : ICargoCustomerService
    {
       
        private readonly EFCargoCustomerDal _cargoCustomerDal;

        public CargoCustomerManager(EFCargoCustomerDal cargoCustomerDal)
        {
            _cargoCustomerDal = cargoCustomerDal;
        }

        public void TDelete(int id)
        {
            _cargoCustomerDal.Delete(id);
        }

        public List<CargoCustomer> TGetAll()
        {
            return _cargoCustomerDal.GetAll();
        }

        public CargoCustomer TGetById(int id)
        {
            return _cargoCustomerDal.GetById(id);
        }

        public void TInsert(CargoCustomer entity)
        {
            _cargoCustomerDal.Insert(entity);
        }

        public void TUpdate(CargoCustomer entity)
        {
            _cargoCustomerDal.Update(entity);
        }
    }
}
