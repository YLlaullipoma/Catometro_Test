using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge {
    private string challengeName;
    private float challengePoints;
    private float maxChPoints;
    private float minChPoints;
    private bool canBeDelete;

    public string ChallengeName { get => challengeName; set => challengeName = value; }
    public float ChallengePoints { get => challengePoints; set => challengePoints = value; }
    public float MaxChPoints { get => maxChPoints; set => maxChPoints = value; }
    public float MinChPoints { get => minChPoints; set => minChPoints = value; }
    public bool CanBeDelete { get => canBeDelete; set => canBeDelete = value; }
}
