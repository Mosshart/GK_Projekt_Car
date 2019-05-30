using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PickUpAnim : MonoBehaviour
{ 

    // Use this for initialization
    void Start () {        
        StartCoroutine("bounce");
    }
	
	// Update is called once per frame
	void Update () {
        spinAnim();      
    }

    void spinAnim() {
        transform.Rotate(Vector3.up, Time.deltaTime * 100);
    }

    void bounceAnim() {
        transform.DOLocalJump(transform.position, 0.20f, 9999, 10f, false).SetEase(Ease.Linear).WaitForCompletion();        
    }

    IEnumerator bounce()
    {

        Vector3 endPos = transform.position + new Vector3(0, 0.15f, 0);        
        yield return gameObject.transform.DOLocalJump(transform.position, 0.20f, 20, 10, false).SetEase(Ease.Linear).WaitForCompletion();

        StartCoroutine("bounce");
    }
}
