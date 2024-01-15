using GitActionTest_Lib;
using System;

namespace GitActionTest_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GitActionTest_Main 입니다. 프로그램이 시작 되었습니다.");
            Console.WriteLine("Library를 호출해보겠습니다.");


            Introduce lib = new Introduce();
            lib.Init();

            Console.WriteLine("Library가 종료 되었습니다.");
            Console.WriteLine("이제 Main 저도 물러나 보겠습니다. 안뇽!");
        }
    }
}
