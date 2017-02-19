using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCALculator
{
    class Graphic
    {
        float scalex = 1000;
        float scaley = 400;
        float offsetx = 20;
        float offsety = 20;
        float pointw = 12;
        float pointh = 12;
        float textoffsetx = 5;
        float textoffsety = 5;
        float xscaleoffset = 30;

        float maxvalue;
        float minValue;
        float[] points;

        Bitmap img;

        public Graphic(int[] values)
        {
            points = new float[values.Length];
            maxvalue = values.Max();
            minValue = values.Min();
            for (int i = 0; i < values.Length; ++i)
            {
                points[i] = (values[i] - minValue) / (maxvalue - minValue);
            }

            DrawGraphic(@"conf\temp.jpg", values);
        }

        private void DrawGraphic(string path, int[] values)
        {
            img = new Bitmap((int)(4 * offsetx + scalex), (int)(2 * offsety + scaley + xscaleoffset));
            for (int i = 0; i < img.Size.Width; ++i)
            {
                for (int j = 0; j < img.Size.Height; ++j)
                {
                    img.SetPixel(i, j, Color.White);
                }
            }
            Graphics g = Graphics.FromImage(img);
            Pen p = new Pen(Color.Black, 6);
            Brush b = new SolidBrush(Color.Blue);
            Font f = new Font("Arial", 14);
            g.DrawLine(p, offsetx, offsety, offsetx, offsety + scaley + xscaleoffset);
            g.DrawLine(p, offsetx, offsety + scaley + xscaleoffset, offsetx + scalex, offsety + scaley + xscaleoffset);

            Pen p2 = new Pen(Color.Blue, 4);
            for (int i = 0; i < points.Length - 1; ++i)
            {
                g.DrawLine(p2, offsetx + i * scalex / (points.Length - 1),
                    offsety + scaley - points[i] * scaley,
                    offsetx + (i + 1) * scalex / (points.Length - 1),
                    offsety + scaley - points[i + 1] * scaley);
            }
            for (int i = 0; i < points.Length; ++i)
            {
                g.FillEllipse(b, offsetx + i * scalex / (points.Length - 1) - pointw / 2,
                    offsety + scaley - points[i] * scaley - pointh / 2,
                    pointw, pointh);

                g.DrawString(values[i].ToString(), f, b,
                    offsetx + i * scalex / (points.Length - 1) + textoffsetx,
                    offsety + scaley - points[i] * scaley + textoffsety);
            }
        }

        public string GetBase64Image()
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}
