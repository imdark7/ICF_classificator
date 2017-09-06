using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ICF_classificator.Extensions
{
    public sealed class ListBoxExtension : ListBox
    {
        const int CornerRadius = 3; //радиус закругления
        int x, y, rectWidth, rectHeight; //вспомогательные переменные для отрисовки
        private ListBox listBox1;

        public ListBoxExtension()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            this.ResumeLayout(false);

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //e - элемент, с которым мы дальше и работаем
            //если текущего элемента нет или в списке нет вообще элементов, 
            //значит выходить из метода
            if (e.Index <= -1 || this.Items.Count == 0) return;
            //получаем текст элемента
            string s = Items[e.Index].ToString();

            //формат строки для рисования текста
            StringFormat sf = new StringFormat();
            //формат выставляем по левому краю
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            //создаем обычную кисть с заданным цветом
            Brush solidBrush = new SolidBrush(Color.FromArgb(45, 131, 218));
            //создаем кисть с градиентом по вертикали
            Brush gradientBrush = new LinearGradientBrush(e.Bounds, Color.FromArgb(121, 187, 255), Color.FromArgb(65, 151, 238), LinearGradientMode.Vertical);
            //теперь определяем какой элемент сейчас нужно отрисовать
            if ((e.State & DrawItemState.Focus) == 0) //если не активный
            {
                //заполняем прямоугольник выбранным цветом
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height + 1);
                //пишем текст
                e.Graphics.DrawString(s, Font, new SolidBrush(SystemColors.WindowText), new RectangleF(0, e.Bounds.Y, e.Bounds.Width, 40), sf);
            }
            else //если активный
            {
                //создаем путь который повторит контур с закругленными углами
                GraphicsPath gfxPath = new GraphicsPath();
                //определяем координаты элемента в списке
                //т.к. для каждого элемента они разные
                x = e.Bounds.X;
                y = e.Bounds.Y;
                //также определяем его ширину и высоту
                rectWidth = e.Bounds.Width - 2;
                rectHeight = e.Bounds.Height;
                #region Рисуем прямоугольник с закругленными углами
                gfxPath.AddLine(x + CornerRadius, y, x + rectWidth - (CornerRadius * 2), y);
                gfxPath.AddArc(x + rectWidth - (CornerRadius * 2), y, CornerRadius * 2, CornerRadius * 2, 270, 90);
                gfxPath.AddLine(x + rectWidth, y + CornerRadius, x + rectWidth, y + rectHeight - (CornerRadius * 2));
                gfxPath.AddArc(x + rectWidth - (CornerRadius * 2), y + rectHeight - (CornerRadius * 2), CornerRadius * 2, CornerRadius * 2, 0, 90);
                gfxPath.AddLine(x + rectWidth - (CornerRadius * 2), y + rectHeight, x + CornerRadius, y + rectHeight);
                gfxPath.AddArc(x, y + rectHeight - (CornerRadius * 2), CornerRadius * 2, CornerRadius * 2, 90, 90);
                gfxPath.AddLine(x, y + rectHeight - (CornerRadius * 2), x, y + CornerRadius);
                gfxPath.AddArc(x, y, CornerRadius * 2, CornerRadius * 2, 180, 90);
                gfxPath.CloseFigure();
                e.Graphics.DrawPath(new Pen(solidBrush, 1), gfxPath);
                //закрашиваем область
                e.Graphics.FillPath(gradientBrush, gfxPath);
                gfxPath.Dispose();
                #endregion
                //и пишем текст
                e.Graphics.DrawString(s, Font, new SolidBrush(SystemColors.WindowText), new RectangleF(0, e.Bounds.Y, e.Bounds.Width, 40), sf);
            }
        }

        //после изменения размера
        protected override void OnSizeChanged(EventArgs e)
        {
            //вызываем обновление компонента
            Refresh();
            base.OnSizeChanged(e);
        }

        //во время задания размеров элемента
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            //если это элемент
            if (e.Index > -1)
            {
                //задаем высоту
                e.ItemHeight = 40;
                //и ширину
                e.ItemWidth = Width;
            }
        }
    }
}
