
public struct PlayerData {
	
	public int health {get;}
	public int speed {get; set;}

	public enum GameStates
	{
		LOADING,
		STARTING,
		PLAYING,
		ENDING
	}

	public static GameStates CurrentState = GameStates.STARTING;
}
