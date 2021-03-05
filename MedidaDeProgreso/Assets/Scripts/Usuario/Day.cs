using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day {
    private int numDate;
    private float currentDayPoints;
    private float totalDayPoints;
    private float besDayPoints;

    public int NumDate { get => numDate; set => numDate = value; }
    public float CurrentDayPoints { get => currentDayPoints; set => currentDayPoints = value; }
    public float TotalDayPoints { get => totalDayPoints; set => totalDayPoints = value; }
    public float BesDayPoints { get => besDayPoints; set => besDayPoints = value; }
}