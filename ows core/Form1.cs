using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
namespace ows_core
{

    public partial class Form1 : Form 
    {
        public enum VK
        {
            //Keycodes may be found on many internet sites.
            //Some keys are commented feel free to uncomment them, explanations are provided for uncommon ones ;)

            VK_LBUTTON = 0X01, //Left mouse
            VK_RBUTTON = 0X02, //Right mouse
            //VK_CANCEL       = 0X03,
            VK_MBUTTON = 0X04,
            VK_BACK = 0X08, //Backspace
            VK_TAB = 0X09,
            //VK_CLEAR        = 0X0C,
            VK_RETURN = 0X0D, //Enter
            VK_SHIFT = 0X10,
            VK_CONTROL = 0X11, //CTRL
            //VK_MENU         = 0X12,
            VK_PAUSE = 0X13,
            VK_CAPITAL = 0X14, //Caps-Lock
            VK_ESCAPE = 0X1B,
            VK_SPACE = 0X20,
            VK_PRIOR = 0X21, //Page-Up
            VK_NEXT = 0X22, //Page-Down
            VK_END = 0X23,
            VK_HOME = 0X24,
            VK_LEFT = 0X25,
            VK_UP = 0X26,
            VK_RIGHT = 0X27,
            VK_DOWN = 0X28,
            //VK_SELECT       = 0X29,
            //VK_PRINT        = 0X2A,
            //VK_EXECUTE      = 0X2B,
            VK_SNAPSHOT = 0X2C, //Print Screen
            VK_INSERT = 0X2D,
            VK_DELETE = 0X2E,
            //VK_HELP         = 0X2F,

            VK_0 = 0X30,
            VK_1 = 0X31,
            VK_2 = 0X32,
            VK_3 = 0X33,
            VK_4 = 0X34,
            VK_5 = 0X35,
            VK_6 = 0X36,
            VK_7 = 0X37,
            VK_8 = 0X38,
            VK_9 = 0X39,

            VK_A = 0X41,
            VK_B = 0X42,
            VK_C = 0X43,
            VK_D = 0X44,
            VK_E = 0X45,
            VK_F = 0X46,
            VK_G = 0X47,
            VK_H = 0X48,
            VK_I = 0X49,
            VK_J = 0X4A,
            VK_K = 0X4B,
            VK_L = 0X4C,
            VK_M = 0X4D,
            VK_N = 0X4E,
            VK_O = 0X4F,
            VK_P = 0X50,
            VK_Q = 0X51,
            VK_R = 0X52,
            VK_S = 0X53,
            VK_T = 0X54,
            VK_U = 0X55,
            VK_V = 0X56,
            VK_W = 0X57,
            VK_X = 0X58,
            VK_Y = 0X59,
            VK_Z = 0X5A,

            VK_NUMPAD0 = 0X60,
            VK_NUMPAD1 = 0X61,
            VK_NUMPAD2 = 0X62,
            VK_NUMPAD3 = 0X63,
            VK_NUMPAD4 = 0X64,
            VK_NUMPAD5 = 0X65,
            VK_NUMPAD6 = 0X66,
            VK_NUMPAD7 = 0X67,
            VK_NUMPAD8 = 0X68,
            VK_NUMPAD9 = 0X69,

            VK_SEPERATOR = 0X6C, // | (shift + backslash)
            VK_SUBTRACT = 0X6D, // -
            VK_DECIMAL = 0X6E, // .
            VK_DIVIDE = 0X6F, // /

            VK_F1 = 0X70,
            VK_F2 = 0X71,
            VK_F3 = 0X72,
            VK_F4 = 0X73,
            VK_F5 = 0X74,
            VK_F6 = 0X75,
            VK_F7 = 0X76,
            VK_F8 = 0X77,
            VK_F9 = 0X78,
            VK_F10 = 0X79,
            VK_F11 = 0X7A,
            VK_F12 = 0X7B,
            //and for the 8 people in the world who do, I think they can live without using them

            VK_NUMLOCK = 0X90,
            VK_SCROLL = 0X91, //Scroll-Lock
            VK_LSHIFT = 0XA0,
            VK_RSHIFT = 0XA1,
            VK_LCONTROL = 0XA2,
            VK_RCONTROL = 0XA3,
            //VK_LMENU        = 0XA4,
            //VK_RMENU        = 0XA5,
            //VK_PLAY         = 0XFA,
            //VK_ZOOM         = 0XFB
        } //keycodes
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);



        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern uint GetTickCount();

        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetActiveWindow();

        [DllImport("gdi32")]
        public static extern bool BitBlt(IntPtr hDestDC, int X, int Y, int nWidth, int nHeight, IntPtr hSrcDC, int SrcX, int SrcY, int Rop);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowRect(int hwnd, ref Rectangle lpRect);




        private long ScanRange;

        private int[] Pixels;

        private uint LastFireTick;

        private uint FireDelay;

        private GCHandle GCH;

        private Bitmap Bmp;

        public Form1()

        {
            base.Load += new EventHandler(this.Form1_Load);
         
            {
               
            };
          
            this.ScanRange = 17L;
            checked
            {
                this.Pixels = new int[(int)(this.ScanRange * this.ScanRange + this.ScanRange) + 1];
                this.FireDelay = 1;
                this.GCH = GCHandle.Alloc(this.Pixels, GCHandleType.Pinned);
                this.Bmp = new Bitmap((int)this.ScanRange, (int)this.ScanRange, (int)(4L * this.ScanRange), PixelFormat.Format32bppArgb, this.GCH.AddrOfPinnedObject());

                this.Bmp = new Bitmap((int)this.ScanRange, (int)this.ScanRange, (int)(4L * this.ScanRange), PixelFormat.Format32bppArgb, this.GCH.AddrOfPinnedObject());
                InitializeComponent();
            }

           
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("make your game on res 1980 1920 add in primary weapon key K letter and make sure you are in borderless windowed");
        }
        private long AmountfoundCC;
        private void runaim()
        {
            long[] CCAmount = new long[11];
            long lowestX = 900L;
            long lowestY = 900L;
            int screenwidth = Screen.PrimaryScreen.Bounds.Width;
            int screenheight = Screen.PrimaryScreen.Bounds.Height;
            IntPtr hdcDest = IntPtr.Zero;
            IntPtr desktopHandleDC = IntPtr.Zero;
            IntPtr desktopHandle = Form1.GetActiveWindow();
            float num;
            checked
            {
                
                int AdjustRight =0;
                int AdjustDown = 0;
                int sizee;
                sizee = Convert.ToInt32(size.Value);
               
                sizee = Convert.ToInt32(size.Value);
               // ScanRange = sizee;
                Rectangle R = new Rectangle((int)Math.Round(unchecked((double)Screen.PrimaryScreen.Bounds.Width / 2.0 - (double)this.ScanRange / 2.0)) + AdjustRight - sizee, (int)Math.Round(unchecked((double)Screen.PrimaryScreen.Bounds.Height / 2.0 - (double)this.ScanRange / 2.0)) + AdjustDown - sizee, (int)this.ScanRange, (int)this.ScanRange) ;
                this.Bmp = new Bitmap((int)this.ScanRange , (int)this.ScanRange, (int)(4L * this.ScanRange) , PixelFormat.Format32bppArgb, this.GCH.AddrOfPinnedObject());
                Graphics g = Graphics.FromImage(this.Bmp);
                desktopHandleDC = Form1.GetWindowDC(desktopHandle);
                hdcDest = g.GetHdc();
                Rectangle GH;
                GH = Rectangle.Empty;
                int gf = Form1.GetWindowRect((int)desktopHandle, ref GH);
                int NewRectWidth = GH.Width - GH.Left;
                int NewRectheight = GH.Height - GH.Top;
                Form1.BitBlt(hdcDest, 0, 0, (int)this.ScanRange, (int)this.ScanRange, desktopHandleDC, (int)Math.Round(unchecked((double)screenwidth / 2.0 - (double)this.ScanRange / 2.0 + (double)AdjustRight)), (int)Math.Round(unchecked((double)screenheight / 2.0 - (double)this.ScanRange / 2.0 + (double)AdjustDown)), 13369376);
                g.ReleaseHdc(hdcDest);
                Form1.ReleaseDC(desktopHandle, desktopHandleDC);
                this.Bmp.Dispose();
                g.Dispose();
                num = (float)(this.ScanRange - 2L);
            }
            long Amountfound = 0;
            long highestY = 0;
            long highestX = 0;
            for (float X = 1f; X <= num; X += 1f)
            {
                float YW = X * (float)this.ScanRange;
                float num2 = (float)(checked(this.ScanRange - 2L));
                float Y = 1f;
                while (Y <= num2)
                {
                    checked
                    {
                        Color myColor = Color.FromArgb(this.Pixels[(int)Math.Round((double)(unchecked(YW + Y)))]);
                        bool flag = myColor.GetHue() < 13f | myColor.GetHue() > 340f;
                        if (flag)
                        {
                            bool flag2 = myColor.GetHue() < 50f | myColor.GetHue() < 350f;
                            if (flag2)
                            {
                                bool flag3 = (double)myColor.GetBrightness() < 0.45 | (double)myColor.GetSaturation() < 0.45;
                                if (flag3)
                                {
                                    goto IL_46A;
                                }
                            }
                            bool flag4 = (double)myColor.GetBrightness() > 0.35 & (double)myColor.GetSaturation() > 0.25;
                            if (flag4)
                            {
                                Amountfound += 1L;
                                bool flag5 = (float)lowestX > X;
                                if (flag5)
                                {
                                    lowestX = (long)Math.Round((double)X);
                                }
                                bool flag6 = (float)lowestY > Y;
                                if (flag6)
                                {
                                    lowestY = (long)Math.Round((double)Y);
                                }
                                bool flag7 = (float)highestY < Y;
                                if (flag7)
                                {
                                    highestY = (long)Math.Round((double)Y);
                                }
                                bool flag8 = (float)highestX < X;
                                if (flag8)
                                {
                                    highestX = (long)Math.Round((double)X);
                                }
                              
                                unchecked
                                {
                                    float num3 = X - 1f;
                                    float num4 = X + 1f;
                                    for (float X2 = num3; X2 <= num4; X2 += 1f)
                                    {
                                        float YW2 = X2 * (float)this.ScanRange;
                                        float num5 = Y - 1f;
                                        float num6 = Y + 1f;
                                        for (float Y2 = num5; Y2 <= num6; Y2 += 1f)
                                        {
                                            checked
                                            {
                                                Color myColorcompare = Color.FromArgb(this.Pixels[(int)Math.Round((double)(unchecked(YW2 + Y2)))]);
                                                bool flag9 = (double)myColorcompare.GetBrightness() > 0.35 & (double)myColorcompare.GetSaturation() > 0.25 & myColorcompare.R > 110;
                                                if (flag9)
                                                {
                                                    bool flag10 = myColorcompare.GetHue() < 13f | myColorcompare.GetHue() > 340f;
                                                    if (flag10)
                                                    {
                                                        AmountfoundCC += 1L;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                CCAmount[(int)AmountfoundCC] = CCAmount[(int)AmountfoundCC] + 1L;
                                AmountfoundCC = 0L;
                            }
                        }
                        IL_46A:;
                    }
                    Y += 1f;
                    continue;
                  
                }
            }
            long CombinedLineFigure = checked(CCAmount[3] + CCAmount[4] + CCAmount[5] + CCAmount[6]);
            bool flag11 = (double)CombinedLineFigure >= (double)this.ScanRange * 0.3 & checked(CombinedLineFigure * 2L) > Amountfound;
            if (flag11)
            {
                bool flag12 = checked(this.LastFireTick + this.FireDelay) <= Form1.GetTickCount();
                if (flag12)
                {
                    bool flag13 = (double)lowestX + (double)this.ScanRange * 0.3 <= (double)highestX & (double)lowestY + (double)this.ScanRange * 0.3 <= (double)highestY;
                    if (flag13)
                    {
                        this.LastFireTick = Form1.GetTickCount();
                        this.Fire();
                    }
                }
            }

        }
        public void Fire()
        {
            if (widow == true)
            {
                delay_aftherShoot_OFF.Interval = 1200;
                if (hanzo == true)
                {
                    delay_aftherShoot_OFF.Interval = 2000;
                }
                delay_aftherShoot_ON.Start();
            }
            if (Shoot_delay.Value == 1)
            {
                if (comboBox1.Text == "SOILDER76")
                {
                    Rifleshoot();
                }
                SendKeys.Send(comboBox2.Text.ToLower());
            } else
            {
                Delay_BeforeShoot.Start();
            }
        
               
        }
        public void Rifleshoot ()
        {
            hmts = 0;
            rifle_shoot.Start();
        }
        public string Returningkey1()
        {
            if (comboBox2.Text == "L")
            {
                return "L";
            } else if (comboBox2.Text == "K")
            {
                return "K";
            } else if (comboBox2.Text == "J")
            {
                return "J";
            } else if (comboBox2.Text == "I")
            {
                return "I";
            } else if (comboBox2.Text == "U")
            {
                return "U";
            } else if (comboBox2.Text == "M")
            {
                return "M";

            } else if (comboBox2.Text == "N")
            {
                return "N";
            }
            else if (comboBox2.Text == "B")
            {
                return "B";
            }
            else if (comboBox2.Text == "G")
            {
                return "G";
            } else
            {
                return " ";
            }
        }
        int TogMove;
        int MValX;
        int MValY;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void statusreoload()
        {
            
            ushort down = 32768;
            ushort up = 32768;
            if (checkBox3.Checked == true)
            {
                if ((GetAsyncKeyState(0X52) & up) == up)
                {
                  
                    if (comboBox3.Text == "SOILDER76")
                    {
                        Solider_76.Start();
                    }
                    else if (comboBox3.Text == "PHARAH")
                    {
                        Pharah.Start();
                    }
                    else if (comboBox3.Text == "ROADHOG")
                    {
                        Roadhog.Start();
                    }
                    else if (comboBox3.Text == "REAPER")
                    {
                        Reaper.Start();
                    }
                }

            }
        }
        private void holdlocation_Tick(object sender, EventArgs e)
        {
            
            if (checkBox4.Checked == true)
            {
                pharahHolder();
            }
            if (checkBox3.Checked == true)
            {
                statusreoload();
            }
            ushort down = 32768;
            ushort up = 32768;
            if (checkBox2.Checked == true)
            {
                if ((GetAsyncKeyState(0X51) & up) == up)
                {
                    ultimatewait.Start();
                    Coredeafult.Stop();
                    Core_2.Stop();
                }
            }
          
            Process[] pname = Process.GetProcessesByName("Overwatch");
            if (pname.Length == 0)
            {


                Application.Exit();
            }
            decimal dee;
            dee = Shoot_delay.Value;
            Delay_BeforeShoot.Interval = Convert.ToInt32(dee);
        }

        private void Coredeafult_Tick(object sender, EventArgs e)
        {
       
            int ds = Convert.ToInt32(Delay.Value);
            FireDelay = Convert.ToUInt32(ds);
                runaim();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void visable_true_Tick(object sender, EventArgs e)
        {
           
            
            ushort down = 32768;
            ushort up = 32768;

           


          
        }

        private void visable_false_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("Overwatch");
            if (pname.Length == 0)
            {


                Application.Exit();
            }
            else
            {

            }
            ushort down = 32768;
            ushort up = 32768;
            if ((GetAsyncKeyState(0X2D) & up) == up)
            {
                this.Visible = true;
                visable_true.Start();
                visable_false.Stop();
            }
        }

        private void Delay_BeforeShoot_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "SOILDER76")
            {
                Rifleshoot();
            }
            SendKeys.Send(comboBox2.Text.ToLower());
            Delay_BeforeShoot.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            long i = 0L;
            checked
            {
                while (true)
                {
                    bool flag = this.checkBox1.CheckState != CheckState.Checked;
                    if (flag)
                    {
                        break;
                    }
                    Rectangle rect = new Rectangle((int)Math.Round(unchecked((double)Screen.PrimaryScreen.Bounds.Width / 2.0 - (double)this.ScanRange / 2.0)), (int)Math.Round(unchecked((double)Screen.PrimaryScreen.Bounds.Height / 2.0 - (double)this.ScanRange / 2.0)), (int)this.ScanRange, (int)this.ScanRange);
                    int h;
                    h = Convert.ToInt32(size.Value);
                    rect.Inflate(2 , 2);
                    using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                    {
                        using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.Yellow, Color.Purple, 90f, true))
                        {
                            g.FillRectangle(lgb, rect);
                        }
                    }
                    Application.DoEvents();
                    i += 1L;
                    if (i > 999L)
                    {
                        goto Block_3;
                    }
                }
                return;
                Block_3:
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        private void cores_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void mcree_settings()
        {
            hanzo = false;
            widow = false;
            Delay.Value = 1;
        }
        private bool widow;
        private bool hanzo;
        private void widow_settings()
        {
            hanzo = false;
            widow = true;
        }
        private void hanzo_settings()
        {
            hanzo = true;
            widow = true;
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MCREE")
            {
                mcree_settings();
            } else if (comboBox1.Text == "WIDOWMAKER")
            {
                widow_settings();
            } else if (comboBox1.Text == "HANZO")
            {
                hanzo_settings();
            }
        }

        private void ultimatewait_Tick(object sender, EventArgs e)
        {
            Coredeafult.Start();
            ultimatewait.Stop();
        }
        private int hmts;
        private void rifle_shoot_Tick(object sender, EventArgs e)
        {
            if (hmts == 4)
            {
                rifle_shoot.Stop();
            }
            SendKeys.Send(comboBox2.Text.ToLower());
            SendKeys.Send(comboBox2.Text.ToLower());
            SendKeys.Send(comboBox2.Text.ToLower());
            SendKeys.Send(comboBox2.Text.ToLower());
            hmts++;
        }

        private void Reaper_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("v");
            Reaper.Stop();
        }

        private void Roadhog_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("v");
            Roadhog.Stop();
        }

        private void Pharah_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("v");
            Pharah.Stop();
            
        }

        private void Solider_76_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("v");
            Solider_76.Stop();
        }
        private void pharahHolder()
        {

            ushort down = 32768;
            ushort up = 32768;
            if ((GetAsyncKeyState(0XA2) & up) == up)
            {
                Pharahh.Start();
              
            }
        }
        private void Pharahh_Tick(object sender, EventArgs e)
        {

            SendKeys.Send(" ");
            Pharahh.Stop();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            long i = 0L;
            checked
            {
                while (true)
                {
                    bool flag = this.checkBox5.CheckState != CheckState.Checked;
                    if (flag)
                    {
                        break;
                    }
                    Bitmap bmpScreenshot = Screenshot();

                    // makes the background of the form a screenshot of the screen
                    this.BackgroundImage = bmpScreenshot;

                    // find the login button and check if it exists
                    Point location;
                    bool success = FindBitmap(Properties.Resources.loginbtn, bmpScreenshot, out location);

                    string hex = "#FF947B";
                    Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
                    Point[] p;
                  
                 try
                    {
                        Rectangle rect = new Rectangle(location.X, location.Y, (int)this.ScanRange, (int)this.ScanRange);
                        int h;
                        h = Convert.ToInt32(size.Value);
                        rect.Inflate(2, 2);
                        using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                        {
                            using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.Yellow, Color.Purple, 90f, true))
                            {
                                g.FillRectangle(lgb, rect);
                            }
                        }
                    }
                    catch
                    {

                    }
                   
                    Application.DoEvents();
                    i += 1L;
                    if (i > 999L)
                    {
                        goto Block_3;
                    }
                }
                return;
                Block_3:
                checkBox5.CheckState = CheckState.Unchecked;
            }
           
        }
        private Bitmap Screenshot()
        {
            // this is where we will store a snapshot of the screen
            Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            // creates a graphics object so we can draw the screen in the bitmap (bmpScreenshot)
            Graphics g = Graphics.FromImage(bmpScreenshot);

            // copy from screen into the bitmap we created
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            // return the screenshot
            return bmpScreenshot;
        }
        private bool FindBitmap(Bitmap bmpNeedle, Bitmap bmpHaystack, out Point location)
        {
            for (int outerX = 0; outerX < bmpHaystack.Width - bmpNeedle.Width; outerX++)
            {
                for (int outerY = 0; outerY < bmpHaystack.Height - bmpNeedle.Height; outerY++)
                {
                    for (int innerX = 0; innerX < bmpNeedle.Width; innerX++)
                    {
                        for (int innerY = 0; innerY < bmpNeedle.Height; innerY++)
                        {
                            Color cNeedle = bmpNeedle.GetPixel(innerX, innerY);
                            Color cHaystack = bmpHaystack.GetPixel(innerX + outerX, innerY + outerY);

                            if (cNeedle.R != cHaystack.R || cNeedle.G != cHaystack.G || cNeedle.B != cHaystack.B)
                            {
                                goto notFound;
                            }
                        }
                    }
                    location = new Point(outerX, outerY);
                    return true;
                    notFound:
                    continue;
                }
            }
            location = Point.Empty;
            return false;
        }

        private void delay_aftherShoot_Tick(object sender, EventArgs e)
        {
            Core_2.Start();
            Coredeafult.Start();
            delay_aftherShoot_OFF.Stop();
        }

        private void delay_aftherShoot_ON_Tick(object sender, EventArgs e)
        {
            Core_2.Stop();
            Coredeafult.Stop();
            delay_aftherShoot_OFF.Start();
            delay_aftherShoot_ON.Stop();
        }

        private void icon_1_Tick(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.mcreeri;
            icon_1.Stop();
            icon_2.Start();
        }

        private void icon_2_Tick(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.traceri;
            icon_2.Stop();
            icon_3.Start();
        }

        private void icon_3_Tick(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.reaperi;
            icon_3.Stop();
            icon_1.Start();
        }

        private void Core_2_Tick(object sender, EventArgs e)
        {
            runaim();
        }

        private void ambiance_CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ambiance_CheckBox1.Checked == true)
            {
                Coredeafult.Start();
                Core_2.Start();
                
            } else
            {
                Coredeafult.Stop();
                Core_2.Stop();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

