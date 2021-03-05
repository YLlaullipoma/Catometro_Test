using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private int bgCode;
    private bool isLock;
    private int price;

    public int BgCode { get => bgCode; set => bgCode = value; }
    public bool IsLock { get => isLock; set => isLock = value; }
    public int Price { get => price; set => price = value; }
}
