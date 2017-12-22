using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeClassStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 테스트할 때는 오늘 날짜로 바꿔서 실행
            DateTime birthday = new DateTime(2017, 2, 20);

            if(birthday == DateTime.Today)
            {
                var client = new WebClient();
                // 테스트 할 때는 적당한 메시지가 있는 URI로 바꿔서 실행
                //var message = client.DownloadString("http://www.naver.com");
                //Console.WriteLine(message);
                Console.WriteLine("{0:yyyy/MM/dd},생일 축하해", DateTime.Today);
            }
        }
    }
}
