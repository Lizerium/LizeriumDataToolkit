/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:39:36
 * Version: 1.0.2429
 */

using System;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace LibreLancer.Graphics;

public sealed class ShaderBundle
{
    public uint FeatureMask { get; private set; }

    private Shader[] shaders;

    public Shader Get<T>(T flags) where T : unmanaged, Enum =>
        Get(Unsafe.As<T, uint>(ref flags));

    public Shader Get(uint flags) => shaders[(int)(flags & FeatureMask)];

    private ShaderBundle(RenderContext context, BytecodesBundle bundle)
    {
        shaders = new Shader[bundle.FeatureMask == 0 ? 1 : (bundle.FeatureMask + 1)];
        FeatureMask = bundle.FeatureMask;
        for (int i = 0; i < bundle.ShaderCount; i++)
        {
            shaders[(int)bundle.GetFeatures(i)] = new Shader(context, bundle.GetShader(i));
        }
    }

    public static ShaderBundle FromResource<T>(RenderContext context, string resourceName)
    {
        using var stream = typeof(T).Assembly.GetManifestResourceStream(resourceName);
        return FromStream(context, stream);
    }

    public static ShaderBundle FromStream(RenderContext context, Stream stream) =>
        new(context, BytecodesBundle.FromStream(stream));
}
