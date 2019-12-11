using PizzaOrderEngine.Booking;
using System;
using Xunit;

namespace PizzaOrderEngine.Tests
{
    public class BookingEngineTest
    {
        [Fact]
        public void SHOULD_RETURN_TOTAL_PRICE_AS_0_WHEN_GIVEN_ZERO_OR_NEGATIVE_NO_OF_ITEM()
        {
            //given
            var actual = "0";
            BookingEngine booking = new BookingEngine();
            //when
            var expected=booking.getItems("121", -1).TotalPrice;
            //then
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SHOULD_RETURN_CORRECT_PRICE_ACCORDING_TO_NO_OF_ITEM()
        {
            //given
            var actual = "660";
            BookingEngine booking = new BookingEngine();
            //when
            var expected = booking.getItems("121", 6).TotalPrice;
            //then
            Assert.Equal(expected, actual);
        }


    }
}
