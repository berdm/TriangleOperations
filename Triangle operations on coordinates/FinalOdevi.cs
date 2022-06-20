using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdevi
{
    public partial class frmFinalOdevi : Form
    {
        System.Drawing.Graphics Cizim;
        Graphics GrafikCiz;
        Pen kalem = new Pen(Color.Purple, 3);
        Point Nokta1, Nokta2, Nokta3;
        //Pen kalem = new Pen(Color.Purple,2);
        Double[,] Xcisim = new Double[3,2] { { 20, 30 }, { 70, 30 }, { 20, 60 } };
        Point[] NoktalarPoints = new Point[3];

        Double[,] Xnew = new Double[3, 2];

       // Double[,] Tisometric = new Double[2, 2] 
       /*
        Double[,] Ttranslation = new Double[4, 4] { {1,0,0,0 },
                                                  {0,1,0,0 },
                                                   {0,0,1,0 },
                                                      {0,0,0,1 }};
       
        Double[,] Trotate = new Double[4, 4] { {1,0,0,0 },
                                                  {0,1,0,0 },
                                                   {0,0,1,0 },
                                                      {0,0,0,1 }};
       */

        Double[,] axis2BX = new Double[2, 2] { { -2.5, 0 }, { 2.5, 0 } };
        Double[,] axis2BY = new Double[2, 2] { { 0, 2.5 }, { 0, -2.5 } };

       // int i, j, k;

        
        public frmFinalOdevi()
        {
            InitializeComponent();
        }
        
        private int CaCoordinateX(Double tempX)
        {
            return Convert.ToInt32(300 + 250 + (100 * tempX));
        }

        private int CaCoordinateY(Double tempY)
        {
            return Convert.ToInt32(100 + 250 + (-100 * tempY));
        }
        
        private void btnNesneCiz_Click(object sender, EventArgs e)
        {
            GrafikCiz = this.CreateGraphics();
            kalem.Width = 5;

            Nokta1 = new Point(20, 30);
            Nokta2 = new Point(70, 30);
            Nokta3 = new Point(20, 60);

            GrafikCiz.DrawLine(kalem, Nokta1.X, Nokta1.Y, Nokta2.X, Nokta2.Y);
            GrafikCiz.DrawLine(kalem, Nokta2.X, Nokta2.Y, Nokta3.X, Nokta3.Y);

            for( int i=0; i<3; i++)
            {
                NoktalarPoints[i].X = Convert.ToInt32(Xcisim[i, 0]);
                NoktalarPoints[i].Y = Convert.ToInt32(Xcisim[i, 1]);
            }
            kalem.Color = Color.Cyan;
            GrafikCiz.DrawPolygon(kalem, NoktalarPoints);

        }
        
    

        private void draw()
        {
            
            Cizim = this.CreateGraphics();
            Cizim.DrawLine(kalem, CaCoordinateX(Xnew[0, 0]), CaCoordinateY(Xnew[0, 1]), CaCoordinateX(Xnew[1, 0]), CaCoordinateY(Xnew[1, 1]));
            Cizim.DrawLine(kalem, CaCoordinateX(Xnew[1, 0]), CaCoordinateY(Xnew[1, 1]), CaCoordinateX(Xnew[2, 0]), CaCoordinateY(Xnew[2, 1]));
         

        }

        private void btnEksenCiz_Click(object sender, EventArgs e)
        {
            
            Cizim = this.CreateGraphics();
            Cizim.DrawLine(kalem, CaCoordinateX(axis2BX[0, 0]), CaCoordinateY(axis2BX[0, 1]), CaCoordinateX(axis2BX[1, 0]), CaCoordinateY(axis2BX[1, 1]));
            Cizim.DrawLine(kalem, CaCoordinateX(axis2BY[0, 0]), CaCoordinateY(axis2BY[0, 1]), CaCoordinateX(axis2BY[1, 0]), CaCoordinateY(axis2BY[1, 1]));

            Cizim.Dispose();
           


        }

    }
}
