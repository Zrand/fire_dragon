
using UnityEngine;
namespace leo 
{   
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefaExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nametarget;

        //碰撞開始時執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            //如果碰到的物件名稱 包含 nameTarget 就爆炸並刪除
            if (collision.gameObject.name.Contains(nametarget))
            {
                //生成爆炸預製物 座標與角度 跟此物件相同
                Instantiate(prefaExplosion, transform.position, transform.rotation);

                //刪除 Destroy
                //此物件 gameObject
                Destroy(gameObject);
            }
        }
        
        //碰撞離開時執行一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        
        //碰撞時持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    } 
}
