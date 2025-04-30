using Dapper;
using fronttoback33.Constans;
using fronttoback33.Models;
using fronttoback33.Repostories.Abstractions;
using Microsoft.Data.SqlClient;
using System.Data;

namespace fronttoback33.Repostories.Implementations
{
    public class SliderRepository : ISliderepository
    {
        private IDbConnection _connection { get => new SqlConnection(ConnectionStrings.SqlConnectionString); }
        public async Task AddAsync(Slider entity)
        {
            using var db = _connection;
            await db.ExecuteAsync("INSERT INTO Sliders VALUES (@Title,@Description,@Price,@ImagePath)", entity);
        }

        public async Task DeleteAsync(int id)
        {
           using var db=_connection;
            await db.ExecuteAsync("DELETE FROM Sliders WHERE Id =@Id".new { Id = id });
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            using var db = _connection;
            var list = await db.QueryAsync<Slider>("SELECT *FROM Sliders");
            return List.ToList();
        }

        public Task<Slider> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}