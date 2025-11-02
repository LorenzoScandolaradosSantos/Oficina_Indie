using UnityEngine;

public class Biggest_number_script : MonoBehaviour
{
    public int number_1 = 3;

    public int number_2 = 2;

    public int number_3 = 1;

    int biggest_number = 0;

    void Start()
    {
        biggest_number = number_1;

        if (number_2 > biggest_number)
        {
            biggest_number = number_2;
        }

        if (number_3 > biggest_number)
        {
            biggest_number = number_3;
        }


        Debug.Log( "T he biggest number is: " + biggest_number );
    }

}

