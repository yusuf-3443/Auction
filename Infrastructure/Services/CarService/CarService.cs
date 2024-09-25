using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain.DTOs.CarDTOs;
using Domain.DTOs.UserDTOs;
using Domain.Models;
using Domain.Responses;
using Infrastructure.Services.Data;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Infrastructure.Services.CarService
{
    public class CarService(DataContext context) : ICarService
    {
        public async Task<Response<string>> AddCar(AddCarDto addCar)
        {
            try
            {
                var car = new Car()
                {
                     VIN = addCar.VIN,
                    Model = addCar.Model,
                    Brand = addCar.Brand,
                    Year = addCar.Year,
                    Mileage = addCar.Mileage,
                    StartingPrice = addCar.StartingPrice,
                    Price = addCar.Price,
                    Description = addCar.Description,
                    Photo = addCar.Photo,
                    OwnerId = addCar.OwnerId,
                    CreatedAt = addCar.CreatedAt
                };
                await context.Cars.AddAsync(car);
                await context.SaveChangesAsync();

                return new Response<string>($"Successfully created a new car by id:{car.Id}");
            }
            catch (System.Exception e)
            {
                return new Response<string>(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public Task<Response<bool>> DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<GetCarDto>> GetCarById(int id)
        {
            try
            {
                var existingCar = await context.Cars.Where(x=>x.Id == id).Select(x=>
                new GetCarDto()
                {
                    VIN = x.VIN,
                    Model = x.Model,
                    Brand = x.Brand,
                    Year = x.Year,
                    Mileage = x.Mileage,
                    StartingPrice = x.StartingPrice,
                    Price = x.Price,
                    Description = x.Description,
                    Photo = x.Photo,
                    OwnerId = x.OwnerId,
                    CreatedAt = x.CreatedAt
                }).FirstOrDefaultAsync();

                    if(existingCar == null)
                    {
                        return new Response<GetCarDto>(HttpStatusCode.BadRequest,"User not found");
                    }
                    return new Response<GetCarDto>(existingCar);

            }
            catch (System.Exception e)
            {
                return new Response<GetCarDto>(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public async Task<Response<List<GetCarDto>>> GetCars()
        {
            try
            {
                var cars = await context.Cars.Select(x=>new GetCarDto()
                {
                    VIN = x.VIN,
                    Model = x.Model,
                    Brand = x.Brand,
                    Year = x.Year,
                    Mileage = x.Mileage,
                    StartingPrice = x.StartingPrice,
                    Price = x.Price,
                    Description = x.Description,
                    Photo = x.Photo,
                    OwnerId = x.OwnerId,
                    CreatedAt = x.CreatedAt
                }).ToListAsync();

                return new Response<List<GetCarDto>>(cars); 
            }
            catch (System.Exception e)
            {
                return new Response<List<GetCarDto>>(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public Task<Response<string>> UpdateCar(UpdateCarDto updateCar)
        {
            throw new NotImplementedException();
        }
    }
}