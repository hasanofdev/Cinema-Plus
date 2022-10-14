using System.Linq;


namespace Cinema_Plus;

public partial class CinemaPlus : Form
{
    List<string> MovieNameList;
    const string _apiKey = "16be0e6e";
    const string _url = $"http://www.omdbapi.com/?";
    public CinemaPlus() => InitializeComponent();

    private void PlatinumBtn_MouseHover(object sender, EventArgs e) => (sender as Button)!.ForeColor = Color.Black;

    private void PlatinumBtn_MouseLeave(object sender, EventArgs e) => (sender as Button)!.ForeColor = System.Drawing.Color.FromArgb(106, 108, 125);

    private async void CinemaPlus_LoadAsync(object sender, EventArgs e)
    {
        using HttpClient httpClient = new();
        using FileStream fs = new FileStream("MoviesNames.json", FileMode.Open);
        MovieNameList = System.Text.Json.JsonSerializer.Deserialize<List<string>>(fs);
        Random rnd = new Random();
        MovieNameList.OrderBy(x => rnd.Next());

        for (int i = 0; i < 20; i++)
        {
            string moviename = MovieNameList[i];
            if (moviename is not null)
            {
                MovieDesign movieDesign = new MovieDesign();
                movieDesign.MovieNameLbl.Text = moviename;
                string jsonStr = httpClient.GetStringAsync($"{_url}t={moviename}&apikey={_apiKey}").Result; //i = tt3896198 & apikey = 16be0e6e
                await Task.Delay(10);
                var movie = System.Text.Json.JsonSerializer.Deserialize<Movie>(jsonStr);
                movieDesign.pictureBox1.Load(movie?.Poster);
                MainLayout.Controls.Add(movieDesign);
            }
        }
    }

    private void SearchBtn_Click(object sender, EventArgs e)
    {
        TextBox tb = (sender as Button).Tag as TextBox;

        try
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                MainLayout.Controls.Clear();

                using HttpClient httpClient = new();
                string jsonStr = httpClient.GetStringAsync($"{_url}t={tb.Text}&apikey={_apiKey}").Result;
                MovieDesign movieDesign = new MovieDesign();
                var movie = System.Text.Json.JsonSerializer.Deserialize<Movie>(jsonStr);
                movieDesign.MovieNameLbl.Text = movie.Title;
                if (movie?.Poster != "N/A")
                    movieDesign.pictureBox1.Load(movie?.Poster);
                else
                    movieDesign.pictureBox1.Load("https://www.denizmall.az/site/assets/files/1121/cinemaplus.png");
                MainLayout.Controls.Add(movieDesign);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Movie Not Found!", ex.Message);
            tb.Text = string.Empty;

            CinemaPlus_LoadAsync(sender, e);
            return;
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        progressBar1.PerformStep();
        if(progressBar1.Value == progressBar1.Maximum)
        {
            timer1.Enabled = false;
            timer1.Dispose();
            progressBar1.Dispose();
            Cursor = DefaultCursor;
            Enabled = true;
        }
    }
}