using System.Runtime.InteropServices;

namespace SDL.NET
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_WindowShapeParams
    {
        [FieldOffset(0)]
        [NativeTypeName("Uint8")]
        public byte binarizationCutoff;

        [FieldOffset(0)]
        public SDL_Color colorKey;
    }
}
