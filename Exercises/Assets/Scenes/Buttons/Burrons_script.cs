using UnityEngine;

public class Click_burron_script : MonoBehaviour
{
    int clickValue = 1;

    int totalResources;

   

    public void click()
    {
        totalResources += clickValue;

        show();
    }

    public void upgrade(int price)
    {
        if (price <= totalResources)
        {
            clickValue += price/10;
            totalResources -= price;

            show();
        }
        else { Debug.Log("Insuficient resources! you have "+ totalResources + " but this upgrade costs " + price); }  
    }

    void show()
    {
        Debug.Log("Total of clicks: " + totalResources);
        Debug.Log("Click worht: " + clickValue);
    }
}
