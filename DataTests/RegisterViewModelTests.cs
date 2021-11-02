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
        [Fact]
        public void IsChangeOwedCorrect()
        {
            var order = new Order();
            order.Add(new ScorpioSpicyGyro());
            order.Add(new VirgoClassicGyro());
            order.Add(new VirgoClassicGyro());
            var viewModel = new RegisterViewModel(order);
            viewModel.CustomerHundreds = 1;
            Assert.Equal(viewModel.ChangeOwed, viewModel.Total - viewModel.Customer);
        }

        [Fact]
        public void IsAmountDueCorrect()
        {
            var order = new Order();
            order.Add(new ScorpioSpicyGyro());
            order.Add(new VirgoClassicGyro());
            order.Add(new VirgoClassicGyro());
            var viewModel = new RegisterViewModel(order);
            viewModel.CustomerHundreds = 1;
            Assert.Equal(viewModel.AmountDue, viewModel.Total - viewModel.Customer);
        }

        /*
        [Fact]
        public void IsCashRegisterCorrect()
        {
            var cashRegister
        }
        */
    }
}
