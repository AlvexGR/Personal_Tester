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
        /// <summary>
        /// Content of the message will be displayed to the user
        /// </summary>
        string Message { get; set; }
        
        /// <summary>
        /// Title of the Message Window
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Icon type of the Message Window
        /// </summary>
        MessageIconEnum Icon { set; get; }

        /// <summary>
        /// Button type of the Message Window
        /// </summary>
        MessageButtonEnum Button { set; get; }
    }
}
