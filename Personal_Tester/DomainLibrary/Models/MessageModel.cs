using DomainLibrary.Enums;
using DomainLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary.Models
{
    public class MessageModel : IMessageModel
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public MessageIconEnum Icon { set; get; }
        public MessageButtonEnum Button { set; get; }

        public MessageModel()
        {

        }

        public MessageModel(string message, string title, MessageIconEnum icon, MessageButtonEnum button)
        {
            Message = message;
            Title = title;
            Icon = icon;
            Button = button;
        }
    }
}
