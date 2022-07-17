using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public Friend(int id, int user_id, int friend_id)
        {
            Id = id;
            User_id = user_id;
            Friend_id = friend_id;
        }
        public int Id { get; }
        public int User_id { get; }
        public int Friend_id { get; }
        
    }
}
