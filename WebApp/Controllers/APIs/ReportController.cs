using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplication1.Helpers;

namespace WebApplication1.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        [Route("{reportName}/{format}")]
        public IActionResult Get(string reportName, string format)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                var reportDataTable = new ReportDataTable(connectionString);

                var dataTable = reportDataTable.GetTable(reportName);

                var resportResult = ReportHelper.Get("Reports\\" + reportName + ".rdlc", dataTable, format);

                MemoryStream stream = new MemoryStream(resportResult.Content);

                httpResponseMessage.Content = new StreamContent(stream);

                httpResponseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = reportName + "." + resportResult.Extension
                };
                httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(resportResult.MediaType);

                return Ok(httpResponseMessage);
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        [Route("GetBytes/{reportName}/{format}")]
        public byte[] GetBytes(string reportName, string format)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                var reportDataTable = new ReportDataTable(connectionString);

                var dataTable = reportDataTable.GetTable(reportName);

                var resportResult = ReportHelper.Get("Reports\\" + reportName + ".rdlc", dataTable, format);

                return resportResult.Content;
            }
            catch
            {
                return null;
            }
        }
    }
}