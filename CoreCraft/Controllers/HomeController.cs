using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using CoreCraft.Models.Images;

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
            Uri target = new Uri("http://127.0.0.1:2376");
            DockerClient client = new DockerClientConfiguration(target).CreateClient();

            ImageListVm ViewModel = new ImageListVm()
            {
                Images = await client.Images.ListImagesAsync(new ImagesListParameters()
                {
                    All = true,
                })
            };


            var shitstain = client.Containers.CreateContainerAsync(new CreateContainerParameters()
            {
                Name = "Nginx",
                Image = "nginx",
                HostConfig = new HostConfig()
                {
                    RestartPolicy = new RestartPolicy()
                    {
                        MaximumRetryCount = 500
                    },
                    AutoRemove = true,

                }

            });

            try
            {
                await shitstain;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(ViewModel);
        }
    }
}