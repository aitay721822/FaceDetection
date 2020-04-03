using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif

namespace UIS
{
    class DetectionFace
    {
        public static void Detect(Image<Bgr,byte> image, String faceFileName, String eyeFileName, List<Rectangle> faces, List<Rectangle> eyes, out long detectionTime)
        {
            Stopwatch watch;
            using (CascadeClassifier face = new CascadeClassifier(faceFileName))
            using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
            {
                watch = Stopwatch.StartNew();
                using (Image<Gray, Byte> gray = image.Convert<Gray, Byte>()) //Convert it to Grayscale
                {
                    gray._EqualizeHist();
                    Rectangle[] facesDetected = face.DetectMultiScale(
                        gray,
                        1.1,
                        10,
                        new Size(20, 20),
                        Size.Empty);
                    faces.AddRange(facesDetected);

                    foreach (Rectangle f in facesDetected)
                    {
                        gray.ROI = f;
                        Rectangle[] eyesDetected = eye.DetectMultiScale(
                        gray,
                        1.1,
                        10,
                        new Size(20, 20),
                        Size.Empty);
                        gray.ROI = Rectangle.Empty;

                        foreach (Rectangle e in eyesDetected)
                        {
                            Rectangle eyeRect = e;
                            eyeRect.Offset(f.X, f.Y);
                            eyes.Add(eyeRect);
                        }
                    }
                }
                watch.Stop();
                detectionTime = watch.ElapsedMilliseconds;
            }
        }
    }
}
