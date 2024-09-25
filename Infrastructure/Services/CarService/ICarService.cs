using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs.CarDTOs;
using Domain.Responses;

namespace Infrastructure.Services.CarService
{
    public interface ICarService
    {
        Task<Response<List<GetCarDto>>> GetCars();
        Task<Response<GetCarDto>> GetCarById(int id);
        Task<Response<string>> AddCar(AddCarDto addCar);
        Task<Response<string>> UpdateCar(UpdateCarDto updateCar);
        Task<Response<bool>> DeleteCar(int id);
    }
}