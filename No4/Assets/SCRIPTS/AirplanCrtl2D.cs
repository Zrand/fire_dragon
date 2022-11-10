using UnityEngine;
namespace leo
{
    /// <summary>
    /// 2D飛機控制器
    /// </summary>
    public class AirplanCrtl2D : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite PictureUp;
        [SerializeField] private Sprite PictureMiddle;
        [SerializeField] private Sprite PictureDown;
        [SerializeField,Header("圖片渲染元件")]
        private SpriteRenderer spr;
        private void Update()
        {
            //上下WS - Vertical
            //上w +1
            //下s -1
            //沒按 0
            //輸入.取得軸向值(軸向名稱) - 取得玩家按下按鍵的值
            float v = Input.GetAxis("Vertical");
            // print("<color=red>玩家上下按鍵:" + v + "</color>");

            //左右AD - Horizontal
            float h = Input.GetAxis("Horizontal");
           

            transform.Translate(speedHorizontal * Time.deltaTime*h, 
                                speedVertical * Time.deltaTime*v,
                                0);
            //如果 v 大於 0 往上
            if (v > 0)
            {
                //print("往上");

                spr.sprite = PictureUp;
            }
            //如果 v 小於 0 往下
            if (v < 0)
            {
                //print("往下");

                spr.sprite = PictureDown;
            }
            //如果 v 等於 0 中間
            if (v==0)
            {
                //print("中間");

                spr.sprite = PictureMiddle;
            }
        }

    } 
}

