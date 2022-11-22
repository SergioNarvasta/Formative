using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SistemaCPU01
{
    class Glass1
    {

       
         private const int DTT_COMPOSITED = (int)(1UL << 13);
        private const int DTT_GLOWSIZE = (int)(1UL << 11); 

        //Text format consts
        private const int DT_SINGLELINE = 0x00000020;
        private const int DT_CENTER = 0x00000001;
        private const int DT_VCENTER = 0x00000004;
        private const int DT_NOPREFIX = 0x00000800;

        //Const for BitBlt
        private const int SRCCOPY = 0x00CC0020;


        //Consts for CreateDIBSection
        private const int BI_RGB = 0;
        private const int DIB_RGB_COLORS = 0 ;//color table in RGBs

        private struct MARGINS
        {
           // public int m_Left;
         //   public int m_Right;
         //   public int m_Top;
           // public int m_Buttom;
        };

        private struct POINTAPI
        {
            public int x;
            public int y;
        };

        private struct DTTOPTS
        {
            public uint dwSize;
            public uint dwFlags;
            public uint crText;
            public uint crBorder;
            public uint crShadow;
            public int iTextShadowType;
            public POINTAPI ptShadowOffset;
            public int iBorderSize;
            public int iFontPropId;
            public int iColorPropId;
            public int iStateId;
            public int fApplyOverlay;
            public int iGlowSize;
            public IntPtr pfnDrawTextCallback;
            public int lParam;
        };

        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;


        };

        private struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
        };

        private struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        };

        private struct BITMAPINFO
        {
            public BITMAPINFOHEADER bmiHeader  ;
            public RGBQUAD bmiColors ;
        };


        //API declares
        [DllImport("dwmapi.dll")]
        private static extern void DwmIsCompositionEnabled(ref int enabledptr);
        [DllImport("dwmapi.dll")]
        private static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margin);


        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetDC(IntPtr hdc);
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern int  SaveDC(IntPtr hdc);
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern int ReleaseDC(IntPtr hdc, int state);  
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        [DllImport("gdi32.dll", ExactSpelling = true)]
        private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool DeleteDC(IntPtr hdc);
        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);
        
        [DllImport("UxTheme.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int DrawThemeTextEx(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int iCharCount, int dwFlags, ref RECT pRect, ref DTTOPTS pOptions);
        [DllImport("UxTheme.dll", ExactSpelling = true, SetLastError = true)]
        private static extern int DrawThemeText(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int iCharCount, int dwFlags1, int dwFlags2, ref RECT pRect);
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr CreateDIBSection(IntPtr hdc,ref BITMAPINFO pbmi, uint iUsage, int ppvBits, IntPtr hSection, uint dwOffset);

        
        
        private bool  IsCompositionEnabled()
        {
             
                if (Environment.OSVersion.Version.Major < 6)
                    return false ;

                int compositionEnabled = 0;
                DwmIsCompositionEnabled(ref compositionEnabled);
                if (compositionEnabled > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                 
             
        }

        public void FillBlackRegion(Graphics gph, Rectangle rgn)
        {
            RECT rc = new RECT();
            rc.left = rgn.Left;
            rc.right = rgn.Right;
            rc.top = rgn.Top;
            rc.bottom = rgn.Bottom;

            IntPtr destdc = gph.GetHdc();    //hwnd must be the handle of form,not control
            IntPtr Memdc = CreateCompatibleDC(destdc);
            IntPtr bitmap;
            IntPtr bitmapOld = IntPtr.Zero;

            BITMAPINFO dib = new BITMAPINFO();
            dib.bmiHeader.biHeight = -(rc.bottom - rc.top);
            dib.bmiHeader.biWidth = rc.right - rc.left;
            dib.bmiHeader.biPlanes = 1;
            dib.bmiHeader.biSize = Marshal.SizeOf(typeof(BITMAPINFOHEADER));
            dib.bmiHeader.biBitCount = 32;
            dib.bmiHeader.biCompression = BI_RGB;
            if (!(SaveDC(Memdc) == 0))
            {
                bitmap = CreateDIBSection(Memdc, ref dib, DIB_RGB_COLORS, 0, IntPtr.Zero, 0);
                if (!(bitmap == IntPtr.Zero))
                {
                    bitmapOld = SelectObject(Memdc, bitmap);
                    BitBlt(destdc, rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top, Memdc, 0, 0, SRCCOPY);

                }

                //Remember to clean up
                SelectObject(Memdc, bitmapOld);

                DeleteObject(bitmap);

                ReleaseDC(Memdc, -1);
                DeleteDC(Memdc);


            }
            gph.ReleaseHdc();

        }

        public void DrawTextOnGlass(IntPtr hwnd, String text, Font font, Rectangle ctlrct, int iglowSize)
        {
            if (IsCompositionEnabled())
            {
                RECT rc = new RECT();
                RECT rc2 = new RECT();

                rc.left = ctlrct.Left;
                rc.right = ctlrct.Right + 2 * iglowSize;  //make it larger to contain the glow effect
                rc.top = ctlrct.Top;
                rc.bottom = ctlrct.Bottom + 2 * iglowSize;

                //Just the same rect with rc,but (0,0) at the lefttop
                rc2.left = 0;
                rc2.top = 0;
                rc2.right = rc.right - rc.left;
                rc2.bottom = rc.bottom - rc.top;

                IntPtr destdc = GetDC(hwnd);    //hwnd must be the handle of form,not control
                IntPtr Memdc = CreateCompatibleDC(destdc);   // Set up a memory DC where we'll draw the text.
                IntPtr bitmap;
                IntPtr bitmapOld = IntPtr.Zero;
                IntPtr logfnotOld;

                int uFormat = DT_SINGLELINE | DT_CENTER | DT_VCENTER | DT_NOPREFIX;   //text format

                BITMAPINFO dib = new BITMAPINFO();
                dib.bmiHeader.biHeight = -(rc.bottom - rc.top);         // negative because DrawThemeTextEx() uses a top-down DIB
                dib.bmiHeader.biWidth = rc.right - rc.left;
                dib.bmiHeader.biPlanes = 1;
                dib.bmiHeader.biSize = Marshal.SizeOf(typeof(BITMAPINFOHEADER));
                dib.bmiHeader.biBitCount = 32;
                dib.bmiHeader.biCompression = BI_RGB;
                if (!(SaveDC(Memdc) == 0))
                {
                    bitmap = CreateDIBSection(Memdc, ref dib, DIB_RGB_COLORS, 0, IntPtr.Zero, 0);   // Create a 32-bit bmp for use in offscreen drawing when glass is on
                    if (!(bitmap == IntPtr.Zero))
                    {
                        bitmapOld = SelectObject(Memdc, bitmap);
                        IntPtr hFont = font.ToHfont();
                        logfnotOld = SelectObject(Memdc, hFont);
                        try
                        {

                            System.Windows.Forms.VisualStyles.VisualStyleRenderer renderer = new System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.Caption.Active);

                            DTTOPTS dttOpts = new DTTOPTS();

                            dttOpts.dwSize = (uint)Marshal.SizeOf(typeof(DTTOPTS));

                            dttOpts.dwFlags = DTT_COMPOSITED | DTT_GLOWSIZE;


                            dttOpts.iGlowSize = iglowSize;

                            DrawThemeTextEx(renderer.Handle, Memdc, 0, 0, text, -1, uFormat, ref rc2, ref dttOpts);




                            BitBlt(destdc, rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top, Memdc, 0, 0, SRCCOPY);



                        }
                        catch (Exception e)
                        {
                            Trace.WriteLine(e.Message);
                        }


                        //Remember to clean up
                        SelectObject(Memdc, bitmapOld);
                        SelectObject(Memdc, logfnotOld);
                        DeleteObject(bitmap);
                        DeleteObject(hFont);

                        ReleaseDC(Memdc, -1);
                        DeleteDC(Memdc);



                    }



                }



                }
            }
        }
    }

