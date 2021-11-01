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
        [Theory]
        [InlineData(new int[] { 10, 10, 10 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })] //10x(Virgo, Scorpio, Leo) (190.20)
        public void IsChangeCorrect(int[] items, int[] expectedChange)
        {
            RoundRegister.CashDrawer.ResetDrawer();
            var order = new Order();
            for (int i = 0; i < items[0]; i++) order.Add(new VirgoClassicGyro());
            for (int i = 0; i < items[1]; i++) order.Add(new ScorpioSpicyGyro());
            for (int i = 0; i < items[2]; i++) order.Add(new LeoLambGyro());
            var viewModel = new RegisterViewModel(order);
            viewModel.CustomerHundreds = 1;
        }
    }
}
