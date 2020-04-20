using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace laba_1
{
    public partial class Form1 : Form
    {
        double A = -10, B = 10, C = -10, D = 10;

        double x1, x2, y1, y2, c;

        PointPairList listABCD = new PointPairList();//[A,B]x[C,D]
        PointPairList fx = new PointPairList();//f(x) 
        PointPairList list = new PointPairList();//списки точек

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        PointPairList PnxPoints = new PointPairList();//точки пересечения
        PointPairList dPnxPoints = new PointPairList();//точки пересечения

        public Form1()
        {

            InitializeComponent();

            list.Add(0, 0);

            // Создадим кривую
            LineItem krivaya = this.zedGraph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None);

            zedGraph.Invalidate(); // Обновляем график
            zedGraph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 

        }

        private void button_UP_Click(object sender, EventArgs e)
        {

            this.zedGraph.GraphPane.CurveList.Clear(); //очистка координатной плоскости
            listABCD.Clear();//очистка списка точек

            //ограничения
            A = Convert.ToDouble(this.windowA.Value);
            B = Convert.ToDouble(this.windowB.Value);
            C = Convert.ToDouble(this.windowC.Value);
            D = Convert.ToDouble(this.windowD.Value);

            //проверка поля ограничений для функции
            if (A >= B || C >= D)
            {
                MessageBox.Show("Неправильно подобраны интервалы!");
                A = -10;
                B = 10;
                C = -10;
                D = 10;
                this.windowA.Value = -10;
                this.windowB.Value = 10;
                this.windowC.Value = -10;
                this.windowD.Value = 10;
            }
            //заполнение списка, границы
            listABCD.Add(A, D);
            listABCD.Add(B, D);
            listABCD.Add(B, C);
            listABCD.Add(A, C);
            listABCD.Add(A, D);

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = A;
            this.zedGraph.GraphPane.XAxis.Max = B;
            this.zedGraph.GraphPane.YAxis.Min = C;
            this.zedGraph.GraphPane.YAxis.Max = D;

            LineItem krivaya_1 = this.zedGraph.GraphPane.AddCurve("", listABCD, Color.LightBlue, SymbolType.None); // Создадим кривую
            krivaya_1.Line.Width = 2;//толщина линии

            // вызов функций, рисующих графики
            if (check_f.Checked)
                cda();
            if (check_CDA2.Checked)
                cda2();
            if (brez_check.Checked)
                braz();
            if (kastl_check.Checked)
                kastl();
            if (last.Checked)
                last_one();

            //// Обновляем график
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();

        }
        void cda()
        {
            fx.Clear();

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            x1 = Convert.ToDouble(this.par_X1.Value);
            x2 = Convert.ToDouble(this.par_X2.Value);
            y1 = Convert.ToDouble(this.par_Y1.Value);
            y2 = Convert.ToDouble(this.par_Y2.Value);

            double Px = x2 - x1;
            double Py = y2 - y1;
            list.Add(x1, y1);

            while (x1 < x2)
            {
                x1 = x1 + 1.0;
                y1 = y1 + Py / Px;
                list.Add(x1, y1);
            }

            LineItem myCurve = pane.AddCurve("ЦДА", list, Color.Blue, SymbolType.Diamond);
            myCurve.Line.IsVisible = true;
            myCurve.Line.Width = 2;//толщина линии
            myCurve.Line.Color = Color.Red;//толщина линии
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            myCurve.Line.IsSmooth = true;
            zedGraph.AxisChange();
            zedGraph.Invalidate();

            //  LineItem krivaya_fx = this.zedGraph.GraphPane.AddCurve("f(x)", fx, Color.Blue, SymbolType.None);//рисуем функцию
            // krivaya_fx.Line.IsSmooth = true;//сглаживание графика
            //  krivaya_fx.Line.Width = 2;// толщина линии
        }

        void cda2()
        {
            fx.Clear();

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();

            x1 = Convert.ToDouble(this.par_X1.Value);
            x2 = Convert.ToDouble(this.par_X2.Value);
            y1 = Convert.ToDouble(this.par_Y1.Value);
            y2 = Convert.ToDouble(this.par_Y2.Value);

            double e = y2 / x2;
            double dE = y2 / x2;

            double x = x1;
            double y = y1;
            list.Add(x1, y1);

            while (x < x2)
            {

                if (e > 0.5)
                {
                    x++;
                    y++;
                    e += dE - 1;
                } else
                {
                    x++;
                    e += dE;
                }
                list2.Add(x, y);
            }
            list.Add(x, y);

            LineItem myCurve = pane.AddCurve("ЦДА по лекции", list, Color.Blue, SymbolType.Diamond);
            LineItem myCurve2 = pane.AddCurve("", list2, Color.Black, SymbolType.Diamond);
            myCurve.Line.IsVisible = true;
            myCurve2.Line.IsVisible = false;
            myCurve.Line.Width = 2;
            myCurve.Line.Color = Color.Red;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            myCurve.Line.IsSmooth = true;
            zedGraph.AxisChange();
            zedGraph.Invalidate();

        }

        void braz()
        {
            fx.Clear();

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            GraphPane pane1 = zedGraph.GraphPane;
            pane1.CurveList.Clear();
            PointPairList list2 = new PointPairList();

            x1 = Convert.ToDouble(this.par_X1.Value);
            x2 = Convert.ToDouble(this.par_X2.Value);
            y1 = Convert.ToDouble(this.par_Y1.Value);
            y2 = Convert.ToDouble(this.par_Y2.Value);

            double e = (2 * y2) - x2;
            double dES = 2 * y2;
            double dED = (2 * y2) - (2 * x2);
            double x = x1;
            double y = y1;

            //   list.Add(x, y);
            list2.Add(x, y);

            while (x < x2)
            {
                list.Add(x, y);
                if (e > 0)
                {
                    x++;
                    y++;
                    e += dED;
                } else
                {
                    x++;
                    e += dES;
                }
            }

            //   list.Add(x, y);
            list2.Add(x, y);

            LineItem myCurve = pane.AddCurve("Брезенхем", list, Color.Pink, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Line.Width = 2;
            myCurve.Line.Color = Color.Black;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            myCurve.Line.IsSmooth = true;

            LineItem myCurve2 = pane1.AddCurve("", list2, Color.Pink, SymbolType.Diamond);
            myCurve2.Line.IsVisible = true;
            myCurve2.Line.Width = 2;
            myCurve2.Line.Color = Color.Black;
            myCurve2.Symbol.Fill.Color = Color.Blue;
            myCurve2.Symbol.Fill.Type = FillType.Solid;
            myCurve2.Symbol.Size = 7;
            myCurve2.Line.IsSmooth = true;

            zedGraph.AxisChange();
            zedGraph.Invalidate();

        }

        void kastl()
        {

            fx.Clear();

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            x1 = Convert.ToDouble(this.par_X1.Value);
            x2 = Convert.ToDouble(this.par_X2.Value);
            y1 = Convert.ToDouble(this.par_Y1.Value);
            y2 = Convert.ToDouble(this.par_Y2.Value);

            double y = y2;
            double x = x2 - y2;
            string m1 = "s";
            string m2 = "d";

            // this stuff tightly freezes if y2 > x2

            while (x != y)
            {
                list.Add(x, y);
                if (x > y)
                {
                    x = x - y;                    
                    m2 = m1 + new string(m2.Reverse().ToArray()); ;
                } else
                {
                    y = y - x;
                    m1 = m2 + new string(m1.Reverse().ToArray()); ;
                }
            }
            list.Add(x, y);
            string m = m2 + new string(m1.Reverse().ToArray());
            LineItem myCurve = pane.AddCurve("Kastl", list, Color.Pink, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Line.Width = 2;
            myCurve.Line.Color = Color.Black;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            myCurve.Line.IsSmooth = true;

            zedGraph.AxisChange();
            zedGraph.Invalidate();

            MessageBox.Show(m, "Yeah", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        void last_one()
        {
            fx.Clear();

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            

            x1 = Convert.ToDouble(this.par_X1.Value);
            x2 = Convert.ToDouble(this.par_X2.Value);
            y1 = Convert.ToDouble(this.par_Y1.Value);
            y2 = Convert.ToDouble(this.par_Y2.Value);
            //  c = Convert.ToDouble(this.coef.Value);

            int c = 10;
            double dH = c / (x2 - x1);
            double dU = c / (y2 - y1);

            double h = dH * (1 - x1);
            double u = dU * (1 - y1);
            double x = x1;
            double y = y1;
            

            while ((h < c) && (u < c))
            {
                list.Add(x, y);
                if (h < u)
                {
                    x++;
                    h += dH;
                } else if (h > u){
                    y++;
                    u += dU;
                }
                else
                {
                    h = u;
                    list.Add(x, y+1);
                    x++;
                    y++;
                    h += dH;
                    u += dU;
                }
            }
          //  list.Add(x+1, y+2);

            LineItem myCurve = pane.AddCurve("Последний", list, Color.Blue, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Line.Width = 2;
            myCurve.Line.Color = Color.Red;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            myCurve.Line.IsSmooth = true;
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            windowA.Value = -10;
            windowB.Value = 10;
            windowC.Value = -10;
            windowD.Value = 10;

            par_X1.Value = 1;
            par_X2.Value = 1;
            par_Y1.Value = 1;
            par_Y2.Value = 1;

            check_f.Checked = false;
            check_CDA2.Checked = false;

            //очистка
            this.zedGraph.GraphPane.CurveList.Clear();

            this.zedGraph.GraphPane.XAxis.Min = -10;
            this.zedGraph.GraphPane.XAxis.Max = 10;
            this.zedGraph.GraphPane.YAxis.Min = -10;
            this.zedGraph.GraphPane.YAxis.Max = 10;

            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
