using UnityEngine;

public class DrawMesh : MonoBehaviour
{
    private Mesh mesh;
    private Vector3 lastmousePosition;

    private void Awake(){}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mesh = new Mesh();

            Vector3[] vertices = new Vector3[4];
            Vector2[] uv = new Vector2[4];
            int[] triangles = new int[6];

            vertices[0] = GetMouseWorldPosition();
            vertices[1] = GetMouseWorldPosition();
            vertices[2] = GetMouseWorldPosition();
            vertices[3] = GetMouseWorldPosition();

            uv[0] = Vector2.zero;
            uv[1] = Vector2.zero;
            uv[2] = Vector2.zero;
            uv[3] = Vector2.zero;

            triangles[0] = 0;
            triangles[1] = 3;
            triangles[2] = 1;

            triangles[3] = 1;
            triangles[4] = 3;
            triangles[5] = 2;

            mesh.vertices = vertices;
            mesh.uv = uv;
            mesh.triangles = triangles;
            mesh.MarkDynamic();

            GetComponent<MeshFilter>().mesh = mesh;

            lastmousePosition = GetMouseWorldPosition();
        }

        if (Input.GetMouseButton(0)) 
        {
            float minDist = 1f;
            if (Vector3.Distance(GetMouseWorldPosition(), lastmousePosition) > minDist)
            {
                Vector3[] vertices = new Vector3[mesh.vertices.Length + 2];
                Vector2[] uv = new Vector2[mesh.uv.Length + 2];
                int[] triangles = new int[mesh.triangles.Length + 6];

                mesh.vertices.CopyTo(vertices, 0);
                mesh.uv.CopyTo(uv, 0);
                mesh.triangles.CopyTo(triangles, 0);

                int vIndex = vertices.Length - 4;
                int vIndex0 = vIndex + 0;
                int vIndex1 = vIndex + 1;
                int vIndex2 = vIndex + 2;
                int vIndex3 = vIndex + 3;

                Vector3 mouseForwarfVector = (GetMouseWorldPosition() - lastmousePosition).normalized;
                Vector3 normal2D = new Vector3(0, 0, -1f);
                float lineThickness = 1f;
                Vector3 newVertexUp = GetMouseWorldPosition() + Vector3.Cross(mouseForwarfVector, normal2D) * lineThickness;
                Vector3 newVertexDown = GetMouseWorldPosition() + Vector3.Cross(mouseForwarfVector, normal2D * -1f) * lineThickness;

                vertices[vIndex2] = newVertexUp;
                vertices[vIndex3] = newVertexDown;

                uv[vIndex2] = Vector2.zero;
                uv[vIndex3] = Vector2.zero;

                int tIndex = triangles.Length - 6;

                triangles[tIndex + 0] = vIndex0;
                triangles[tIndex + 1] = vIndex2;
                triangles[tIndex + 2] = vIndex1;

                triangles[tIndex + 3] = vIndex1;
                triangles[tIndex + 4] = vIndex2;
                triangles[tIndex + 5] = vIndex3;

                mesh.vertices = vertices;
                mesh.uv = uv;
                mesh.triangles = triangles;

                lastmousePosition = GetMouseWorldPosition();
            }
        }
    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 vec = worldCamera.ScreenToWorldPoint(screenPosition);
        return vec;
    }
}
