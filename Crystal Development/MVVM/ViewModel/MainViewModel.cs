using Crystal_Development.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_Development.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public bool FirstMessage { get; private set; }
        public bool IsNativeOrigin { get; private set; }
        public string Message { get; private set; }
        public DateTime Time { get; private set; }
        public string ImageSource { get; private set; }
        public string UsernameColor { get; private set; }
        public string Username { get; private set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            (
                Username = "Roblox",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            ));

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
               (
                   Username = "Everett",
                   UsernameColor = "#409aff",
                   ImageSource = "/Images/Crystal.png",
                   Message = "Test",
                   Time = DateTime.Now,
                   IsNativeOrigin = false,
                   FirstMessage = false
               ));
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
               (
                   Username = "Landon",
                   UsernameColor = "#409aff",
                   ImageSource = "/Images/Crystal.png",
                   Message = "Test",
                   Time = DateTime.Now,
                   IsNativeOrigin = true,
                   FirstMessage = false
               ));
            }
            Messages.Add(new MessageModel
               (
                   Username = "Oscar",
                   UsernameColor = "#409aff",
                   ImageSource = "/Images/Crystal.png",
                   Message = "Last",
                   Time = DateTime.Now,
                   IsNativeOrigin = true
               ));

            for (var i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Username {i}",
                    ImageSource = "/Images/Crystal.png",
                    Messages = Messages
                });
            }

        }
    }
}
