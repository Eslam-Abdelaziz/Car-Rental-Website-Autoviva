using System.Drawing;
using System.Windows.Forms;

namespace AdminPanel.UI
{
    public class CustomListView : ListView
    {
        private Color selectionColor = Color.LightBlue;

        public Color SelectionColor
        {
            get { return selectionColor; }
            set { selectionColor = value; }
        }

        public CustomListView()
        {
            // Enable owner drawing
            OwnerDraw = true;
            // Subscribe to the DrawItem event
            //DrawItem += CustomListView_DrawItem;
            DrawColumnHeader += CustomListView_DrawColumnHeader;
            DrawSubItem += CustomListView_DrawSubItem;
            ForeColor = Color.FromArgb(235, 42, 83);
        }
        private void CustomListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawBackground();

            using (Brush backBrush = new SolidBrush(Color.White))
            using (Brush textBrush = new SolidBrush(Color.Black))
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                Rectangle headerBounds = e.Bounds;
                headerBounds.Inflate(-2, -2);

                e.Graphics.FillRectangle(backBrush, headerBounds);
                e.Graphics.DrawString(e.Header.Text, e.Font, textBrush, headerBounds, sf);
            }
        }

        private void CustomListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {


            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds);

                if (e.Header.Index == 0) 
                {
                    using (Brush brush = new SolidBrush(Color.Yellow))
                    {
                        e.Graphics.FillRectangle(brush, new Rectangle(e.Bounds.X, e.Bounds.Y, 15, e.Bounds.Height));
                    }
                }
           
            }
            e.DrawText();
        }
        //private void CustomListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        //{
        //    e.DrawDefault = true;

        //    // Customize the selection color
   
        //}



    }
}
