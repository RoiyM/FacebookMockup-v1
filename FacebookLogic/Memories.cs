using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public static class Memories
    {
        public static List<Post> FetchPostFromThePast(User i_LoggedInUser)
        {
            DateTime today = DateTime.Today;
            List<Post> postFromThePastList = new List<Post>();
            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.CreatedTime.HasValue && post.CreatedTime.Value.DayOfYear == today.DayOfYear)
                {
                    postFromThePastList.Add(post);
                }
            }

            return postFromThePastList;
        }

        public static List<Photo> FetchPhotosFromThePast(User i_LoggedInUser)
        {
            DateTime today = DateTime.Today;
            List<Photo> photosFromThePastList = new List<Photo>();
            foreach(Photo photo in i_LoggedInUser.PhotosTaggedIn)
            {
                if(photo.CreatedTime.HasValue && photo.CreatedTime.Value.DayOfYear == today.DayOfYear)
                {
                    photosFromThePastList.Add(photo);
                }
            }

            return photosFromThePastList;
        }
    }
}
