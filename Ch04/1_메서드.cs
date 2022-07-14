using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 
 * 내용 : 메서드(Method)
 * -일련의 코드 로직을 재활용하기 위해 모듈화된 구조체
 * -메서드는 정의(Define)하고 호출(call)
 */
namespace Ch02
{
    internal class _3_연산자
    {
        static void Main(string[] args)
        {
            //메서드 호출
            int y1 = f(1);
            int y2 = f(2);
            int y3 = f(3);

            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);
            Console.WriteLine("y3 : " + y3);

            //메서드 호출
            int t1 = sum(1, 10);
            int t1 = sum(1, 100);
            int t1 = sum(start:1, end:1000);

            Console.WriteLine("")

            

        }//end of main

        //메서드 정의
        public static int f(int x)
        {
            int y = 2 * x + 3;
            return y;
        }

        //메서드 정의 (메서드 틀을 만드는걸 선언 내용을 적는게 정의, 메서드 첫글자는 대문자다, 합수와 클래스는 소문자 적는 룰이있다.
        public static int sum(int start, int end)
        {
            int total = 0;

            for (int k-start; k <= end ; k++)
                {
                total += k;
                }

            return total;
            



        }
    }
} 