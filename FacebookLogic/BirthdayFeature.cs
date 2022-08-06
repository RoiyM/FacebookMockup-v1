using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public static class BirthdayFeature
    {
        public static List<User> FetchFriendsWhoHasBirthdayToday(User i_LoggedInUser)
        {
            List<User> friendsWhoHasBirthdayTodayList = new List<User>();
            foreach(User friend in i_LoggedInUser.Friends)
            {
                if(!string.IsNullOrEmpty(friend.Birthday) && hasBirthdayToday(friend.Birthday))
                {
                    friendsWhoHasBirthdayTodayList.Add(friend);
                }
            }

            return friendsWhoHasBirthdayTodayList;
        }

        private static bool hasBirthdayToday(string i_FriendBirthDay)
        {
            int currentDay = DateTime.Today.Day;
            int currentMonth = DateTime.Today.Month;

            return currentDay == int.Parse(i_FriendBirthDay.Substring(3, 2))
                   && currentMonth == int.Parse(i_FriendBirthDay.Substring(0, 2));
        }
    }
}
