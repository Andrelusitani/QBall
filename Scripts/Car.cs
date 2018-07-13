using UnityEngine;
using System.Collections;

public class camaro : MonoBehaviour {

    [SerializeField] private Transform SpawnPoint;

    // Use this for initialization
    void Start () {
        gameObject.transform.position = SpawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void BackToSpawn()
    {
        Vector3 spawnerPosition = GameObject.FindGameObjectWithTag("Spawner").transform.position;
        transform.position = spawnerPosition;
    }
}

