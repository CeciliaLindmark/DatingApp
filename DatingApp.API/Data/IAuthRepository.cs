/*Interface: IAuthRepository
An interface handling return types for returns from database
Version: 1.0
Author: Cecilia Lindmark
Date: 20191215
PART OF UDEMY COURSE
*/


using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password); 

        Task<bool> UserExists(string username);
    }
}