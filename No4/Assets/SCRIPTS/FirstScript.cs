
using UnityEngine;

namespace LEO
{
    /// <summary>
    /// 第一腳本
    /// 2022.10.13
    /// </summary>

    public class FirstScript : MonoBehaviour
    {
        #region 註解區域
        //縮排快捷鍵:Tab
        //格式化:ctrl+K+D

        //單行註解

        /*多行註解
         *多行註解
         *
         */

        //A a 大小寫為不相同的字   
        #endregion

        #region 事件區域
        //喚醒事件:遊戲開始時執行一次
        private void Awake()
        {
            print("哈囉,沃德~");    
        }
        //開始事件:在Awake後執行一次
        private void Start()
        {
            print("<color=red>開始事件</color>");
        }
        //更新事件:在Start後執行，執行速率為60FPS
        private void Update()
        {
            print("<color=green>更新事件</color>");
        }
        #endregion
    }

}


