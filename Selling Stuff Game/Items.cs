using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Selling_Stuff_Game
{
    public class Items : INotifyPropertyChanged
    {
        #region Properties

        private string _name;
        public string name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        private decimal _price;
        public decimal price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        private int _quantity;
        public int quantity
        { 
            get => _quantity;
            set
            { 
                _quantity = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public Items(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
