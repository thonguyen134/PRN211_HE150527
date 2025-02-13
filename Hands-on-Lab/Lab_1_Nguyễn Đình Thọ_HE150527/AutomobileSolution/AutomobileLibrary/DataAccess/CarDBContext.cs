﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomobileLibrary.BussinessObject
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car(){CarID=1,CarName="CRV",Manufacturer="Hondo",
                Price=30000, ReleaseYear=2021},
            new Car(){CarID=2,CarName="Ford Focus",Manufacturer="Ford",
                Price=15000, ReleaseYear=2020}
        };
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() {
        }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> GetCarList => CarList;
        public Car GetCarByID(int carID)
        {
            //using LINQ to Object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }
        // Add new a car
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }
        //Update a car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
        //Remove a car
        public void Remove(int CarID)
        {
            Car p = GetCarByID(CarID);
            if (p != null)
            {
                CarList.Remove(p);
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }// end Remove
                 // end class
            }
        }
    }
