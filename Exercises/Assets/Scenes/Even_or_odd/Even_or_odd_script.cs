using Unity.VisualScripting;
using UnityEngine;

public class Even_or_odd_script : MonoBehaviour
{
    public string player_1;
    public string player_2;

    public int player_1_number;
    public int player_2_number;

    public bool is_player_1_even;
    int players_sum;

    void Start()
    {
        players_sum = player_1_number + player_2_number;

        if (is_player_1_even && players_sum % 2 == 0)
        {
            Debug.Log(player_1 + " is the winner!");
        }

        else if ((is_player_1_even == true) && players_sum % 2 == 1)
        {
            Debug.Log(player_2 + " is the winner!");
        }

        else if ((is_player_1_even == false) && players_sum % 2 == 0)
        {
            Debug.Log(player_2 + " is the winner!");
        }

        else if ((is_player_1_even == false) && players_sum % 2 == 1)
        {
            Debug.Log(player_1 + " is the winner!");
        }

    }
}
