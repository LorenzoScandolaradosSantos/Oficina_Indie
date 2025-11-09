using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Odds_or_evens_2_script : MonoBehaviour
{

    public TMP_Text player_1_display_name;

    public TMP_InputField player_1_name;
    public TMP_InputField player_1_number;
    public TMP_InputField player_1_choice;


    public int player_2_number;
    public TMP_Text player_2_display_number;

    
    public TMP_Text result;



    public void Play()
    {
        Player_2_action();

        player_1_display_name.text = player_1_name.text;


        if (player_1_choice.text == "odds" && ((int.Parse(player_1_number.text)) + player_2_number) % 2 == 1)
        {
            result.text = $"{player_1_name.text} won choosing {player_1_choice.text} and playing {player_1_number.text}!";
        }

        else if (player_1_choice.text == "odds" && ((int.Parse(player_1_number.text)) + player_2_number) % 2 == 0)
        {
            result.text = $"Player 2 won playing {player_2_number}!";
        }

        else if (player_1_choice.text == "evens" && ((int.Parse(player_1_number.text)) + player_2_number) % 2 == 0)
        {
            result.text = $"{player_1_name.text} won choosing {player_1_choice.text} and playing {player_1_number.text}!";
        }

        else if (player_1_choice.text == "evens" && ((int.Parse(player_1_number.text)) + player_2_number) % 2 == 1)
        {
            result.text = $"Player 2 won playing {player_2_number}!";
        }
    }



    void Player_2_action()
    {
        player_2_number = Random.Range(1, 6);
        player_2_display_number.text = player_2_number.ToString();
    }
}
