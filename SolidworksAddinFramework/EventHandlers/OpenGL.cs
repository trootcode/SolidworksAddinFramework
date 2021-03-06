using System.Runtime.InteropServices;

public static class OpenGl
{
    [DllImport("opengl32")]
    public static extern void glBegin(int mode);
    [DllImport("opengl32")]
    public static extern void glEnd();
    [DllImport("opengl32")]
    public static extern void glVertex3f(float x, float y, float z);

    [DllImport("opengl32")]
    public static extern void glLineWidth(int width);
}