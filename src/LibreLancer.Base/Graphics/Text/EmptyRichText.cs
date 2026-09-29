/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 сентября 2026 09:41:42
 * Version: 1.0.2613
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
