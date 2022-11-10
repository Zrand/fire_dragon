
using UnityEngine;
namespace leo
{///<summary>
 ///移動系統   
 ///</summary> 
public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(10,-10)]
        private float speed = -3.5f;

        private void Update()
        {
            //  transfrom指此物件的 Transfrom 元件
            //  Transfrom( x, y, z) 位移
            //  *乘法
            //  Time.deltaTime每幀時間
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}


        