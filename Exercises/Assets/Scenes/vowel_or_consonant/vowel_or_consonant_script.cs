using UnityEngine;

public class vowel_or_consonant_script : MonoBehaviour
{
    public string letter = "a";
    
    void Start()
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log("The leter " + letter + " is a vowel");
        }

        else {
            Debug.Log("The leter " + letter + " is a consonant");
        }
    }


}
