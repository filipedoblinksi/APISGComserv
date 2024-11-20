using System.ComponentModel;
using SGComserv.Extensions;

namespace SGComserv.AbstractClass
{
    public abstract class BaseEntity<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public static string Table
        {
            get
            {
                return typeof(T).GetTableName();
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<TValue>(ref TValue field, TValue value, string propertyName)
        {
            if (!EqualityComparer<TValue>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }
    }
}