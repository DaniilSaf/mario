using UnityEngine;

public class floatbar : MonoBehaviour,IFloat
{
    private float m_Max, m_Width;
    
    public listenResource m_Listener;
    void Start()
    {
        m_Max = Resource.Find(m_Listener.m_res).GetMaxValue();
        m_Width = GetComponent<RectTransform>().rect.width;
    }

    public void Use(float value)
    {
        transform.localPosition = new Vector3(
            (value / m_Max-1) * m_Width,
            0,
            0);
    }
}
