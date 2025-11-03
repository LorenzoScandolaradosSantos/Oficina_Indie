using UnityEngine;

public class Triangles_script : MonoBehaviour
{
    public float side1;
    public float side2;
    public float side3;
    void Start()
    {
        if (side1 == side2 && side2 == side3)
        {
            Debug.Log("It is an equilateral  triangle");
        }

        else if (side1 == side3 || side1 == side2)
            {
                Debug.Log("It is an isosceles triangle");
            }

        else if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                Debug.Log("It is a scalene triangle"); 
            }
        }
    }

