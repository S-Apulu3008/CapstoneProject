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
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
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
        }
    }
}
