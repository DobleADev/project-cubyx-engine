// public struct Vector2
// {
//     public Vector2(float x, float y)
//     {
//         this.x = x;
//         this.y = y;
//     }
//     public float x;
//     public float y;
//     public static Vector2 zero = new Vector2(0, 0);
//     public static Vector2 one = new Vector2(1f, 1f);
//     public static Vector2 left = new Vector2(-1f, 0);
//     public static Vector2 right = new Vector2(1f, 0);
//     public static Vector2 up = new Vector2(1f, 0);
//     public static Vector2 down = new Vector2(-1f, 0);

//     public static Vector2 operator +(Vector2 a, Vector2 b)
//     {
//         Vector2 sum;
//         sum.x = a.x + b.x;
//         sum.y = a.y + b.y;
//         return sum;
//     }

//     public static Vector2 operator -(Vector2 a, Vector2 b)
//     {
//         Vector2 subtract;
//         subtract.x = a.x - b.x;
//         subtract.y = a.y - b.y;
//         return subtract;
//     }

//     public static Vector2 operator *(float a, Vector2 b)
//     {
//         b.x *= a;
//         b.y *= a;
//         return b;
//     }

//     public readonly float GetMagnitude() => MathF.Sqrt(MathF.Pow(x, 2) + MathF.Pow(y, 2));
// }