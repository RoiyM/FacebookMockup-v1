using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppID = "204543351599299";
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            this.InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private bool loginAndInit()
        {
            bool hasLoggedInSuccessfully = false;
            m_LoginResult = FacebookService.Login(
                k_AppID,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                showAllControls();
                this.fetchUserInfo();
                hasLoggedInSuccessfully = true;
            }
            else
            {
                MessageBox.Show("Login Failed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return hasLoggedInSuccessfully;
        }

        private void showAllControls()
        {
            foreach (Control control in this.Controls)
            {
                makeVisible(control);
            }
        }

        private void makeVisible(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    makeVisible(child);
                }
            }

            control.Visible = true;
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonLogInAndOut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns21c");
            if (this.buttonLogInAndOut.Text == "Log In")
            {
                if (loginAndInit() && m_LoginResult.FacebookOAuthResult.IsSuccess)
                {
                    this.buttonLogInAndOut.Text = "Log Out";
                    textBoxStatus.Text += $", {m_LoginResult.LoggedInUser.Name}?";
                }
            }
            else
            {
                FacebookService.LogoutWithUI();
                this.buttonLogInAndOut.Text = "Log In";
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            this.fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("There Are No Friends", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("There Is No Posts In Feed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            this.fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("There Is No Albums", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            this.fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event facebookEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(facebookEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("There Are No Events", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            this.fetchGroups();
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            foreach (Group group in m_LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("There Are No Groups", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxStatus_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxStatus.Text = string.Empty;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Status Post Has Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                textBoxStatus.Text = "What's on your mind";
                this.buttonPost.Enabled = false;
                this.textBoxStatus.Enabled = false;
                textBoxStatus.ForeColor = SystemColors.ControlDark;
            }
        }

        private void textBoxWriteYourWish_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBoxWriteYourWish.Text == "write your own wish..")
            {
                this.textBoxWriteYourWish.Text = string.Empty;
            }
        }

        private void buttonFetchFriendsWhoHasBirthdayToday_Click(object sender, EventArgs e)
        {
            List<User> friendsWhoHasBirthdayTodayList = BirthdayFeature.FetchFriendsWhoHasBirthdayToday(m_LoggedInUser);

            this.checkedListBoxFriendsWhoHasBirthdayToday.Items.Clear();
            this.checkedListBoxFriendsWhoHasBirthdayToday.DisplayMember = "Name";

            foreach (User friend in friendsWhoHasBirthdayTodayList)
            {
                this.checkedListBoxFriendsWhoHasBirthdayToday.Items.Add(friend);
            }

            if (friendsWhoHasBirthdayTodayList.Count == 0)
            {
                MessageBox.Show("You Don't Have Any Friends Who Has Birthday Today", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCreateBirthdayWish_Click(object sender, EventArgs e)
        {
            if (this.checkedListBoxOpptionalWishes.SelectedItems.Count != 0)
            {
                createBirthdayWish();
            }
            else
            {
                MessageBox.Show(
                    "You Have Not Checked Any Wishes",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void createBirthdayWish()
        {
            StringBuilder wishes = new StringBuilder();
            foreach (string wish in this.checkedListBoxOpptionalWishes.CheckedItems)
            {
                wishes.AppendFormat(" " + wish);
            }

            this.textBoxWriteYourWish.Text = wishes.ToString();
        }

        private void buttonFetchPhotosFromThePast_Click(object sender, EventArgs e)
        {
            listBoxPhotosFromThePast.Items.Clear();
            listBoxPhotosFromThePast.DisplayMember = "CreatedTime.Value.ToString()";

            List<Photo> photosFromThePastList = Memories.FetchPhotosFromThePast(m_LoggedInUser);
            foreach (Photo photo in photosFromThePastList)
            {
                listBoxPhotosFromThePast.Items.Add(photo);
            }

            if (photosFromThePastList.Count == 0)
            {
                MessageBox.Show("There Are No Photos From The Past", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchPostsFromThePast_Click(object sender, EventArgs e)
        {
            listBoxPostsFromThePast.Items.Clear();
            listBoxPostsFromThePast.DisplayMember = "From.Name";

            List<Post> postsFromThePastList = Memories.FetchPostFromThePast(m_LoggedInUser);
            foreach (Post post in postsFromThePastList)
            {
                listBoxPostsFromThePast.Items.Add(post);
            }

            if (postsFromThePastList.Count == 0)
            {
                MessageBox.Show("There Are No Posts From The Past", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxPhotosFromThePast_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.displaySelectedPicture();
        }

        private void displaySelectedPicture()
        {
            if (listBoxPhotosFromThePast.SelectedItems.Count == 1)
            {
                Photo selectedPicture = listBoxPhotosFromThePast.SelectedItem as Photo;
                if (selectedPicture != null && selectedPicture.PictureNormalURL != null)
                {
                    pictureBoxPhotoFromThePast.LoadAsync(selectedPicture.PictureNormalURL);
                }
                else
                {
                    pictureBoxPhotoFromThePast.Image = pictureBoxPhotoFromThePast.ErrorImage;
                }
            }
        }

        private void listBoxPostFromThePast_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.displaySelectedPost();
        }

        private void displaySelectedPost()
        {
            if (listBoxPostsFromThePast.SelectedItems.Count == 1)
            {
                Post selectedPost = listBoxPostsFromThePast.SelectedItem as Post;
                if (selectedPost != null)
                {
                    textBoxPostFromThePast.Text = selectedPost.Caption;
                }
                else
                {
                    textBoxPostFromThePast.Text = "An Error Occurred.";
                }
            }
        }

        private void buttonPostWish_Click(object sender, EventArgs e)
        {
            string wishes = textBoxWriteYourWish.Text;
            if (this.checkedListBoxFriendsWhoHasBirthdayToday.Items.Count == 0)
            {
                MessageBox.Show(
                    "You Don't Have Any Friends Who Has Birthday Today",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (this.checkedListBoxFriendsWhoHasBirthdayToday.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "You Have Not Checked Any Friend",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(wishes))
            {
                MessageBox.Show(
                    "There Is No Blessing To Send",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                foreach (User friendWhoHasBirthdayToday in this.checkedListBoxFriendsWhoHasBirthdayToday.SelectedItems)
                {
                    try
                    {
                        friendWhoHasBirthdayToday.PostStatus(wishes);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "The Birthday Wish Has Failed To Send",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPhotosInSelectedAlbum.Items.Clear();
            if (this.listBoxAlbums.SelectedItem is Album selectedAlbum)
            {
                foreach (Photo photo in selectedAlbum.Photos)
                {
                    listBoxPhotosInSelectedAlbum.Items.Add(photo);
                }
            }
        }

        private void listBoxPhotosInSelectedAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxPhotosInSelectedAlbum.SelectedItem is Photo selectedPhoto)
            {
                this.pictureBoxSelectedPicture.LoadAsync(selectedPhoto.PictureThumbURL);
            }
        }
    }
}