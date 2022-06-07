using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18242937_HW3.Models
{
    public class FileModel
    {
        public string FileName { get; set; }

        public HttpPostedFileBase files { get; set; }
    }
}