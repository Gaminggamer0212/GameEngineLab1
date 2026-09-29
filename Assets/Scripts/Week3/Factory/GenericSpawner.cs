using UnityEngine;

public class GenericSpawner : GenericFactory
{
    public Transform[] spawnPoints;
    
    public override GameObject SpawnGameObject(GameObject prefab)
    {
        //this line was given to me by rider's code auto complete, it looks good so I did not change it
        GameObject go = Instantiate(prefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
        return go;
    }
}
