/*Class: User
A class used to store information about a user
Version: 1.0
Author: Cecilia Lindmark
Date: 20191215
PART OF UDEMY COURSE
*/

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id {get; set;}

        public string Username {get; set;}

        public byte[] PasswordHash {get; set;}

        public byte[] PasswordSalt {get; set;}

    }
}