using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind : MonoBehaviour, IPickUpAction
{
    GameObject playerObj;
    public void runAction(GameObject player)
    {
        playerObj = player.transform.parent.gameObject;
        playerObj.GetComponent<FadeScript>().fade = true;
    }

}
