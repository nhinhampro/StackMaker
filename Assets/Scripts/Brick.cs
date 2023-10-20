using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{   
    public enum Colors { ORANGE = 1, GREEN = 2, PURPLE = 3 }

    [SerializeField] public Colors color;
    [SerializeField] public GameObject brickObject;

    //public Brick(GameObject brickObject)
    //{
    //    this.brickObject = brickObject;
    //}
}

