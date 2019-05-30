using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SizeUp : MonoBehaviour, IPickUpAction
{
    
    public void runAction(GameObject player)
    {
        if(player.transform.localScale.x < 3 || player.transform.localScale.y < 3 || player.transform.localScale.z < 3)
            player.transform.DOScale(player.transform.localScale  + new Vector3(1, 1, 1f), 0.5f);
       
    }
}
