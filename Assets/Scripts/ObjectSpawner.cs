using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    [SerializeField] private float distancia = 2.5f;
    [SerializeField] private List<GameObject> objectPrefabs;
    private Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        foreach (var obj in objectPrefabs)
        {
            Vector3 pos = new Vector3();
            
            do 
            { pos = new Vector3(Random.Range(player.position.x, player.position.x + distancia),
                    Random.Range(player.position.y, player.position.y + distancia),
                    Random.Range(player.position.z, player.position.z + distancia));
                
            } while (pos.magnitude > player.position.magnitude + distancia);
            Instantiate(obj, pos, Quaternion.LookRotation(player.position - transform.position));
            yield return new WaitForSecondsRealtime(1);
        }    
    }
}
