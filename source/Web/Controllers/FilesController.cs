using Architecture.Application;
using DotNetCore.AspNetCore;
using DotNetCore.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Architecture.Web
{
    [ApiController]
    [ControllerRoute]
    public class FilesController : ControllerBase
    {
        private readonly string _directory;
        private readonly IFileApplicationService _fileApplicationService;
        private readonly IFileService _fileService;

        public FilesController
        (
            IFileApplicationService fileApplicationService,
            IFileService fileService,
            IHostEnvironment environment
        )
        {
            _directory = Path.Combine(environment.ContentRootPath, "Files");
            _fileApplicationService = fileApplicationService;
            _fileService = fileService;
        }

        [DisableRequestSizeLimit]
        [HttpPost]
        public Task<IEnumerable<BinaryFile>> AddAsync()
        {
            return _fileApplicationService.AddAsync(_directory, Request.Files());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SelectAsync(Guid id)
        {
            var file = await _fileApplicationService.SelectAsync(_directory, id);

            var contentType = _fileService.GetContentType(file.ContentType);

            return File(file.Bytes, contentType, file.Name);
        }
    }
}
