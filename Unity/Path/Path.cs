using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    public Vector3[] points;
    public bool isDebugMode;//çizgiyi yok etmek için görüntüsünü 
    public float minFark;//eşik değer eğer nokta ile oyuncu arasıındaki fark bu değerden küçük ise indexi,yolu değiştir.

    //public int Length()
    //{
    //    return points.Length;
    //}

    public int Length { get { return points.Length; } }

    public Vector3 GetPoint(int index)//bu yolu karşı sınıfa vermek için fonksiyon yazılır. o anki nokta bize lazım olacak.
    {
        return points[index];//bir sonraki  hedef noktayı belirtmek için kullanılır.
    }
    
    

    private void OnDrawGizmos()//oyun içerisinde yazdığınız çizgileri gösterir.
    {
        if (!isDebugMode) return;//debug modda değilse çizgiler görünmesin.

        for (int i = 0; i < points.Length - 1; i++)
        {
            Debug.DrawLine(points[i], points[i + 1], Color.red);
        }
    }

}
