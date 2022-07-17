using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddingView
    {
        UserService userService;
        FriendService friendService;
        public FriendAddingView(FriendService friendService, UserService userService)
        {
            this.friendService = friendService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var friendAddingData = new FriendAddingData();

            Console.Write("Введите почтовый адрес друга: ");
            friendAddingData.FriendEmail = Console.ReadLine();

            friendAddingData.UserId = user.Id;

            try
            {
                friendService.AddFriend(friendAddingData);
                var friendInfo = userService.FindByEmail(friendAddingData.FriendEmail);
                SuccessMessage.Show($"Пользователь {friendInfo.FirstName} {friendInfo.LastName} добавлен в ваш список друзей!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Друг не зарегистрирован в социальной сети!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректный почтовый адрес!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга!");
            }

        }
    }
}
