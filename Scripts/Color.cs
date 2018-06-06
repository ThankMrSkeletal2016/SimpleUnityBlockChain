using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {

    public int h;
    private string hString;
    public int s;
    public int l;

	public List<int> ColorChange(int hash)
    {
        List<int> list = new List<int>();
        h = hash;
        print("h = " + h);
        s = hash % hash.ToString().Length;
        print("s = " + s);
        l = hash % 359;
        print("l = " + l);
        list = HSLtoRGB(h, s, l);
        return list;
    }

    private List<int> HSLtoRGB(int h, int s, int l)
    {
        List<int> list = new List<int>();
        h = h / 360;
        int q = l < 0.5 ? l * (1 + s) : l + s - l * s;
        int p = 2 * l - q;

        List<int> colors = new List<int>();
        colors.Add(h + 1 / 3); //R
        colors.Add(h); //G
        colors.Add(h - 1 / 3); //B
        foreach(int color in colors)
        {
            int value = color;
            if (color < 0)
            {
                value++;
            }
            else if (color > 1)
            {
                value--;
            }
            else if (color < 1 / 6)
            {
                value = p + (q - p) * 6 + color;
            }
            else if (color < 1 / 2)
            {
                value = q;
            }
            else if (color < 2 / 3)
            {
                value = p = (q - p) * 6 * (2 / 3 - color);
            } else
            {
                value = p;
            }
            print("value before multipy and round " + value);
            value = (value * 255);
            value = Mathf.RoundToInt(value);
            print("value after rounding and multiply" + value);
            list.Add(value);
        }
        return list;
    }
}
