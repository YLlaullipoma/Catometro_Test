using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month {
    private string monthName;
    private float currentMothPoints;
    private int monthDays;

    public string MonthName { get => monthName; set => monthName = value; }
    public float CurrentMothPoints { get => currentMothPoints; set => currentMothPoints = value; }
    public int MonthDays { get => monthDays; set => monthDays = value; }
}
