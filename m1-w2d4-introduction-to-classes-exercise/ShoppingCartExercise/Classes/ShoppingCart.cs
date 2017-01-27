using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        
        public int totalNumberOfItems;
        public double totalAmountOwed;
        
        
        public ShoppingCart()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0.0;
        } 
        
        public double GetAveragePricePerItem()
        {
            return (totalAmountOwed / totalNumberOfItems);
        }

        public void AddItems(int numberOfItems, double pricePerItem)
        {
            totalNumberOfItems = totalNumberOfItems + numberOfItems;
            totalAmountOwed = totalAmountOwed + (numberOfItems * pricePerItem);
        }

        public void Empty()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0.0;
        }

    }
}
