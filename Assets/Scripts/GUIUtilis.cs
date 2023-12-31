using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SonicFramework
{
	public static class GUIUtilis
	{
		public static void DrawQuad(Rect position, Color color) 
		{
			Texture2D texture = new Texture2D(1, 1);
			texture.SetPixel(0,0,color);
			texture.Apply();
			GUI.skin.box.normal.background = texture;
			GUI.Box(position, GUIContent.none);
		}
	}
}

