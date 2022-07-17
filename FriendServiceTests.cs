using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;
using System;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class FriendServiceTests
    {
        [Test]
        public void AddFriendMustThrowException()
        {
            var service = new FriendService();
            Assert.Throws<ArgumentNullException>(delegate
            {
                service.AddFriend(new FriendAddingData()
                {
                    UserId = 1,
                    FriendEmail = "ivanov"
                });
            });
        }
    }
}