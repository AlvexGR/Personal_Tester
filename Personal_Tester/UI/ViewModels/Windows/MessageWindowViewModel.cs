﻿using DomainLibrary.Interfaces;
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
    public interface IMessageWindowViewModel
    {
        ReactiveCommand<Unit, Unit> OkCommand { get; }
        ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }

    public class MessageWindowViewModel : ReactiveObject, IMessageWindowViewModel
    {
        public ReactiveCommand<Unit, Unit> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public MessageWindowViewModel()
        {
            OkCommand = ReactiveCommand.Create(SetMessageResultTrue);
            CancelCommand = ReactiveCommand.Create(SetMessageResultFalse);
        }

        private void SetMessageResultTrue()
        {
            Utility.MessageResult = true;
        }

        private void SetMessageResultFalse()
        {
            Utility.MessageResult = false;
        }
    }
}
