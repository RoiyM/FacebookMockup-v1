namespace BasicFacebookFeatures
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogInAndOut = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabBasicFeature = new System.Windows.Forms.TabPage();
            this.labelSelectPhoto = new System.Windows.Forms.Label();
            this.pictureBoxSelectedPicture = new System.Windows.Forms.PictureBox();
            this.listBoxPhotosInSelectedAlbum = new System.Windows.Forms.ListBox();
            this.labelFeed = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabNewFeature = new System.Windows.Forms.TabPage();
            this.labelFriendsWhoHasBirthdayToday = new System.Windows.Forms.Label();
            this.labelChooseBirthdayWishes = new System.Windows.Forms.Label();
            this.buttonPostWish = new System.Windows.Forms.Button();
            this.buttonFetchFriendsWhoHasBirthdayToday = new System.Windows.Forms.Button();
            this.checkedListBoxFriendsWhoHasBirthdayToday = new System.Windows.Forms.CheckedListBox();
            this.buttonCreateBirthdayWish = new System.Windows.Forms.Button();
            this.textBoxWriteYourWish = new System.Windows.Forms.TextBox();
            this.checkedListBoxOpptionalWishes = new System.Windows.Forms.CheckedListBox();
            this.tabMemoryFeature = new System.Windows.Forms.TabPage();
            this.textBoxPostFromThePast = new System.Windows.Forms.TextBox();
            this.labelPostsFromThePast = new System.Windows.Forms.Label();
            this.labelPhotosFromThePast = new System.Windows.Forms.Label();
            this.pictureBoxPhotoFromThePast = new System.Windows.Forms.PictureBox();
            this.buttonFetchPhotosFromThePast = new System.Windows.Forms.Button();
            this.buttonFetchPostsFromThePast = new System.Windows.Forms.Button();
            this.listBoxPhotosFromThePast = new System.Windows.Forms.ListBox();
            this.listBoxPostsFromThePast = new System.Windows.Forms.ListBox();
            this.tab.SuspendLayout();
            this.tabBasicFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabNewFeature.SuspendLayout();
            this.tabMemoryFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFromThePast)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogInAndOut
            // 
            this.buttonLogInAndOut.Location = new System.Drawing.Point(20, 4);
            this.buttonLogInAndOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogInAndOut.Name = "buttonLogInAndOut";
            this.buttonLogInAndOut.Size = new System.Drawing.Size(119, 28);
            this.buttonLogInAndOut.TabIndex = 36;
            this.buttonLogInAndOut.Text = "Log In";
            this.buttonLogInAndOut.UseVisualStyleBackColor = true;
            this.buttonLogInAndOut.Click += new System.EventHandler(this.buttonLogInAndOut_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabBasicFeature);
            this.tab.Controls.Add(this.tabNewFeature);
            this.tab.Controls.Add(this.tabMemoryFeature);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1296, 809);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 53;
            // 
            // tabBasicFeature
            // 
            this.tabBasicFeature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabBasicFeature.BackgroundImage")));
            this.tabBasicFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBasicFeature.Controls.Add(this.labelSelectPhoto);
            this.tabBasicFeature.Controls.Add(this.pictureBoxSelectedPicture);
            this.tabBasicFeature.Controls.Add(this.listBoxPhotosInSelectedAlbum);
            this.tabBasicFeature.Controls.Add(this.labelFeed);
            this.tabBasicFeature.Controls.Add(this.buttonPost);
            this.tabBasicFeature.Controls.Add(this.labelNewStatus);
            this.tabBasicFeature.Controls.Add(this.textBoxStatus);
            this.tabBasicFeature.Controls.Add(this.buttonFetchFriends);
            this.tabBasicFeature.Controls.Add(this.buttonFetchEvents);
            this.tabBasicFeature.Controls.Add(this.buttonFetchPosts);
            this.tabBasicFeature.Controls.Add(this.buttonFetchGroups);
            this.tabBasicFeature.Controls.Add(this.buttonFetchAlbums);
            this.tabBasicFeature.Controls.Add(this.listBoxPosts);
            this.tabBasicFeature.Controls.Add(this.listBoxGroups);
            this.tabBasicFeature.Controls.Add(this.listBoxAlbums);
            this.tabBasicFeature.Controls.Add(this.listBoxEvents);
            this.tabBasicFeature.Controls.Add(this.listBoxFriends);
            this.tabBasicFeature.Controls.Add(this.pictureBoxProfile);
            this.tabBasicFeature.Controls.Add(this.buttonLogInAndOut);
            this.tabBasicFeature.Location = new System.Drawing.Point(4, 25);
            this.tabBasicFeature.Name = "tabBasicFeature";
            this.tabBasicFeature.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicFeature.Size = new System.Drawing.Size(1288, 780);
            this.tabBasicFeature.TabIndex = 0;
            this.tabBasicFeature.Text = "Basic Feature";
            this.tabBasicFeature.UseVisualStyleBackColor = true;
            // 
            // labelSelectPhoto
            // 
            this.labelSelectPhoto.AutoSize = true;
            this.labelSelectPhoto.Location = new System.Drawing.Point(857, 451);
            this.labelSelectPhoto.Name = "labelSelectPhoto";
            this.labelSelectPhoto.Size = new System.Drawing.Size(146, 17);
            this.labelSelectPhoto.TabIndex = 67;
            this.labelSelectPhoto.Text = "Select Photo In Album";
            this.labelSelectPhoto.Visible = false;
            // 
            // pictureBoxSelectedPicture
            // 
            this.pictureBoxSelectedPicture.Location = new System.Drawing.Point(1022, 477);
            this.pictureBoxSelectedPicture.Name = "pictureBoxSelectedPicture";
            this.pictureBoxSelectedPicture.Size = new System.Drawing.Size(237, 173);
            this.pictureBoxSelectedPicture.TabIndex = 66;
            this.pictureBoxSelectedPicture.TabStop = false;
            this.pictureBoxSelectedPicture.Visible = false;
            // 
            // listBoxPhotosInSelectedAlbum
            // 
            this.listBoxPhotosInSelectedAlbum.FormattingEnabled = true;
            this.listBoxPhotosInSelectedAlbum.ItemHeight = 16;
            this.listBoxPhotosInSelectedAlbum.Location = new System.Drawing.Point(832, 477);
            this.listBoxPhotosInSelectedAlbum.Name = "listBoxPhotosInSelectedAlbum";
            this.listBoxPhotosInSelectedAlbum.Size = new System.Drawing.Size(184, 228);
            this.listBoxPhotosInSelectedAlbum.TabIndex = 65;
            this.listBoxPhotosInSelectedAlbum.Visible = false;
            this.listBoxPhotosInSelectedAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosInSelectedAlbum_SelectedIndexChanged);
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeed.Location = new System.Drawing.Point(310, 217);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.Size = new System.Drawing.Size(63, 25);
            this.labelFeed.TabIndex = 64;
            this.labelFeed.Text = "Feed:";
            this.labelFeed.Visible = false;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Location = new System.Drawing.Point(1093, 59);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 65);
            this.buttonPost.TabIndex = 63;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Visible = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.AutoSize = true;
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewStatus.Location = new System.Drawing.Point(310, 11);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.Size = new System.Drawing.Size(112, 25);
            this.labelNewStatus.TabIndex = 61;
            this.labelNewStatus.Text = "New Status";
            this.labelNewStatus.Visible = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(310, 39);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(777, 106);
            this.textBoxStatus.TabIndex = 60;
            this.textBoxStatus.Text = "What\'s on your mind";
            this.textBoxStatus.Visible = false;
            this.textBoxStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxStatus_MouseClick);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(83, 448);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(112, 23);
            this.buttonFetchFriends.TabIndex = 59;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Visible = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(263, 448);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(110, 23);
            this.buttonFetchEvents.TabIndex = 59;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Visible = false;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchPosts.Location = new System.Drawing.Point(685, 217);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(105, 23);
            this.buttonFetchPosts.TabIndex = 59;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Visible = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(507, 448);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(110, 23);
            this.buttonFetchGroups.TabIndex = 59;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Visible = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(714, 448);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(112, 23);
            this.buttonFetchAlbums.TabIndex = 59;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Visible = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(315, 246);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(633, 148);
            this.listBoxPosts.TabIndex = 58;
            this.listBoxPosts.Visible = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(386, 477);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(231, 228);
            this.listBoxGroups.TabIndex = 57;
            this.listBoxGroups.Visible = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(623, 477);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(203, 228);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.Visible = false;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(201, 477);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(172, 228);
            this.listBoxEvents.TabIndex = 55;
            this.listBoxEvents.Visible = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(38, 477);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(157, 228);
            this.listBoxFriends.TabIndex = 54;
            this.listBoxFriends.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 39);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(246, 205);
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // tabNewFeature
            // 
            this.tabNewFeature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNewFeature.BackgroundImage")));
            this.tabNewFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNewFeature.Controls.Add(this.labelFriendsWhoHasBirthdayToday);
            this.tabNewFeature.Controls.Add(this.labelChooseBirthdayWishes);
            this.tabNewFeature.Controls.Add(this.buttonPostWish);
            this.tabNewFeature.Controls.Add(this.buttonFetchFriendsWhoHasBirthdayToday);
            this.tabNewFeature.Controls.Add(this.checkedListBoxFriendsWhoHasBirthdayToday);
            this.tabNewFeature.Controls.Add(this.buttonCreateBirthdayWish);
            this.tabNewFeature.Controls.Add(this.textBoxWriteYourWish);
            this.tabNewFeature.Controls.Add(this.checkedListBoxOpptionalWishes);
            this.tabNewFeature.Location = new System.Drawing.Point(4, 25);
            this.tabNewFeature.Name = "tabNewFeature";
            this.tabNewFeature.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewFeature.Size = new System.Drawing.Size(1288, 780);
            this.tabNewFeature.TabIndex = 1;
            this.tabNewFeature.Text = "Bless a friend";
            this.tabNewFeature.UseVisualStyleBackColor = true;
            // 
            // labelFriendsWhoHasBirthdayToday
            // 
            this.labelFriendsWhoHasBirthdayToday.AutoSize = true;
            this.labelFriendsWhoHasBirthdayToday.Location = new System.Drawing.Point(14, 23);
            this.labelFriendsWhoHasBirthdayToday.Name = "labelFriendsWhoHasBirthdayToday";
            this.labelFriendsWhoHasBirthdayToday.Size = new System.Drawing.Size(217, 17);
            this.labelFriendsWhoHasBirthdayToday.TabIndex = 7;
            this.labelFriendsWhoHasBirthdayToday.Text = "Friends Who Has Birthday Today";
            this.labelFriendsWhoHasBirthdayToday.Visible = false;
            // 
            // labelChooseBirthdayWishes
            // 
            this.labelChooseBirthdayWishes.AutoSize = true;
            this.labelChooseBirthdayWishes.Location = new System.Drawing.Point(391, 24);
            this.labelChooseBirthdayWishes.Name = "labelChooseBirthdayWishes";
            this.labelChooseBirthdayWishes.Size = new System.Drawing.Size(162, 17);
            this.labelChooseBirthdayWishes.TabIndex = 6;
            this.labelChooseBirthdayWishes.Text = "Choose Birthday Wishes";
            this.labelChooseBirthdayWishes.Visible = false;
            // 
            // buttonPostWish
            // 
            this.buttonPostWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostWish.Location = new System.Drawing.Point(785, 251);
            this.buttonPostWish.Name = "buttonPostWish";
            this.buttonPostWish.Size = new System.Drawing.Size(129, 33);
            this.buttonPostWish.TabIndex = 5;
            this.buttonPostWish.Text = "post your wish";
            this.buttonPostWish.UseVisualStyleBackColor = true;
            this.buttonPostWish.Visible = false;
            this.buttonPostWish.Click += new System.EventHandler(this.buttonPostWish_Click);
            // 
            // buttonFetchFriendsWhoHasBirthdayToday
            // 
            this.buttonFetchFriendsWhoHasBirthdayToday.Location = new System.Drawing.Point(8, 252);
            this.buttonFetchFriendsWhoHasBirthdayToday.Name = "buttonFetchFriendsWhoHasBirthdayToday";
            this.buttonFetchFriendsWhoHasBirthdayToday.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchFriendsWhoHasBirthdayToday.TabIndex = 4;
            this.buttonFetchFriendsWhoHasBirthdayToday.Text = "fetch";
            this.buttonFetchFriendsWhoHasBirthdayToday.UseVisualStyleBackColor = true;
            this.buttonFetchFriendsWhoHasBirthdayToday.Visible = false;
            this.buttonFetchFriendsWhoHasBirthdayToday.Click += new System.EventHandler(this.buttonFetchFriendsWhoHasBirthdayToday_Click);
            // 
            // checkedListBoxFriendsWhoHasBirthdayToday
            // 
            this.checkedListBoxFriendsWhoHasBirthdayToday.FormattingEnabled = true;
            this.checkedListBoxFriendsWhoHasBirthdayToday.Location = new System.Drawing.Point(8, 48);
            this.checkedListBoxFriendsWhoHasBirthdayToday.Name = "checkedListBoxFriendsWhoHasBirthdayToday";
            this.checkedListBoxFriendsWhoHasBirthdayToday.Size = new System.Drawing.Size(333, 191);
            this.checkedListBoxFriendsWhoHasBirthdayToday.TabIndex = 3;
            this.checkedListBoxFriendsWhoHasBirthdayToday.Visible = false;
            // 
            // buttonCreateBirthdayWish
            // 
            this.buttonCreateBirthdayWish.Location = new System.Drawing.Point(545, 251);
            this.buttonCreateBirthdayWish.Name = "buttonCreateBirthdayWish";
            this.buttonCreateBirthdayWish.Size = new System.Drawing.Size(101, 30);
            this.buttonCreateBirthdayWish.TabIndex = 2;
            this.buttonCreateBirthdayWish.Text = "create";
            this.buttonCreateBirthdayWish.UseVisualStyleBackColor = true;
            this.buttonCreateBirthdayWish.Visible = false;
            this.buttonCreateBirthdayWish.Click += new System.EventHandler(this.buttonCreateBirthdayWish_Click);
            // 
            // textBoxWriteYourWish
            // 
            this.textBoxWriteYourWish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWriteYourWish.Location = new System.Drawing.Point(786, 48);
            this.textBoxWriteYourWish.Multiline = true;
            this.textBoxWriteYourWish.Name = "textBoxWriteYourWish";
            this.textBoxWriteYourWish.Size = new System.Drawing.Size(214, 191);
            this.textBoxWriteYourWish.TabIndex = 1;
            this.textBoxWriteYourWish.Text = "write your own wish..";
            this.textBoxWriteYourWish.Visible = false;
            this.textBoxWriteYourWish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteYourWish_MouseClick);
            // 
            // checkedListBoxOpptionalWishes
            // 
            this.checkedListBoxOpptionalWishes.FormattingEnabled = true;
            this.checkedListBoxOpptionalWishes.Items.AddRange(new object[] {
            "happy birthday",
            "mazal tov!",
            "wish you all the best!",
            "May your birthday be filled with lots of love",
            "wish you love",
            "wish you joy",
            "wish you happiness",
            "wish you that all of your dreams and wishes come true!",
            "May you have a fantastic birthday"});
            this.checkedListBoxOpptionalWishes.Location = new System.Drawing.Point(391, 48);
            this.checkedListBoxOpptionalWishes.Name = "checkedListBoxOpptionalWishes";
            this.checkedListBoxOpptionalWishes.Size = new System.Drawing.Size(378, 191);
            this.checkedListBoxOpptionalWishes.TabIndex = 0;
            this.checkedListBoxOpptionalWishes.Visible = false;
            // 
            // tabMemoryFeature
            // 
            this.tabMemoryFeature.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.memory;
            this.tabMemoryFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMemoryFeature.Controls.Add(this.textBoxPostFromThePast);
            this.tabMemoryFeature.Controls.Add(this.labelPostsFromThePast);
            this.tabMemoryFeature.Controls.Add(this.labelPhotosFromThePast);
            this.tabMemoryFeature.Controls.Add(this.pictureBoxPhotoFromThePast);
            this.tabMemoryFeature.Controls.Add(this.buttonFetchPhotosFromThePast);
            this.tabMemoryFeature.Controls.Add(this.buttonFetchPostsFromThePast);
            this.tabMemoryFeature.Controls.Add(this.listBoxPhotosFromThePast);
            this.tabMemoryFeature.Controls.Add(this.listBoxPostsFromThePast);
            this.tabMemoryFeature.Location = new System.Drawing.Point(4, 25);
            this.tabMemoryFeature.Name = "tabMemoryFeature";
            this.tabMemoryFeature.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemoryFeature.Size = new System.Drawing.Size(1288, 780);
            this.tabMemoryFeature.TabIndex = 2;
            this.tabMemoryFeature.Text = "Memories";
            this.tabMemoryFeature.UseVisualStyleBackColor = true;
            // 
            // textBoxPostFromThePast
            // 
            this.textBoxPostFromThePast.Enabled = false;
            this.textBoxPostFromThePast.Location = new System.Drawing.Point(466, 486);
            this.textBoxPostFromThePast.Multiline = true;
            this.textBoxPostFromThePast.Name = "textBoxPostFromThePast";
            this.textBoxPostFromThePast.Size = new System.Drawing.Size(434, 196);
            this.textBoxPostFromThePast.TabIndex = 4;
            this.textBoxPostFromThePast.Visible = false;
            // 
            // labelPostsFromThePast
            // 
            this.labelPostsFromThePast.AutoSize = true;
            this.labelPostsFromThePast.Location = new System.Drawing.Point(9, 455);
            this.labelPostsFromThePast.Name = "labelPostsFromThePast";
            this.labelPostsFromThePast.Size = new System.Drawing.Size(140, 17);
            this.labelPostsFromThePast.TabIndex = 3;
            this.labelPostsFromThePast.Text = "Posts From The Past";
            this.labelPostsFromThePast.Visible = false;
            // 
            // labelPhotosFromThePast
            // 
            this.labelPhotosFromThePast.AutoSize = true;
            this.labelPhotosFromThePast.Location = new System.Drawing.Point(9, 29);
            this.labelPhotosFromThePast.Name = "labelPhotosFromThePast";
            this.labelPhotosFromThePast.Size = new System.Drawing.Size(149, 17);
            this.labelPhotosFromThePast.TabIndex = 3;
            this.labelPhotosFromThePast.Text = "Photos From The Past";
            this.labelPhotosFromThePast.Visible = false;
            // 
            // pictureBoxPhotoFromThePast
            // 
            this.pictureBoxPhotoFromThePast.Location = new System.Drawing.Point(325, 66);
            this.pictureBoxPhotoFromThePast.Name = "pictureBoxPhotoFromThePast";
            this.pictureBoxPhotoFromThePast.Size = new System.Drawing.Size(339, 308);
            this.pictureBoxPhotoFromThePast.TabIndex = 2;
            this.pictureBoxPhotoFromThePast.TabStop = false;
            this.pictureBoxPhotoFromThePast.Visible = false;
            // 
            // buttonFetchPhotosFromThePast
            // 
            this.buttonFetchPhotosFromThePast.Location = new System.Drawing.Point(8, 404);
            this.buttonFetchPhotosFromThePast.Name = "buttonFetchPhotosFromThePast";
            this.buttonFetchPhotosFromThePast.Size = new System.Drawing.Size(132, 23);
            this.buttonFetchPhotosFromThePast.TabIndex = 1;
            this.buttonFetchPhotosFromThePast.Text = "Fetch Photos";
            this.buttonFetchPhotosFromThePast.UseVisualStyleBackColor = true;
            this.buttonFetchPhotosFromThePast.Visible = false;
            this.buttonFetchPhotosFromThePast.Click += new System.EventHandler(this.buttonFetchPhotosFromThePast_Click);
            // 
            // buttonFetchPostsFromThePast
            // 
            this.buttonFetchPostsFromThePast.Location = new System.Drawing.Point(8, 688);
            this.buttonFetchPostsFromThePast.Name = "buttonFetchPostsFromThePast";
            this.buttonFetchPostsFromThePast.Size = new System.Drawing.Size(132, 23);
            this.buttonFetchPostsFromThePast.TabIndex = 1;
            this.buttonFetchPostsFromThePast.Text = "Fetch Posts";
            this.buttonFetchPostsFromThePast.UseVisualStyleBackColor = true;
            this.buttonFetchPostsFromThePast.Visible = false;
            this.buttonFetchPostsFromThePast.Click += new System.EventHandler(this.buttonFetchPostsFromThePast_Click);
            // 
            // listBoxPhotosFromThePast
            // 
            this.listBoxPhotosFromThePast.FormattingEnabled = true;
            this.listBoxPhotosFromThePast.ItemHeight = 16;
            this.listBoxPhotosFromThePast.Location = new System.Drawing.Point(8, 66);
            this.listBoxPhotosFromThePast.Name = "listBoxPhotosFromThePast";
            this.listBoxPhotosFromThePast.Size = new System.Drawing.Size(294, 308);
            this.listBoxPhotosFromThePast.TabIndex = 0;
            this.listBoxPhotosFromThePast.Visible = false;
            this.listBoxPhotosFromThePast.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosFromThePast_SelectedIndexChanged);
            // 
            // listBoxPostsFromThePast
            // 
            this.listBoxPostsFromThePast.FormattingEnabled = true;
            this.listBoxPostsFromThePast.ItemHeight = 16;
            this.listBoxPostsFromThePast.Location = new System.Drawing.Point(8, 486);
            this.listBoxPostsFromThePast.Name = "listBoxPostsFromThePast";
            this.listBoxPostsFromThePast.Size = new System.Drawing.Size(398, 196);
            this.listBoxPostsFromThePast.TabIndex = 0;
            this.listBoxPostsFromThePast.Visible = false;
            this.listBoxPostsFromThePast.SelectedIndexChanged += new System.EventHandler(this.listBoxPostFromThePast_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 809);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.tab.ResumeLayout(false);
            this.tabBasicFeature.ResumeLayout(false);
            this.tabBasicFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabNewFeature.ResumeLayout(false);
            this.tabNewFeature.PerformLayout();
            this.tabMemoryFeature.ResumeLayout(false);
            this.tabMemoryFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFromThePast)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogInAndOut;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabBasicFeature;
        private System.Windows.Forms.TabPage tabNewFeature;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelNewStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.Label labelFriendsWhoHasBirthdayToday;
        private System.Windows.Forms.Label labelChooseBirthdayWishes;
        private System.Windows.Forms.Button buttonPostWish;
        private System.Windows.Forms.Button buttonFetchFriendsWhoHasBirthdayToday;
        private System.Windows.Forms.CheckedListBox checkedListBoxFriendsWhoHasBirthdayToday;
        private System.Windows.Forms.Button buttonCreateBirthdayWish;
        private System.Windows.Forms.TextBox textBoxWriteYourWish;
        private System.Windows.Forms.CheckedListBox checkedListBoxOpptionalWishes;
        private System.Windows.Forms.TabPage tabMemoryFeature;
        private System.Windows.Forms.Label labelPostsFromThePast;
        private System.Windows.Forms.Label labelPhotosFromThePast;
        private System.Windows.Forms.PictureBox pictureBoxPhotoFromThePast;
        private System.Windows.Forms.Button buttonFetchPhotosFromThePast;
        private System.Windows.Forms.Button buttonFetchPostsFromThePast;
        private System.Windows.Forms.ListBox listBoxPhotosFromThePast;
        private System.Windows.Forms.ListBox listBoxPostsFromThePast;
        private System.Windows.Forms.TextBox textBoxPostFromThePast;
        private System.Windows.Forms.PictureBox pictureBoxSelectedPicture;
        private System.Windows.Forms.ListBox listBoxPhotosInSelectedAlbum;
        private System.Windows.Forms.Label labelSelectPhoto;
    }
}