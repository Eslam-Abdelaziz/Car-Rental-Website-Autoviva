using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Models.Requests;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Services
{
	public class CarService
    {
        private ConnectionService _connectionService;
        private IMapper _mapper;
		public CarService(ConnectionService connectionService, IMapper mapper)
		{
			_connectionService = connectionService;
			_mapper = mapper;
		}
		public async Task<List<Car>> GetCarsAsync(string name, string modelyear, int? brandid, int? branchid, int? colorid, int? size, string seats, string price, bool? isElectric,bool? IsAutomatic)
        {
            return await _connectionService.GetJsonAsync<List<Car>>($"api/Cars?name={name}&modelyear={modelyear}&brandid={brandid}&branchid={branchid}&colorid={colorid}&size={size}&seats={seats}&price={price}&isElectric={isElectric}&IsAutomatic={IsAutomatic}")
                ?? new List<Car>();
        }
        public async Task<int> GetCarsCount() 
        {
            try 
            {
				var res = await _connectionService.GetAsync("api/Cars/Total");
				if (res.IsSuccessStatusCode)
				{
                    return int.Parse(await res.Content.ReadAsStringAsync());
				}
                return  -1;
			}
			catch (Exception ex) 
            {
                return  -1;
            }
        }
        public async Task<Car> AddCar(Car car)
        {
			car = await _connectionService.PostJsonAsync<Car>("api/Cars", _mapper.Map<CarCreateRequest>(car));
            if (car != null)
            {
                MessageBox.Show("Car Added !");
                return car;
            }
            else
            {
                MessageBox.Show("Add Failed", "Failed");
				return car;
			}
		}
        public async Task<bool> EditCar(Car car)
        {
            (bool Success, string Msg) = await _connectionService.PutAsync($"api/Cars/{car.Id}", _mapper.Map<CarEditRequest>(car));
            if (Success)
            {
                MessageBox.Show("Edit Successfully !");
                return true;
            }
            else
            {
                MessageBox.Show(Msg, "Edit Failed ");
                return false;
            }
        }
        public async Task<bool> PostImages(Car car , List<Image> images,bool delete = false) 
        {
            return await _connectionService.PostImagesAsync($"api/Cars/{car.Id}/Images?delete={delete}", images);
        }
        public async Task<Image> GetImageAsync(int carid,int imgid)
        {
            return await _connectionService.GetImageAsync($"api/Cars/{carid}/{imgid}");
        }


    }
}
