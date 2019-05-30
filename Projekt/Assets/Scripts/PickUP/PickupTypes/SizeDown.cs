using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDown : MonoBehaviour, IPickUpAction
{

    public void runAction(GameObject player)
    {
        if (player.transform.localScale.x > 1 || player.transform.localScale.y > 1  || player.transform.localScale.z > 1)
            player.transform.DOScale(player.transform.localScale/ 4,5f);
    }

}
