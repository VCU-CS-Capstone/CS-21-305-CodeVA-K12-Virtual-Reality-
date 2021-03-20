using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfinitePieChartManager : MonoBehaviour
{
    public GameObject WedgePrefab;
    
    private List<Wedge> _Wedges = new List<Wedge>();

    // Start is called before the first frame update
    void Start()
    {
        LoadWedges();
        UpdateWedges();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadWedges()
    {
        GameObject wedgeObj = Instantiate(WedgePrefab);
        wedgeObj.transform.SetParent(transform);

        wedgeObj.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
        wedgeObj.SetActive(false);
        Image img = wedgeObj.GetComponent<Image>();
        float fillValue = 12.0f;

        img.color = new Color(0.5f, 0.1f, 1.0f);

        _Wedges.Add(new Wedge(wedgeObj, img, fillValue, img.color));
    }

    private void UpdateWedges()
    {
        float prevZ = 0;

        for(int i = _Wedges.Count - 1; i >= 0; i--)
        {
            prevZ = UpdateWidgetAt(i, prevZ);
        }
    }

    private float UpdateWidgetAt(int index, float prevZ = 0)
    {
        Wedge wedge = _Wedges[index];
        float zRot = prevZ / 360;// Calculate Z
        prevZ = zRot;
        Vector3 rot = wedge.Image.transform.eulerAngles;
        rot.z += zRot;

        wedge.Image.fillAmount = wedge.FillValue / 360;
        wedge.Obj.SetActive(true);
        return prevZ;
    }
}

internal class Wedge
{
    internal GameObject Obj { get; private set; }
    internal Image Image { get; private set; }
    internal float FillValue { get; set; }
    internal Color Color { get; private set; }

    public Wedge(GameObject obj, Image image, float fillValue, Color color)
    {
        Obj = obj;
        Image = image;
        FillValue = fillValue;
        Color = color;
    }
}