using DomainLibrary.Interfaces;
using DomainLibrary.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using UI.Helpers;

namespace UI.ViewModels.Windows
{
    public interface IMessageWindowViewModel : IBaseViewModel
    {
        /// <summary>
        /// When user click Ok button
        /// </summary>
        ReactiveCommand<Unit, Unit> OkCommand { get; }

        /// <summary>
        /// When user click Cancel button
        /// </summary>
        ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }

    public class MessagePopupWindowViewModel : ReactiveObject, IMessageWindowViewModel
    {
        public ReactiveCommand<Unit, Unit> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public MessagePopupWindowViewModel()
        {
            OkCommand = ReactiveCommand.Create(SetMessageResultTrue);
            CancelCommand = ReactiveCommand.Create(SetMessageResultFalse);
        }

        /// <summary>
        /// Set result to true
        /// </summary>
        private void SetMessageResultTrue()
        {
            Utility.MessageResult = true;
        }

        /// <summary>
        /// Set result to false
        /// </summary>
        private void SetMessageResultFalse()
        {
            Utility.MessageResult = false;
        }
    }
}
