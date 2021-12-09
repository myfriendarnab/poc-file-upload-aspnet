using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using csvUploader.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace csvUploader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> logger;

        public FileController(ILogger<FileController> logger)
        {
            this.logger = logger;
        }

        // GET
        public IActionResult Index()
        {
            return Ok("Hello world!");
        }

        [HttpPost]
        public IActionResult Post(IFormCollection form)
        {
            byte[] data = Array.Empty<byte>();
            var file = form.Files[0];

            using (var br = new BinaryReader(file.OpenReadStream()))
            {
                data = br.ReadBytes((int)file.OpenReadStream().Length);
            }
            
            //removing the headers
            var contentStr = Encoding.UTF8.GetString(data);
            //var content = string.Join("\r\n",contentStr.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Skip(1));
            
            List<Model> result = new List<Model>();
            using (TextReader reader = new StringReader(contentStr))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                int i = 1;
                csv.Context.RegisterClassMap<ModelClassMap>();
                result = csv.GetRecords<Model>().ToList();
                result.ForEach(r=>r.RowNumber=i++);
            }

            //foreach (var item in result)
            //{
            //    item.RowNumber = i++;
            //}
            
            //var modelnew = result.Select(r => new Model
            //{
            //    RowNumber = result.FindIndex(_=>true),
                
            //});
            
            return Accepted(Request.Path, JsonConvert.SerializeObject(result));
        }
    }
}