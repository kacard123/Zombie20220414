using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour, IItem
{
    public int ammo = 30;

    public void Use(GameObject target)
    {
        //throw new System.NotImplementedException();       예외처리니까 빼고 작성하기 안하면 문제생김
        Debug.Log("탄알이 증가했다 : " + ammo);        // target의 총알을 장전하는 처리
    }

   

}
