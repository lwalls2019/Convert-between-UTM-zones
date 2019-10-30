using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSGeo.GDAL;
using OSGeo.OGR;
using OSGeo.OSR;

/// <summary>
/// Publishing to GitHub 10/30/2019
/// </summary>
/// making changes
namespace Convert_between_UTM_zones
{
    public partial class UTM_Zone_Conversion : Form
    {
        public UTM_Zone_Conversion()
        {
            InitializeComponent();
            cbo_North_or_South.SelectedIndex = 1;
        }

        private void btnFindCoords_Click(object sender, EventArgs e)
        {
            // Reads in latidue, longitude and UTM zone and calculates UTM coordinates

            // first read in lat, long and UTM zone
            float Lat = 0;
            float Long = 0;
            int UTM_Zone = 0;


            try
            {
                Lat = Convert.ToSingle(txtLat.Text);
            }
            catch
            {
                MessageBox.Show("Invalid latitude.");
                return;
            }

            try
            {
                Long = Convert.ToSingle(txtLong.Text);
            }
            catch
            {
                MessageBox.Show("Invalid longitude.");
                return;
            }

            try
            {
                UTM_Zone = Convert.ToInt16(txtUTMZone.Text);
            }
            catch
            {
                MessageBox.Show("Invalid UTM zone.");
                return;
            }

            // Now convert lat/long to UTM
            Gdal.AllRegister();
                        
            // Create a spatial reference with geographic (lat/long) coordinates 

            String Lat_Long_Proj_Str = "GEOGCS[\"NAD83\", DATUM[\"North_American_Datum_1983\", SPHEROID[\"GRS 1980\", 6378137, 298.257222101, AUTHORITY[\"EPSG\", \"7019\"]], TOWGS84[0, 0, 0, 0, 0, 0, 0], AUTHORITY[\"EPSG\", \"6269\"]], PRIMEM[\"Greenwich\", 0, AUTHORITY[\"EPSG\", \"8901\"]], UNIT[\"degree\", 0.0174532925199433, AUTHORITY[\"EPSG\", \"9108\"]], AUTHORITY[\"EPSG\", \"4269\"]]";
            SpatialReference Lat_Long = new SpatialReference(Lat_Long_Proj_Str);

            SpatialReference UTM_proj = new SpatialReference("");
            UTM_proj.SetProjCS("UTM Proj");
            UTM_proj.SetWellKnownGeogCS("NAD83");

            int North_or_South = cbo_North_or_South.SelectedIndex;
            
            UTM_proj.SetUTM(UTM_Zone, North_or_South);

            CoordinateTransformation ct = new CoordinateTransformation(Lat_Long, UTM_proj);
            Double[] UTM_Point = new Double[3];
            UTM_Point[0] = Long;
            UTM_Point[1] = Lat;

            ct.TransformPoint(UTM_Point);

            txtUTMX.Text = Math.Round(UTM_Point[0],1).ToString();
            txtUTMY.Text = Math.Round(UTM_Point[1],1).ToString();


        }
    }
}
