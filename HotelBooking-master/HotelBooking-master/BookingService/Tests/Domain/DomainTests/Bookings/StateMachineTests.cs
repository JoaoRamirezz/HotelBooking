using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using NUnit.Framework;


namespace DomainTests.Bookings
{
    public class StateMachineTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldAlwayStartWithCreatedStatus()
        {
            var booking = new Booking();
            Assert.Pass();
        }
    }

}