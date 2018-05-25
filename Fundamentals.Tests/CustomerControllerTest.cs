using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace Fundamentals.Tests
{
    [TestFixture]
    class CustomerControllerTest
    {
        [Test]
        public void GetCustomer_CustomerId_Zero()
        {
            var customer = new CustomerController();

          var result =  customer.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_CustomerId_NotZero()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
