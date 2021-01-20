using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MapObject
{
    public int Image;

    public override void Start()
    {
        base.Start();
        Blocking = false;
        NameLabel.gameObject.SetActive(false);
    }
}
