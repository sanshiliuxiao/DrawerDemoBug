using System;
using System.Collections.Generic;
using System.Text;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;

namespace DrawerDemo.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        public DelegateCommand TheTestCommand { get; set; }
        public MainWindowViewModel()
        {
            TheTestCommand = new DelegateCommand(TheTest);
        }

        public void TheTest()
        {
            MessageBox.Show("我被点击啦");
        }
    }
}
