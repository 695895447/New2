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
            itemName = collision.ToString();
            print(collision);
        }
        else
        {
            collision.GetComponent<Image>().color=Color.red;    //那一格改為顯示
        }
    }

    public void OnTriggerExit2D(Collider2D collision)       //離開Trigger
    {
        GetComponent<Image>().color=Color.white;   //那一格改為顯示白色
        if(itemName == collision.ToString())
        {
            GetComponent<itemBox>().haveItem=false;    //itemBox的haveItem改為false
        }
    }
}











/*public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<itemBox>().haveItem==true)
        {
            GetComponent<Image>().color=Color.red;
        }
        else 
        {
            GetComponent<Image>().color=Color.blue;
        }
    }*/