using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MPUGyro
{
    public interface INewForm
    {
        Chart Chart_bigkren0 { get; set; }
    }
    public partial class Form2 : Form, INewForm
    {
        public Chart Chart_bigkren0
        {
            get { return chart_bigkren0; }
            set { chart_bigkren0 = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
