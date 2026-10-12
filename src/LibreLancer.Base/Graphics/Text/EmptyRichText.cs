/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2026 11:03:30
 * Version: 1.0.2626
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
