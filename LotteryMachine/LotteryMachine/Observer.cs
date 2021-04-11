using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryMachine
{
    public interface IObserver
    {
        void Reaction();
    }
    class Observer
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver newObserver) 
        {
            observers.Add(newObserver);
        }
        public void RemoveObserver(IObserver oldObserver) 
        {
            observers.Remove(oldObserver);
            observers.TrimExcess();
        }
        protected void RefreshGrid() 
        {
            foreach (var item in observers)
            {
                item.Reaction();
            }
        }
    }
    class RefreshGridClass : Observer 
    {
        public void Refresh() 
        {
            base.RefreshGrid();
        }
    }
}
