using DomainLibrary.Enums;
using DomainLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary.Models
{
    public class MessagePopupModel : IMessagePopupModel
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public MessagePopupIconEnum Icon { set; get; }
        public MessagePopupButtonEnum Button { set; get; }

        public MessagePopupModel()
        {

        }

        public MessagePopupModel(string message, string title, MessagePopupIconEnum icon, MessagePopupButtonEnum button)
        {
            Message = message;
            Title = title;
            Icon = icon;
            Button = button;
        }
    }
}
