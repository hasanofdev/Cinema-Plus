using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cinema_Plus.Views
{
    public partial class MovieDetails : Form
    {
        public Movie? MovieDetail { get; set; }
        public MovieDetails()
        {
            InitializeComponent();
        }

        public MovieDetails(Movie movie)
        {
            MovieDetail = movie;
            InitializeComponent();
        }

        private void MovieDetails_Load(object sender, EventArgs e)
        {
            if(MovieDetail == null)
                DialogResult = DialogResult.Cancel;
            NameTb.Text = MovieDetail?.Title;
            CountryTb.Text = MovieDetail?.Country;
            DirectorTb.Text = MovieDetail?.Director;
            ActorsTb.Text = MovieDetail?.Actors;
            GenreTb.Text = MovieDetail?.Genre;
            RatingTb.Text = MovieDetail?.imdbRating;
            PlotTb.Text = MovieDetail?.Plot;

            if (MovieDetail?.Poster != "N/A")
                PosterBox.Load(MovieDetail?.Poster);
            else
                PosterBox.Load("https://www.denizmall.az/site/assets/files/1121/cinemaplus.png");
        }
    }
}
