using System;
using System.Collections.ObjectModel;
using BurgersUIApp.Models;

namespace BurgersUIApp.ViewModels
{
    public class MenuDetailsViewModel
    {
        public ObservableCollection<Burgers> burgers { get; set; }

        public MenuDetailsViewModel()
        {

            burgers = new ObservableCollection<Burgers>
            {
                new Burgers
                {
                     Picture = "MainBurger",
                     Name = "Burger and Pizza Hub",
                     Description = "Burger - Pizza - Breakfast",
                     Rating=" 4.8",
                     RatingDetail=" (121 raitings)",
                     HomeSelected= "CompleteHeart"
                },
                new Burgers
                {
                     Picture = "MainBurger",
                     Name = "Burger and Pizza Hub",
                     Description = "Burger - Pizza - Breakfast",
                     Rating=" 4.8",
                     RatingDetail=" (121 raitings)",
                     HomeSelected= "EmptyHeart"
                },
                new Burgers
                {
                     Picture = "MainBurger",
                     Name = "Burger and Pizza Hub",
                     Description = "Burger - Pizza - Breakfast",
                     Rating=" 4.8",
                     RatingDetail=" (121 raitings)",
                     HomeSelected= "CompleteHeart"
                },
                new Burgers
                {
                     Picture = "MainBurger",
                     Name = "Burger and Pizza Hub",
                     Description = "Burger - Pizza - Breakfast",
                     Rating=" 4.8",
                     RatingDetail=" (121 raitings)",
                     HomeSelected= "EmptyHeart"
                }
            };
        }
    }
}
