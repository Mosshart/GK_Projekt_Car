using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCollision : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.tag == "Player")
        {
            // dodac particla przy znikaniu zeby bylo cool
            // uruchomic bonus na playerze (odpowiedni do danego pickupa
            gameObject.GetComponent<PickUpScript>().action.runAction(other.gameObject.transform.GetChild(0).gameObject);
            //dodac pkt 
            Destroy(gameObject);
        }
    }
}
