using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12
 * 이름 : 정성한
 * 내용 : 메서드 오버로드 실습하기 ㄱ재 p275
 * 메서드 오버로드
 * -같은 이름을 가진 메서드를 매개변수로 구분한 메서드
 * 메서드 반환값은 오버로드 메서드에 영향을 미치지 않음
 * 
 */
namespace Ch02
{
    internal class _3_연산자
    {
        static void Main3(string[] args)
        {
            int r1 = Plus(1, 2);
            int r1 = Plus(1, 2, 3);
            double r3 = Plus(1.1, 2.2);


        }//end of Main

        public static int Plus(int a, int b) 
        {
            return a + b;
        }

        public static int Plus(int a, int b, int c) 
        {
            return a + b + c;
        }
        
        public static double Plus(double a, double b) 
        {
            return a + b;
        }

        
        public static void string(string a, string b) 
        {
            return a + b;
        }


    }
}
