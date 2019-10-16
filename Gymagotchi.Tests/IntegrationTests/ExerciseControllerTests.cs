using Gymagotchi.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gymagotchi.Tests.IntegrationTests
{
    public class APIWebApplicationFactory : WebApplicationFactory<Startup>
    {
    }

    [TestFixture]
    public class ExerciseControllerTests
    {
        private APIWebApplicationFactory _factory;
        private HttpClient _client;

        [OneTimeSetUp]
        public void GivenARequestToTheController()
        {
            _factory = new APIWebApplicationFactory();
            _client = _factory.CreateClient();
        }

        [Test]
        public async Task GetExercises_ShouldReturn_ListOfExercises()
        {
            var result = await _client.GetAsync("/api/exercise/");
            
            Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task GivenBadRequest_ShouldReturn_HttpError()
        {
            var result = await _client.GetAsync("/api/exercises/");

            Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _client.Dispose();
            _factory.Dispose();
        }
    }
}
