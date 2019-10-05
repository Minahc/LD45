using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Details : MonoBehaviour {

	public Vector2 nearestDetail (Vector2 pos, TileBase item)	{
		Tilemap tilemap = GetComponent<Tilemap>();
		BoundsInt bounds = tilemap.cellBounds;
		TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

		for (int x = bounds.x+1; x < bounds.size.x; x++) {
			for (int y = bounds.y+1; y < bounds.size.y; y++) {
				TileBase tile = allTiles[x + y * bounds.size.x];
				if (tile == item) {
					Debug.Log(x + " " + y);
					return tilemap.CellToWorld(new Vector3Int(x, y, 0));
				}
			}
		}

		return Vector2.zero*float.NaN;
	}
}
