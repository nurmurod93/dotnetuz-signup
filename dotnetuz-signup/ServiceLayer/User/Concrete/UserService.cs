using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotnetuz_signup.ServiceLayer.User.Concrete
{
    class UserService : IUserService
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API.GET_USER);
            var res = await client.GetAsync(client.BaseAddress);
            string reponse = await res.Content.ReadAsStringAsync();
            IEnumerable<UserModel> users = JsonConvert.DeserializeObject<IEnumerable<UserModel>>(reponse);
            return users;
        }

        public Task<bool> Post(UserModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
