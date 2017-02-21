using UnityEngine;

public class PowerUp : MonoBehaviour {

	public int powerLevel;
    public new string name;


    // Use this for initialization
    protected virtual void Start () {
		RunPower ();	
	}

    protected virtual void RunPower()
    {
//        print(powerLevel);
    }

}
