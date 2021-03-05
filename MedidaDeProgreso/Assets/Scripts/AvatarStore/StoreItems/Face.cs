using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour {
    private int faceCode;
    private Color faceColor;
    private bool isLock;
    private int price;

    public int FaceCode { get => faceCode; set => faceCode = value; }
    public Color FaceColor { get => faceColor; set => faceColor = value; }
    public bool IsLock { get => isLock; set => isLock = value; }
    public int Price { get => price; set => price = value; }
}