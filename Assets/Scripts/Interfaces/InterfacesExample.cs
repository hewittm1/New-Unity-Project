using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacesExample : MonoBehaviour {

	void Start () {
        InterceEx IEX = new InterceEx();
        IEX.Add();
        ((IAdd)IEX).Add();
        ((ISub)IEX).Sub();
	}
}
public interface IAdd
{
    void Add();
}

public interface ISub
{
    void Sub();
}

public class InterceEx: IAdd, ISub
{
    void IAdd.Add()
    {
        Debug.Log(4 + 4);
    }
    void ISub.Sub()
    {
        Debug.Log(5 - 4);
    }
    public void Add()
    {
        Debug.Log(1 + 1);
    }
    public void Sub()
    {
        Debug.Log(2 - 1);
    }
}
