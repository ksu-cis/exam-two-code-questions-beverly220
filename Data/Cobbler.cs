using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Creates an event when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// stores fruit value
        /// </summary>
        FruitFilling fruit = FruitFilling.Blueberry;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit {
            get {
                return fruit;
            }
            set {
                fruit = value;
                NotifyOfPropertyChanged("Fruit");
            }
        }

        /// <summary>
        /// stores that cream is default
        /// </summary>
        bool cream = true;

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream {
            get {
                return cream;
            }
            set {
                cream = value;
                NotifyOfPropertyChanged("WithIceCream");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Updates if a Property is Changed
        /// </summary>
        /// <param name="name">the entree changed</param>
        protected void NotifyOfPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
    }
}
