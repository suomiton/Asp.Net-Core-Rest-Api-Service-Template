using System;
using Xunit;
using Moq;
using RestService.DAL.Services;
using System.Collections.Generic;
using RestService.DAL.Models;

namespace Tests
{
    public class Tests
    {
        private readonly List<Restaurant> _restaurants;

        public Tests()
        {
            this._restaurants = new List<Restaurant>();
            this._restaurants.Add(new Restaurant()
            {
                Name = "Test 1",
                RestaurantId = "test"
            });

            this._restaurants.Add(new Restaurant()
            {
                Name = "Test 2",
                RestaurantId = "test2"
            });

            this._restaurants.Add(new Restaurant()
            {
                Name = "Test 3",
                RestaurantId = "test3"
            });
        }

        [Fact]
        public void Test1()
        {
            var mockService = new Mock<IDocumentService>();
            
            mockService
                .Setup(ds => ds.GetRestaurant("test"))
                .ReturnsAsync(this._restaurants[0]);

            Assert.True(mockService.Object.GetRestaurant("test").Result == this._restaurants[0]);
            Assert.False(mockService.Object.GetRestaurant("test2").Result == this._restaurants[0]);
        }
    }
}
