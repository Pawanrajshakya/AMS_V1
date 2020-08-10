using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers
{

    public class ReportResult
    {
        public byte[] Content { get; set; }
        public string Extension { get; set; }
        public string MediaType { get; set; }
    }

    public static class ReportHelper
    {
        /// <summary>
        /// Return Report Result
        /// </summary>
        /// <param name="reportPath">physical report file path and name</param>
        /// <param name="dataTable">datatable matched exactly with store procedure used in the report</param>
        /// <param name="format">pdf or excel</param>
        /// <param name="datasetName">This refers to the dataset name in the RDLC file</param>
        /// <returns></returns>
        public static ReportResult Get(string reportPath, System.Data.DataTable dataTable, string format, string datasetName = "DataSet")
        {
            try
            {
                string mimeType;
                string encoding;
                string extension;
                string[] streams;
                Warning[] warnings;

                ReportDataSource rds = new ReportDataSource
                {
                    Name = datasetName,
                    Value = dataTable
                };

                LocalReport localReport = new LocalReport { ReportPath = @"" + reportPath };
                localReport.DataSources.Clear();
                localReport.DataSources.Add(rds);

                byte[] bytes = localReport.Render(
                    format,
                    null,
                    out mimeType,
                    out encoding,
                    out extension,
                    out streams,
                    out warnings);

                return new ReportResult
                {
                    Content = bytes,
                    Extension = extension,
                    MediaType = mimeType
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class ReportDataTable
    {

        string _connectionString;

        public ReportDataTable(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetTable(string procedureName, params object[] parameterValues)
        {
            try
            {
                DataSet ds = DataAccessHelper.SqlHelper.ExecuteDataset(_connectionString, procedureName, parameterValues);

                if (ds != null && ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }
    }
}
