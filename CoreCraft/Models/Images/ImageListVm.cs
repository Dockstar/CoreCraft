using System.Collections.Generic;
using Docker.DotNet;
using Docker.DotNet.Models;

namespace CoreCraft.Models.Images
{
    public class ImageListVm
    {
        public ICollection<ImagesListResponse> Images { get; set; }
    }
}