using Cinema_Plus.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
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

    private void MovieDesign_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Label label =  (sender as Control).Tag as Label;
        HttpClient client = new();
        MovieDetails movieDetails = new MovieDetails(System.Text.Json.JsonSerializer.Deserialize<Movie>(client.GetStringAsync($"http://www.omdbapi.com/?t={label.Text}&apikey=16be0e6e").Result));
        DialogResult result =  movieDetails.ShowDialog();


    }
}
