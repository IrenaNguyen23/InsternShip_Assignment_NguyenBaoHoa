using InsterShip_Assisgnment.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsterShip_Assisgnment.Models
{
    public class HomeModel
    {
        public List<KhoaHoc> ListKhoaHoc { get; set; }
        public List<MonHoc> ListMonHoc { get; set; }
        public string SelectedKhoaHocName { get; set; }
    }
}