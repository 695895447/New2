using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class item : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Vector3 itemStart_Pos; //物件的起始位置
    public Vector3 Pos;           //要更改的座標

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemStart_Pos=GetComponent<Transform>().position;   //記錄物件的起始位置
        Pos=itemStart_Pos;             //要更改的座標=起始位置
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position =eventData.position;     //物件跟着滑鼠移動
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position=Pos;                 //物件位置=要更改的位置
    }

    public void OnTriggerEnter2D(Collider2D collision)     //進入Trigger 
    {
        if(collision.GetComponent<itemBox>().haveItem==false)  //如果格子上沒東西
        {
            Pos=collision.transform.position;               //要更改的位置=格子的位置
        }
    }

    public void OnTriggerExit2D(Collider2D collision)       //離開Trigger
    {
        Pos=itemStart_Pos;             //要更改的座標=起始位置
    }
}
