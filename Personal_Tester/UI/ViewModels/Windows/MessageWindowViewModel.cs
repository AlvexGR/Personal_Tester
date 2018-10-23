using DomainLibrary.Interfaces;
using DomainLibrary.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels.Windows
{
    public interface IMessageWindowViewModel
    {
        ReactiveCommand<Unit, bool> OkCommand { get; }
        ReactiveCommand<Unit, bool> CancelCommand { get; }
    }

    public class MessageWindowViewModel : ReactiveObject, IMessageWindowViewModel
    {
        private IMessageModel messageModel;
        public IMessageModel MessageModel
        {
            get => messageModel;
            set => this.RaiseAndSetIfChanged(ref messageModel, value);
        }

        public ReactiveCommand<Unit, bool> OkCommand { get; }
        public ReactiveCommand<Unit, bool> CancelCommand { get; }

        public MessageWindowViewModel()
        {
            OkCommand = ReactiveCommand.Create(() => { return true; });
            CancelCommand = ReactiveCommand.Create(() => { return false; });
        }
    }
}
