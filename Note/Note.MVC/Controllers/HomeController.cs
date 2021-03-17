using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Note.BLL;
using Note.MVC.Models;

namespace Note.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBll _noticeBll;

        public HomeController(NoticeBll noticeBll)
        {
            _noticeBll = noticeBll;
        }

        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
        }

        public IActionResult About()
        {

            // ## 테스트 방법 ##
            // # 전통적인 방식(Stopwatch)
            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            // # 새로운 테스트 방식(VS Diagnostic Tools)
            // Debug > Windows > show Diagnostic Tools

            Test1();
            Test2();
            Test3();

            //watch.Stop();

            //var result = watch.ElapsedMilliseconds;

            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            var test1 = Test1Async();
            var test2 = Test2Async();
            var test3 = Test3Async();

            var result1 = await test1;
            var result2 = await test2;
            var result3 = await test3;

            //var result = watch.ElapsedMilliseconds;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //동기처리
        public int Test1()
        {
            Thread.Sleep(3000); //3초동안 멈춤
            return 0;
        }

        public int Test2()
        {
            Thread.Sleep(3000);
            return 0;
        }

        public int Test3()
        {
            Thread.Sleep(4000);
            return 0;
        }

        //비동기처리
        public async Task<int> Test1Async()
        {
            await Task.Delay(3000);
            return 0;
        }

        public async Task<int> Test2Async()
        {
            await Task.Delay(3000);
            return 0;
        }

        public async Task<int> Test3Async()
        {
            await Task.Delay(4000);
            return 0;
        }
    }
}
