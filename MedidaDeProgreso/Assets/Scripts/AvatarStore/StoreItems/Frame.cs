using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour {
    private int frameCode;
    private bool isLock;
    private int price;

    public int FrameCode { get => frameCode; set => frameCode = value; }
    public bool IsLock { get => isLock; set => isLock = value; }
    public int Price { get => price; set => price = value; }
}