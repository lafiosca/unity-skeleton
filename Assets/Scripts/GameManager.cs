using UnityEngine;

public class GameManager {
    protected Driver driver;
    protected static GameManager instance;

    protected void CreateGameObjects () {
        GameObject obj = Object.Instantiate(Prefabs.Driver, Vector3.zero, Quaternion.identity) as GameObject;
        driver = obj.GetComponent<Driver>();
	}

    public GameManager() {
        CreateGameObjects();
    }

    [RuntimeInitializeOnLoadMethod]
    public static void CreateGameManager() {
        instance = new GameManager();
    }
}