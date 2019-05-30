using UnityEngine;
using UnityEditor;

public interface IPickUpAction
{
    void runAction(GameObject player);
}