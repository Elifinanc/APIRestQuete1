using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Quete1APIrest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetPostButton_Click(object sender, RoutedEventArgs e)
        {
            string userId = UserIdTxtBox.Text;
            var client = new WebClient();
            if (userId != "")
            {
                var text = client.DownloadString($"https://jsonplaceholder.typicode.com/users/{ userId }/posts");
                ICollection<Posts> post = JsonConvert.DeserializeObject<ICollection<Posts>>(text);

                foreach (Posts element in post)
                {
                    System.Windows.MessageBox.Show("UserId: " + element.userId + " " + "PostId: " +
                    element.id + " " + "PostTitle: " + element.title + " " + "PostBody: " + element.body);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("You have to write a UserId!");
            }
        }

        private void GetCommentsButton_Click(object sender, RoutedEventArgs e)
        {
            string userId = UserIdTxtBox.Text;
            var client = new WebClient();
            if (userId != "")
            {
                var text = client.DownloadString($"https://jsonplaceholder.typicode.com/users/{ userId }/posts");
                ICollection<Posts> postList = JsonConvert.DeserializeObject<ICollection<Posts>>(text);

                List<int> postId = new List<int>();
                foreach (Posts element in postList)
                {
                    postId.Add(element.id);
                }

                foreach (int id in postId)
                {
                    var text2 = client.DownloadString($"https://jsonplaceholder.typicode.com/comments?postId={ id }");
                    ICollection<Comments> comment = JsonConvert.DeserializeObject<ICollection<Comments>>(text);
                    foreach (Comments element in comment)
                    {
                        System.Windows.MessageBox.Show("PostId: " + element.postId + " " + "CommentId: " +
                        element.id + " " + "CommentAuthor: " + element.name + " " + "AuthorEmail: " +
                        element.email + " " + "CommentText: " + element.body);
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("You have to write a UserId!");
            }
        }

        private void GetPhotosButton_Click(object sender, RoutedEventArgs e)
        {
            string userId = UserIdTxtBox.Text;
            var client = new WebClient();
            if (userId != "")
            {
                var text = client.DownloadString($"https://jsonplaceholder.typicode.com/users/{ userId }/albums");
                ICollection<Albums> albumList = JsonConvert.DeserializeObject<ICollection<Albums>>(text);

                List<int> albumId = new List<int>();
                foreach (Albums element in albumList)
                {
                    albumId.Add(element.id);
                }

                foreach (int id in albumId)
                {
                    var text2 = client.DownloadString($"https://jsonplaceholder.typicode.com/albums/{ id }/photos");
                    ICollection<Photo> photos = JsonConvert.DeserializeObject<ICollection<Photo>>(text);
                    foreach (Photo element in photos)
                    {
                        System.Windows.MessageBox.Show("PhotoId: " + element.id + " " + "PhotoTitle: " +
                        element.title);
                    }
                }
            }
        }
    }
}
