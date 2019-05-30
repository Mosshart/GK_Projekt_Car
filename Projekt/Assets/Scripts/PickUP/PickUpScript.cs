using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {

    [System.Serializable]
    public enum BonusKind
    {
        sizeUp,
        sizeDown,
        blind,
        slowDown,
        speedUp,
        SuddenDeath,
        timeStop        
    }
    public BonusKind pieceType;
    
    public IPickUpAction action;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void Awake()
    {
        actionPicker();
    }
    void actionPicker()
    {
        if (BonusKind.blind == pieceType)
            action = new Blind();
        else if (BonusKind.sizeDown == pieceType)
            action = new SizeDown();
        else if (BonusKind.sizeUp == pieceType)
            action = new SizeUp();
        else if (BonusKind.slowDown == pieceType)
            action = new SlowDown();
        else if (BonusKind.speedUp == pieceType)
            action = new SpeedUp();
        else if (BonusKind.SuddenDeath == pieceType)
            action = new SuddenDeath();
        else if (BonusKind.timeStop == pieceType)
            action = new TimerStop();
    }
    

}
