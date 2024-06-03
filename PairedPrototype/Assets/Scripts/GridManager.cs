using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    //[SerializeField] private Grid _grid;
    [SerializeField] private Tile _tilePrefab;
    [SerializeField] private int _width, _height;
    [SerializeField] private Transform _cam;

    // Start is called before the first frame update
    void Start()
    {
        //var worldPosition = _grid.GetCellCenterWorld(new Vector3Int(0, 1));
        //Instantiate(_tilePrefab, worldPosition, Quaternion.identity);
        //Debug.Log(worldPosition);
        //GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
            }
        }

        _cam.transform.position = new Vector3((float)_width/2 -0.5f, (float)_height/2 -0.5f, -10);
    }
}
