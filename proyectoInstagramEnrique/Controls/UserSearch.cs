using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFinal.Classes;
namespace proyectoFinal.Controls
{
    public partial class UserSearch : UserControl
    {
        private User currentUser;
        private bool follower = false;
        private UserService userService;
        private ProfileIterator pI;
        private List<string> posts=new List<string>();
        private User searcheduser;
        public UserSearch()
        {
            InitializeComponent();
            posts = new List<string>();
            profileView1.Hide();
            viewPublication1.Hide();
            viewPublication2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();

        }
        public void logOut()
        {
            profileView1.Hide();
            viewPublication1.Hide();
            viewPublication2.Hide();
            button2.Hide();
            button3.Hide();
            textBox1.Text = "";
            currentUser = null;
            searcheduser = null;
            button4.Hide();
            posts = new List<string>();
            pI=new ProfileIterator(posts,2);
            pI.getProfiles();
            getPosts();
        }
        public void update(User u, UserService us)
        {
            currentUser = u;
            userService = us;
            searcheduser = null;
            posts=new List<string>();
            profileView1.Hide();
            button4.Hide();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                searcheduser = userService.getUser(textBox1.Text);
                if (searcheduser != null)
                {
                    button4.Show();
                    profileView1.Show();
                    searcheduser.Clone(userService.getPosts(searcheduser), userService.getFollowers(searcheduser), userService.getFollowing(searcheduser));
                    if (searcheduser.followers.Contains(currentUser.username))
                    {
                        follower = true;
                        button4.Text = "unfollow";
                    }



                    else
                    {
                        follower = false;
                        button4.Text = "follow";

                    }

                    
                    pI = new ProfileIterator(searcheduser.publication, 2);
                    pI.resetIterator();
                    posts = new List<string>();
                    posts = pI.getProfiles();
                    getPosts();
                    profileView1.sendUser(searcheduser);
                }
            }

            
        }
        public void getPosts()
        {
            viewPublication1.Hide();
            viewPublication2.Hide();
            if (pI.next()) button3.Show();
            else button3.Hide();
            if (pI.back()) button2.Show();
            else button2.Hide();
            if (posts.Count > 0)
            {
                viewPublication1.UpdateView(userService.getPost(posts[0]), userService, searcheduser, currentUser);
                viewPublication1.Show();
            }
            if (posts.Count > 1)
            {
                viewPublication2.UpdateView(userService.getPost(posts[1]), userService, searcheduser, currentUser);
                viewPublication2.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pI.navigateFront();
            posts = pI.getProfiles();
            getPosts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pI.navigateBack();
            posts = pI.getProfiles();
            getPosts();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (follower)
            {
                userService.unFollow(currentUser.username,searcheduser.username);
                follower = false;
                button4.Text = "Follow";
                searcheduser.Clone(userService.getPosts(searcheduser), userService.getFollowers(searcheduser), userService.getFollowing(searcheduser));
                currentUser.Clone(userService.getPosts(currentUser), userService.getFollowers(currentUser), userService.getFollowing(currentUser));
                profileView1.sendUser(searcheduser);
            }
            else
            {
                userService.follow(currentUser.username, searcheduser.username);
                follower = true;
                button4.Text = "unfollow";
                searcheduser.Clone(userService.getPosts(searcheduser), userService.getFollowers(searcheduser), userService.getFollowing(searcheduser));
                currentUser.Clone(userService.getPosts(currentUser), userService.getFollowers(currentUser), userService.getFollowing(currentUser));
                profileView1.sendUser(searcheduser);
            }
        }
    }
}
