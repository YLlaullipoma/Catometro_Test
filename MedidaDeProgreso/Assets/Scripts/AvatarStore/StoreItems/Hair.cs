using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour {
    private int hairCode;
    private Color hairColor;
    private bool isLock;
    private int price;

    public int HairCode { get => hairCode; set => hairCode = value; }
    public Color HairColor { get => hairColor; set => hairColor = value; }
    public bool IsLock { get => isLock; set => isLock = value; }
    public int Price { get => price; set => price = value; }
}