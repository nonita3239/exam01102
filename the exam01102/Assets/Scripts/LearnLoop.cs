using UnityEngine;

namespace YANG
{
    /// <summary>
    /// 認識迴圈:重複執行程式
    /// for / while / do while /foreach
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            for (int i = 0; i < 10; i++)
            {
                print("for迴圈內容:" + i);
            }

            for (int number = 0; number < 5; number++)
            {
                print("迴圈:" + number);
            }

            if (true)
            {
                print("判斷式");
            }

            int count = 0;

            while (count < 5)
            {
                print("()內的布林值為true就會持續執行。");
                print("while 迴圈數字:" + count);
                count++;
            }
        }
    }

}
