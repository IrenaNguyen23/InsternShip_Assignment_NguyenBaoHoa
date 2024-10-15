using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsterShip_Assisgnment.Models;
using InsterShip_Assisgnment.Context;

namespace InsterShip_Assisgnment.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities obj = new VNR_InternShipEntities();
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.ListKhoaHoc = obj.KhoaHocs.ToList();
            model.ListMonHoc = new List<MonHoc>(); // Khởi tạo danh sách môn học rỗng khi chưa chọn khóa học
            model.SelectedKhoaHocName = string.Empty; // Khởi tạo tên khóa học đã chọn là rỗng
            return View(model);
        }

        // Action khi người dùng chọn khóa học
        public ActionResult MonHocByKhoaHoc(int khoaHocId)
        {
            HomeModel model = new HomeModel();
            model.ListMonHoc = obj.MonHocs.Where(m => m.KhoaHocID == khoaHocId).ToList();
            model.ListKhoaHoc = obj.KhoaHocs.ToList();
            model.SelectedKhoaHocName = obj.KhoaHocs.FirstOrDefault(k => k.ID == khoaHocId)?.TenKhoaHoc; // Lấy tên khóa học đã chọn

            return View("Index", model); // Trả về view Index với mô hình đã cập nhật
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}