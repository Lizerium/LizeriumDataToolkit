/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июля 2026 06:53:44
 * Version: 1.0.2536
 */

namespace LibreLancer.Graphics.Text;

class EmptyRichText : BuiltRichText
{
    public override void Recalculate(float width)
    {
    }

    public override float Height => 0;

    public override Rectangle GetCaretPosition(int layoutIndex, int textPosition)
    {
        return new Rectangle();
    }

    public override void Dispose()
    {
    }
}
