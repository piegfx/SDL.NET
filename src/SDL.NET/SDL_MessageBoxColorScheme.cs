using System;
using System.Runtime.InteropServices;

namespace SDL.NET
{
    public partial struct SDL_MessageBoxColorScheme
    {
        [NativeTypeName("SDL_MessageBoxColor[5]")]
        public _colors_e__FixedBuffer colors;

        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
            public SDL_MessageBoxColor e1;
            public SDL_MessageBoxColor e2;
            public SDL_MessageBoxColor e3;
            public SDL_MessageBoxColor e4;

            public ref SDL_MessageBoxColor this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<SDL_MessageBoxColor> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
        }
    }
}
