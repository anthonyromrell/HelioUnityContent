
public class Bird : Animal {
	
	public override void Start (){
		base.Start();
		Fly();
	}

	public override void Walk () {
		print("Walk with two legs");
	}

	void Fly () {
		print("Fly");
	}

}
