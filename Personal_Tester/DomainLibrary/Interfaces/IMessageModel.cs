using DomainLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary.Interfaces
{
    public interface IMessageModel
    {
        string Message { get; set; }
        string Title { get; set; }
        MessageIconEnum Icon { set; get; }
        MessageResultEnum Result { set; get; }
        MessageButtonEnum Button { set; get; }
    }
}
