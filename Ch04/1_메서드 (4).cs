using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 
 * 내용 : 
 * 
 * 전역별수
 * 모든 메서드에서 참조할 수 있는 변수
 * 객체지향 프로그래밍에서 전역변수는 멤버변수(속성) 이다.
 * 
 * 지역변수
 * 특정ㅇ 메서드에서 선언한 변수로 해당 메서드에서만 참조할 수 있다.
 * 해당 메서드가 끝나면 stack에서 사라진다.
 * 
 * 
 * 
 */

namespace Ch02
{
    internal class _3_연산자
    {

        //전역변수 
        static void Main(string[] args)
        {



        }//end of Main

        Public static int sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;

            }
            return totla += k;
        }
    }
} 