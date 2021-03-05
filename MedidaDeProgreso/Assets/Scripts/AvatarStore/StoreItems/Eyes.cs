using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {
    private int eyesCode;
    private Color eyesColor;
    private bool isLock;
    private int price;

    public int EyesCode { get => eyesCode; set => eyesCode = value; }
    public Color EyesColor { get => eyesColor; set => eyesColor = value; }
    public bool IsLock { get => isLock; set => isLock = value; }
    public int Price { get => price; set => price = value; }
}