using UnityEngine;
using System.Collections;
public class HealthPowerUP : PowerUp
{

    public bool canInput = true;
    public float inputTime = 0.1f;
    protected override void RunPower()
    {
        base.RunPower();
         StartCoroutine(CheckInput());
    }


    IEnumerator CheckInput()
    {
        while (canInput)
        {
            yield return new WaitForSeconds(inputTime);
            if (Input.GetKeyDown(KeyCode.A))
            {
                print("a");
            } else
            {
                print("No Input");
            }
        }
        print("Game Over");
    }
}
