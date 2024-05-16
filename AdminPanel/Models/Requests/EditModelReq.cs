using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Models.Requests
{
    public class EditModelReq
    {
        public int BrandId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
