using UnityEngine;
using UnityEngine.UI;

public class itemBox : MonoBehaviour
{
    public bool haveItem;        //記錄格子上有沒有物品
    public string itemName;      //格子上物理的名稱
    public item Item;

    public void OnTriggerEnter2D(Collider2D collision)  //進入Trigger
    {
        if(GetComponent<itemBox>().haveItem==false)   //如果格子上沒東西
        {
            GetComponent<itemBox>().haveItem=true;    //itemBox的haveItem改為true
            GetComponent<Image>().color=Color.blue;   //那一格改為顯示藍色
            itemName = collision.ToString();          //背包格的物品=拉進去的物品
            print(collision);
        }
        else
        {
            GetComponent<Shadow>().enabled=true;                         //陰影啟動
            GetComponent<Shadow>().effectColor=new Color(1,0,0,0.5f);    //那一格陰影改為顯示紅色
            GetComponent<Shadow>().effectDistance=new Vector2(-7,-7);    //改陰影位置
        }
    }

    public void OnTriggerExit2D(Collider2D collision)       //離開Trigger
    {
        GetComponent<Image>().color=Color.white;   //那一格改為顯示白色
        GetComponent<Shadow>().enabled=false;      //陰影關閉 
        if(itemName == collision.ToString())       //如果格子上的原物品拖走後
        {
            GetComponent<itemBox>().haveItem=false;    //itemBox的haveItem改為false
        }
    }
}




