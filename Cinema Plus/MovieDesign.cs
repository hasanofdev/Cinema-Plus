using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Plus;

public partial class MovieDesign : UserControl
{
    public MovieDesign()
    {
        InitializeComponent();
    }

    private void MovieDesign_MouseEnter(object sender, EventArgs e) => this.BackColor = System.Drawing.Color.FromArgb(51, 78, 158);

    private void MovieDesign_MouseLeave(object sender, EventArgs e) =>    this.BackColor = System.Drawing.Color.Snow;

    private void MovieNameLbl_TextChanged(object sender, EventArgs e)
    {
        Label label = sender as Label;

        if(label.Text.Length > 17)
        {
            label.Font = new System.Drawing.Font("Segoe UI", 14.25F - (label.Text.Length - 17), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

    }
}
