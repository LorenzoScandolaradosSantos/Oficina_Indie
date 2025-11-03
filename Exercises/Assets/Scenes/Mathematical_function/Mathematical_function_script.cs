using UnityEngine;

public class Mathematical_function_script : MonoBehaviour
{

    void Start()
    {
        Debug.Log(biggerThanAThousand(11,22,33));
    }


    bool biggerThanAThousand(int X, int Y, int Z)
    {

        int total = (X + Y) * Z;

        if (total > 1000)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
