using Cinema_Plus.Properties;

namespace Cinema_Plus;

public partial class CinemaPlus : Form
{
    List<Movie> MovieList;
    public CinemaPlus()
    {
        InitializeComponent();
    }

    private void PlatinumBtn_MouseHover(object sender, EventArgs e)
    {
        (sender as Button)!.ForeColor = Color.Black;
    }

    private void PlatinumBtn_MouseLeave(object sender, EventArgs e) => (sender as Button)!.ForeColor = System.Drawing.Color.FromArgb(106, 108, 125);

    private void CinemaPlus_Load(object sender, EventArgs e)
    {
        Methods.DeserializeMovies("MoviesData.Json", ref MovieList);

        foreach(var movie in MovieList)
        {
            if(movie is not null)
            {
                MovieDesign movieDesign = new MovieDesign();
                movieDesign.MovieNameLbl.Text = movie.MovieName;

                movieDesign.pictureBox1.Image = (System.Drawing.Bitmap)Properties.MoviesPictures.ResourceManager.GetObject(movie.ImageName,MoviesPictures.resourceCulture)!;
                MainLayout.Controls.Add(movieDesign);
            }
        }

    }
}