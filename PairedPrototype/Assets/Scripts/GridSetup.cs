using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSetup : MonoBehaviour
{

    [SerializeField] private Grid _grid;

    // Start is called before the first frame update
    void Start()
    {
        //var worldPosition = _grid.GetCellCenterWorld(new Vector3Int(0, 1));
        //Instantiate(_tilePrefab, worldPosition, Quaternion.identity);
        //Debug.Log(worldPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
