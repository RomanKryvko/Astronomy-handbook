using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Довідник_астронома
{
    public partial class Form1 : Form
    {
        private StarContext? dbContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new StarContext();

            // Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Stars.Load();

            var stars = dbContext.Stars.Local.ToBindingList();
            this.starBindingSource.DataSource = stars;
            lblStarsCount.Text = stars.Count.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindStar_Click(object sender, EventArgs e)
        {
            string searchText = txtFindStar.Text;

            using (var context = new StarContext())
            {
                // search by star name
                List<Star> stars = context.Stars
                    .Where(star => star.Name.Contains(searchText))
                    .ToList();

                // if star is not found by its name - search by constellation
                if (!stars.Any())
                {
                    // search stars by constellation
                    stars = context.Stars
                        .Where(star => star.Constellation.Contains(searchText))
                        .ToList();
                }

                starBindingSource.DataSource = stars;

                lblStarsCount.Text = stars.Count.ToString();
            }
        }

        private void btnShowBrightStars_Click(object sender, EventArgs e)
        {
            int starsNumber = (int)numBrightStars.Value;
            using (var context = new StarContext())
            {
                // sort stars by brightness
                List<Star> stars = context.Stars
                    .OrderBy(star => star.ApparentMagnitude)
                    .Take(starsNumber)
                    .ToList();

                starBindingSource.DataSource = stars;
                lblStarsCount.Text = stars.Count.ToString();
            }
        }

        private void btnFindVisibleStars_Click(object sender, EventArgs e)
        {
            List<Star> visibleStars = GetVisibleStars();

            dataGridViewVisibleStars.Columns.Clear();
            dataGridViewVisibleStars.AutoGenerateColumns = false;
            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Видима зірка",
                    DataPropertyName = "Name"
                });

            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Сузір'я",
                    DataPropertyName = "Constellation"
                });

            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Видима зоряна величина",
                    DataPropertyName = "ApparentMagnitude"
                });

            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Відстань",
                    DataPropertyName = "Distance"
                });

            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Пряме піднесення",
                    DataPropertyName = "RightAscension"
                });

            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Схилення",
                    DataPropertyName = "DeclinationFormatted"
                });

            dataGridViewVisibleStars.DataSource = new BindingSource { DataSource = visibleStars };
            lblVisibleObjectsCount.Text = visibleStars.Count.ToString();
        }

        private void btnFindVisibleConstellations_Click(object sender, EventArgs e)
        {
            List<Star> visibleStars = GetVisibleStars();

            var visibleConstellations = visibleStars
                .Select(star => new { star.Constellation })
                .Distinct()
                .ToList();

            dataGridViewVisibleStars.Columns.Clear();
            dataGridViewVisibleStars.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Видиме сузір'я",
                    DataPropertyName = "Constellation"
                });
            dataGridViewVisibleStars.DataSource = new BindingSource { DataSource = visibleConstellations };
            lblVisibleObjectsCount.Text = visibleConstellations.Count.ToString();
        }

        private List<Star> GetVisibleStars()
        {
            // get latitude
            double.TryParse(txtLatitude.Text, out double latitude);
            // get longitude
            double.TryParse(txtLongitude.Text, out double longitude);
            // get observation time
            DateTime observationTime = dtObservationDate.Value;

            if (rbSouthLatitude.Checked)
            {
                latitude = -latitude;
            }

            if (rbWestLongitude.Checked)
            {
                longitude = -longitude;
            }

            var visibleStars = new List<Star>();
            using (var context = new StarContext())
            {
                // find visible stars
                List<Star> stars = context.Stars.ToList();
                visibleStars = stars
                    .Where(star => star.IsVisible(longitude, latitude, observationTime))
                    .ToList();
            }

            return visibleStars;
        }

        private void btnFindHours_Click(object sender, EventArgs e)
        {
            string searchText = txtNameStarObservation.Text;
            Star? star = null;
            using (var context = new StarContext())
            {
                // find star for observation
                star = context.Stars
                    .FirstOrDefault(star => star.Name == searchText);
            }

            if (star == null)
            {
                datagridObservationHours.DataSource = null;
                return;
            }

            // get latitude
            double.TryParse(txtLatitudeStarObservation.Text, out double latitude);
            // get longitude
            double.TryParse(txtLongitudeStarObservation.Text, out double longitude);

            if (rbSouthLatitudeStarObservation.Checked)
            {
                latitude = -latitude;
            }

            if (rbWestLongitudeStarObservation.Checked)
            {
                longitude = -longitude;
            }

            // TODO: calculate star rise and set time
            StarObservation starObservation = new StarObservation
            {
                StarName = star.Name,
                ObservationDate = DateTime.Today,
                StarRiseTime = new TimeSpan(1, 12, 45),
                StarSetTime = new TimeSpan(3, 30, 55)
            };

            datagridObservationHours.Columns[0].DataPropertyName = "StarName";
            datagridObservationHours.Columns[1].DataPropertyName = "ObservationDate";
            datagridObservationHours.Columns[2].DataPropertyName = "StarRiseTime";
            datagridObservationHours.Columns[3].DataPropertyName = "StarSetTime";

            datagridObservationHours.DataSource = new BindingSource { DataSource = starObservation };
        }
    }
}
