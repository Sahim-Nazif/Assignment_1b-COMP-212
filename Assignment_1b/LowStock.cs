using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1b
{
    //creating class with event-- delegate
    public class LowStock
    {
        //creating event
        public event CarInventory carEvent;
        public void Notify()
        {
            //checking if not null will call the event
            if (carEvent != null)
            {
                carEvent.Invoke();
            }
        }

    }
}
