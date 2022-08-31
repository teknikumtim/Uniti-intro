using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coin == null)
        {
            coin = Instantiate(coinPrefab);
            Vector3 position = Vector3.one;
            position.x = Random.Range(-13f, 13f);
            position.z = Random.Range(-13f, 13f);
            coin.transform.position = position;
        }
    }
}
