using DomainLibrary.Interfaces;
using DomainLibrary.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Windows
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

        public MessagePopupWindowViewModel()
        {
            _okCommand = ReactiveCommand.Create(() => { });
            _cancelCommand = ReactiveCommand.Create(() => { });
        }

        #region Properties

        private readonly ReactiveCommand<Unit, Unit> _okCommand;
        ReactiveCommand<Unit, Unit> IMessageWindowViewModel.OkCommand => _okCommand;

        private readonly ReactiveCommand<Unit, Unit> _cancelCommand;
        ReactiveCommand<Unit, Unit> IMessageWindowViewModel.CancelCommand => _cancelCommand;

        #endregion
    }
}
