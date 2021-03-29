﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.ViewModels;

namespace WPFUI.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private BaseViewModel viewModel;

        public UpdateViewCommand(BaseViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Login")
            {
                viewModel.SelectedViewModel = new LoginViewModel();
            }
            else if (parameter.ToString() == "Manage Account")
            {
                viewModel.SelectedViewModel = new ManageAccountViewModel();
            }
            else if (parameter.ToString() == "Register")
            {
                viewModel.SelectedViewModel = new RegisterViewModel();
            }
            else if (parameter.ToString() == "Home") 
            {
                viewModel.SelectedViewModel = new MainViewModel();
            }
        }
    }
}
