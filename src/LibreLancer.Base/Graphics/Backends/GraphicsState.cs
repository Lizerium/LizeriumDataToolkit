/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 апреля 2026 09:42:08
 * Version: 1.0.2452
 */

using System.Numerics;

namespace LibreLancer.Graphics.Backends;

internal struct GraphicsState
{
    public bool DepthEnabled;
    public bool Wireframe;
    public Color4 ClearColor;
    public ushort BlendMode;
    public bool BlendEnabled;
    public bool CullEnabled;
    public CullFaces CullFaces;
    public bool ColorWrite;
    public bool DepthWrite;
    public bool ScissorEnabled;
    public Rectangle ScissorRect;
    public int DepthFunction;
    public Vector2 DepthRange;
    public Rectangle Viewport;
    public Vector2 PolygonOffset;
    public IRenderTarget RenderTarget;
    public IShader Shader;
}
