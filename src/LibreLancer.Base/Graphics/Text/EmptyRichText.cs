/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2026 12:06:31
 * Version: 1.0.2473
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
