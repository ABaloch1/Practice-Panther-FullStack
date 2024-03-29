﻿using Project_library.Models;
using Project_library.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project.MAUI.ViewModels
{
    public class BillViewModel : INotifyPropertyChanged
    {
        public Bill Model { get; set; }
        private decimal total;
        public decimal TotalAmount
        {
            get
            {
                return total;
            }
            set
            {
                if (total != value)
                {
                    total = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string Display
        {
            get
            {
                return Model.ToString();
            }
        }

        public BillViewModel()
        {
            Model = new Bill();
            
        }

        public BillViewModel(Bill model)
        {
            Model = model;
        }

        public BillViewModel(int projectId, int billid)
        {
            if (billid > 0)
            {
                Model = BillService.Current.Get(billid);
            }
            else
            {
                Model = new Bill();
                Model.ProjectId = projectId;
            }
        }

        


        //public BillViewModel(decimal amount)
        //{
        //    Model = new Bill() { TotalAmount = amount };

        //}





        //notify property changed
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
