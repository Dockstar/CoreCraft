using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCraft.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> ohhai()
        {
            Uri target = new Uri("http://swarm01.eastus.cloudapp.azure.com:2736");
            DockerClient client = new DockerClientConfiguration(target).CreateClient();

            var containers = client.Containers.ListContainersAsync(
                new ContainersListParameters()
                {
                    All = true,
                }
            );

            var targetcontainerstats = await client.Containers.GetContainerStatsAsync("mellow_mushroom", new ContainerStatsParameters() {Stream = false},new CancellationToken());
            return View();
        }
    }
}