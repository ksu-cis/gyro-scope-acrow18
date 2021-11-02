using GyroScope.Data;
using GyroScope.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Test cases for Register View Model
    /// </summary>
    public class RegisterViewModelTests
    {
        /// <summary>
        /// Checks if change owed is correct
        /// </summary>
        [Fact]
        public void IsChangeOwedCorrect()
        {
            var order = new Order();
            order.Add(new ScorpioSpicyGyro());
            order.Add(new VirgoClassicGyro());
            order.Add(new VirgoClassicGyro());
            var RVM= new RegisterViewModel(order);
            RVM.CustomerHundreds = 1;
            Assert.Equal(RVM.ChangeOwed, RVM.Total - RVM.Customer);
        }


        /// <summary>
        /// Checks if amount due is correct
        /// </summary>
        [Fact]
        public void IsAmountDueCorrect()
        {
            var order = new Order();
            order.Add(new ScorpioSpicyGyro());
            order.Add(new VirgoClassicGyro());
            order.Add(new VirgoClassicGyro());
            var RVM = new RegisterViewModel(order);
            RVM.CustomerHundreds = 1;
            Assert.Equal(RVM.AmountDue, RVM.Total - RVM.Customer);
        }

        
        /// <summary>
        /// Change owed should default to zero
        /// </summary>
        [Fact]
        public void ChangeOwedShouldDefaultToZero()
        {
            var order = new Order();
            order.Add(new VirgoClassicGyro());
            var RVM = new RegisterViewModel(order);
            Assert.Equal(0, RVM.ChangeOwed);
        }


        /// <summary>
        /// Total due should equal the the total of the order
        /// </summary>
        [Fact]
        public void TotalDueShouldEqualOrderCost()
        {
            var order = new Order();
            order.Add(new VirgoClassicGyro());
            var RVM = new RegisterViewModel(order);
            Assert.Equal(RVM.Total, order.Total);
        }

        /// <summary>
        /// Change owed to customer should be calculated correctly
        /// </summary>
        /// <param name="num">Number of twenty dollar bills recieved from customer</param>
        /// <param name="total">Total remaining from customer</param>
        [Theory]
        [InlineData(1, 14)]
        [InlineData(2, 8)]
        [InlineData(3, 2)]
        public void ChangeOwedShouldCalculateCorrectly(int num, decimal total) 
        {
            var order = new Order();
            order.Add(new VirgoClassicGyro());
            var RVM = new RegisterViewModel(order);
            RVM.CustomerTwenties = num;
            Assert.Equal(total, RVM.ChangeOwed);
        }


        [Theory]
        [InlineData()]
        public void MoneyShouldBeRemovedFromCashRegister(int customerBills, int drawerTwos, int drawerTens) 
        {
            var order = new Order();
            order.Add(new VirgoClassicGyro());
            var RVM = new RegisterViewModel(order);
            RVM.CustomerTwos = customerBills;
            Assert.Equal(drawerTwos, RVM.CashDrawerTwos);
            Assert.Equal(drawerTens, RVM.CashDrawerTens);

        }


    }
}
